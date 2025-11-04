import { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '../context/AuthContext';
import { adminAPI, categoriesAPI, brandsAPI, partBrandsAPI } from '../services/api';

const AdminPage = () => {
  const { user, isAdmin, loading } = useAuth();
  const navigate = useNavigate();
  const [activeTab, setActiveTab] = useState('dashboard');
  const [stats, setStats] = useState(null);
  const [products, setProducts] = useState([]);
  const [categories, setCategories] = useState([]);
  const [brands, setBrands] = useState([]);
  const [partBrands, setPartBrands] = useState([]);
  const [orders, setOrders] = useState([]);
  const [showProductForm, setShowProductForm] = useState(false);
  const [editingProduct, setEditingProduct] = useState(null);
  const [productForm, setProductForm] = useState({
    name: '',
    description: '',
    brandId: '',
    partBrandId: '',
    partNumber: '',
    price: '',
    oldPrice: '',
    stock: '',
    imageUrl: '',
    categoryId: '',
    isFeatured: false,
    isNew: false,
    discountPercentage: '',
    badgeText: '',
  });

  useEffect(() => {
    if (loading) return;

    if (!user || !isAdmin()) {
      navigate('/login');
      return;
    }

    fetchData();
  }, [user, isAdmin, navigate, loading]);

  const fetchData = async () => {
    try {
      // Önce kategorileri, markaları ve parça markalarını yükle
      const [categoriesRes, brandsRes, partBrandsRes] = await Promise.all([
        categoriesAPI.getAll(),
        brandsAPI.getAll(),
        partBrandsAPI.getAll(),
      ]);
      console.log('Categories loaded:', categoriesRes.data);
      console.log('Brands loaded:', brandsRes.data);
      console.log('PartBrands loaded:', partBrandsRes.data);
      setCategories(categoriesRes.data);
      setBrands(brandsRes.data);
      setPartBrands(partBrandsRes.data);

      // Sonra diğer verileri yükle
      const [statsRes, productsRes, ordersRes] = await Promise.all([
        adminAPI.getStats(),
        adminAPI.getAllProducts(),
        adminAPI.getAllOrders(),
      ]);

      console.log('Stats:', statsRes.data);
      console.log('Products:', productsRes.data);
      console.log('Orders:', ordersRes.data);

      setStats(statsRes.data);
      setProducts(productsRes.data);
      setOrders(ordersRes.data);
    } catch (error) {
      console.error('Error fetching admin data:', error);
      console.error('Error details:', error.response?.data);
      if (error.response?.status === 401) {
        alert('Oturum süreniz dolmuş. Lütfen tekrar giriş yapın.');
        navigate('/login');
      }
    }
  };

  const handleProductSubmit = async (e) => {
    e.preventDefault();

    const productData = {
      ...productForm,
      price: parseFloat(productForm.price),
      oldPrice: productForm.oldPrice ? parseFloat(productForm.oldPrice) : null,
      stock: parseInt(productForm.stock),
      categoryId: parseInt(productForm.categoryId),
      brandId: parseInt(productForm.brandId),
      partBrandId: parseInt(productForm.partBrandId),
      discountPercentage: productForm.discountPercentage ? parseInt(productForm.discountPercentage) : null,
    };

    try {
      if (editingProduct) {
        await adminAPI.updateProduct(editingProduct.id, productData);
        alert('Ürün başarıyla güncellendi!');
      } else {
        await adminAPI.createProduct(productData);
        alert('Ürün başarıyla eklendi!');
      }

      setShowProductForm(false);
      setEditingProduct(null);
      resetProductForm();
      fetchData();
    } catch (error) {
      alert('Hata: ' + (error.response?.data?.message || 'İşlem başarısız'));
    }
  };

  const handleEditProduct = (product) => {
    setEditingProduct(product);
    setProductForm({
      name: product.name,
      description: product.description,
      brandId: product.brandId.toString(),
      partBrandId: product.partBrandId.toString(),
      partNumber: product.partNumber,
      price: product.price.toString(),
      oldPrice: product.oldPrice?.toString() || '',
      stock: product.stock.toString(),
      imageUrl: product.imageUrl,
      categoryId: product.categoryId.toString(),
      isFeatured: product.isFeatured,
      isNew: product.isNew,
      discountPercentage: product.discountPercentage?.toString() || '',
      badgeText: product.badgeText || '',
    });
    setShowProductForm(true);
  };

  const handleDeleteProduct = async (id) => {
    if (!confirm('Bu ürünü silmek istediğinizden emin misiniz?')) return;

    try {
      await adminAPI.deleteProduct(id);
      alert('Ürün silindi!');
      fetchData();
    } catch (error) {
      alert('Silme hatası: ' + error.message);
    }
  };

  const resetProductForm = () => {
    setProductForm({
      name: '',
      description: '',
      brandId: '',
      partBrandId: '',
      partNumber: '',
      price: '',
      oldPrice: '',
      stock: '',
      imageUrl: '',
      categoryId: '',
      isFeatured: false,
      isNew: false,
      discountPercentage: '',
      badgeText: '',
    });
  };

  if (loading) {
    return (
      <div style={{ display: 'flex', justifyContent: 'center', alignItems: 'center', minHeight: '80vh' }}>
        <p>Yükleniyor...</p>
      </div>
    );
  }

  if (!user || !isAdmin()) {
    return null;
  }

  return (
    <div className="admin-page">
      <div className="admin-sidebar">
        <h2>Admin Panel</h2>
        <ul>
          <li className={activeTab === 'dashboard' ? 'active' : ''} onClick={() => setActiveTab('dashboard')}>
            📊 Dashboard
          </li>
          <li className={activeTab === 'products' ? 'active' : ''} onClick={() => setActiveTab('products')}>
            📦 Ürünler
          </li>
          <li className={activeTab === 'orders' ? 'active' : ''} onClick={() => setActiveTab('orders')}>
            🛒 Siparişler
          </li>
        </ul>
      </div>

      <div className="admin-content">
        {activeTab === 'dashboard' && stats && (
          <div className="dashboard">
            <h1>Dashboard</h1>
            <div className="stats-grid">
              <div className="stat-card">
                <h3>Toplam Ürün</h3>
                <p className="stat-number">{stats.totalProducts}</p>
              </div>
              <div className="stat-card">
                <h3>Toplam Sipariş</h3>
                <p className="stat-number">{stats.totalOrders}</p>
              </div>
              <div className="stat-card">
                <h3>Toplam Kullanıcı</h3>
                <p className="stat-number">{stats.totalUsers}</p>
              </div>
              <div className="stat-card">
                <h3>Toplam Gelir</h3>
                <p className="stat-number">{stats.totalRevenue.toFixed(2)} TL</p>
              </div>
            </div>
          </div>
        )}

        {activeTab === 'products' && (
          <div className="products-management">
            <div className="management-header">
              <h1>Ürün Yönetimi</h1>
              <button
                className="add-button"
                onClick={() => {
                  setEditingProduct(null);
                  resetProductForm();
                  setShowProductForm(true);
                }}
              >
                + Yeni Ürün Ekle
              </button>
            </div>

            {showProductForm && categories.length > 0 && brands.length > 0 && partBrands.length > 0 && (
              <div className="product-form-modal">
                <div className="modal-content">
                  <h2>{editingProduct ? 'Ürün Düzenle' : 'Yeni Ürün Ekle'}</h2>
                  <form onSubmit={handleProductSubmit}>
                    <div className="form-grid">
                      <input
                        type="text"
                        placeholder="Ürün Adı"
                        value={productForm.name}
                        onChange={(e) => setProductForm({ ...productForm, name: e.target.value })}
                        required
                      />
                      <select
                        value={productForm.brandId}
                        onChange={(e) => setProductForm({ ...productForm, brandId: e.target.value })}
                        required
                      >
                        <option value="">Araç Markası Seçin</option>
                        {brands.map((brand) => (
                          <option key={brand.id} value={brand.id}>
                            {brand.name}
                          </option>
                        ))}
                      </select>
                      <select
                        value={productForm.partBrandId}
                        onChange={(e) => setProductForm({ ...productForm, partBrandId: e.target.value })}
                        required
                      >
                        <option value="">Parça Markası Seçin</option>
                        {partBrands.map((partBrand) => (
                          <option key={partBrand.id} value={partBrand.id}>
                            {partBrand.name}
                          </option>
                        ))}
                      </select>
                      <input
                        type="text"
                        placeholder="Parça Numarası"
                        value={productForm.partNumber}
                        onChange={(e) => setProductForm({ ...productForm, partNumber: e.target.value })}
                        required
                      />
                      <input
                        type="number"
                        step="0.01"
                        placeholder="Fiyat"
                        value={productForm.price}
                        onChange={(e) => setProductForm({ ...productForm, price: e.target.value })}
                        required
                      />
                      <input
                        type="number"
                        step="0.01"
                        placeholder="Eski Fiyat (Opsiyonel)"
                        value={productForm.oldPrice}
                        onChange={(e) => setProductForm({ ...productForm, oldPrice: e.target.value })}
                      />
                      <input
                        type="number"
                        placeholder="Stok"
                        value={productForm.stock}
                        onChange={(e) => setProductForm({ ...productForm, stock: e.target.value })}
                        required
                      />
                      <select
                        value={productForm.categoryId}
                        onChange={(e) => {
                          console.log('Selected category:', e.target.value);
                          setProductForm({ ...productForm, categoryId: e.target.value });
                        }}
                        required
                      >
                        <option value="">Kategori Seçin ({categories.length} kategori mevcut)</option>
                        {categories.map((cat) => (
                          <option key={cat.id} value={cat.id}>
                            {cat.name}
                          </option>
                        ))}
                      </select>
                      <input
                        type="text"
                        placeholder="Resim URL"
                        value={productForm.imageUrl}
                        onChange={(e) => setProductForm({ ...productForm, imageUrl: e.target.value })}
                      />
                    </div>
                    <textarea
                      placeholder="Açıklama"
                      value={productForm.description}
                      onChange={(e) => setProductForm({ ...productForm, description: e.target.value })}
                      required
                      rows="3"
                    />
                    <div className="form-checkboxes">
                      <label>
                        <input
                          type="checkbox"
                          checked={productForm.isFeatured}
                          onChange={(e) => setProductForm({ ...productForm, isFeatured: e.target.checked })}
                        />
                        Öne Çıkan
                      </label>
                      <label>
                        <input
                          type="checkbox"
                          checked={productForm.isNew}
                          onChange={(e) => setProductForm({ ...productForm, isNew: e.target.checked })}
                        />
                        Yeni Ürün
                      </label>
                    </div>
                    <div className="form-actions">
                      <button type="submit" className="save-button">
                        {editingProduct ? 'Güncelle' : 'Ekle'}
                      </button>
                      <button
                        type="button"
                        className="cancel-button"
                        onClick={() => {
                          setShowProductForm(false);
                          setEditingProduct(null);
                          resetProductForm();
                        }}
                      >
                        İptal
                      </button>
                    </div>
                  </form>
                </div>
              </div>
            )}

            <div className="products-table">
              <table>
                <thead>
                  <tr>
                    <th>ID</th>
                    <th>Ürün Adı</th>
                    <th>Marka</th>
                    <th>Fiyat</th>
                    <th>Stok</th>
                    <th>İşlemler</th>
                  </tr>
                </thead>
                <tbody>
                  {products.map((product) => (
                    <tr key={product.id}>
                      <td>{product.id}</td>
                      <td>{product.name}</td>
                      <td>{product.brand?.name || product.brand}</td>
                      <td>{product.price.toFixed(2)} TL</td>
                      <td>{product.stock}</td>
                      <td>
                        <button onClick={() => handleEditProduct(product)} className="edit-btn">
                          Düzenle
                        </button>
                        <button onClick={() => handleDeleteProduct(product.id)} className="delete-btn">
                          Sil
                        </button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          </div>
        )}

        {activeTab === 'orders' && (
          <div className="orders-management">
            <h1>Sipariş Yönetimi</h1>
            <div className="orders-table">
              <table>
                <thead>
                  <tr>
                    <th>Sipariş No</th>
                    <th>Müşteri</th>
                    <th>Tutar</th>
                    <th>Durum</th>
                    <th>Tarih</th>
                  </tr>
                </thead>
                <tbody>
                  {orders.map((order) => (
                    <tr key={order.id}>
                      <td>{order.orderNumber}</td>
                      <td>{order.customerName}</td>
                      <td>{order.totalAmount.toFixed(2)} TL</td>
                      <td>
                        <span className={`status-badge status-${order.status.toLowerCase()}`}>
                          {order.status}
                        </span>
                      </td>
                      <td>{new Date(order.orderDate).toLocaleDateString('tr-TR')}</td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          </div>
        )}
      </div>
    </div>
  );
};

export default AdminPage;
