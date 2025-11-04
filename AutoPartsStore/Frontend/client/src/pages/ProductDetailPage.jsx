import { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { productsAPI } from '../services/api';
import { useCart } from '../context/CartContext';
import { useWishlist } from '../context/WishlistContext';
import './ProductDetailPage.css';

const ProductDetailPage = () => {
  const { id } = useParams();
  const navigate = useNavigate();
  const { addToCart } = useCart();
  const { addToWishlist, removeFromWishlist, isInWishlist } = useWishlist();
  const [product, setProduct] = useState(null);
  const [loading, setLoading] = useState(true);
  const [quantity, setQuantity] = useState(1);
  const [activeTab, setActiveTab] = useState('description');

  useEffect(() => {
    fetchProduct();
  }, [id]);

  const fetchProduct = async () => {
    try {
      setLoading(true);
      const response = await productsAPI.getById(id);
      setProduct(response.data);
    } catch (error) {
      console.error('Error fetching product:', error);
    } finally {
      setLoading(false);
    }
  };

  const handleQuantityChange = (delta) => {
    const newQuantity = quantity + delta;
    if (newQuantity >= 1 && newQuantity <= product.stock) {
      setQuantity(newQuantity);
    }
  };

  const handleAddToCart = () => {
    for (let i = 0; i < quantity; i++) {
      addToCart(product);
    }
    alert(`${quantity} adet ${product.name} sepete eklendi!`);
    setQuantity(1); // Miktarı sıfırla
  };

  const handleToggleWishlist = () => {
    if (isInWishlist(product.id)) {
      removeFromWishlist(product.id);
      alert(`${product.name} favorilerden çıkarıldı!`);
    } else {
      addToWishlist(product);
      alert(`${product.name} favorilere eklendi!`);
    }
  };

  if (loading) {
    return (
      <div className="product-detail-loading">
        <p>Yükleniyor...</p>
      </div>
    );
  }

  if (!product) {
    return (
      <div className="product-detail-error">
        <p>Ürün bulunamadı</p>
        <button onClick={() => navigate('/')}>Ana Sayfaya Dön</button>
      </div>
    );
  }

  return (
    <div className="product-detail-page">
      <div className="container">
        {/* Breadcrumb */}
        <div className="breadcrumb">
          <span onClick={() => navigate('/')}>Ana Sayfa</span>
          <span> / </span>
          <span onClick={() => navigate(`/category/${product.category?.slug}`)}>
            {product.category?.name}
          </span>
          <span> / </span>
          <span>{product.name}</span>
        </div>

        <div className="product-detail-content">
          {/* Sol Taraf - Görsel */}
          <div className="product-image-section">
            <div className="product-main-image">
              <img src={product.imageUrl} alt={product.name} />
            </div>
          </div>

          {/* Sağ Taraf - Bilgiler */}
          <div className="product-info-section">
            <h1 className="product-title">{product.name}</h1>

            <div className="product-meta">
              <div className="meta-item">
                <span className="meta-label">MARKA:</span>
                <span className="meta-value">{product.brand?.name || product.brand}</span>
              </div>
              <div className="meta-item">
                <span className="meta-label">STOK KODU:</span>
                <span className="meta-value">{product.partNumber}</span>
              </div>
            </div>

            {product.rating > 0 && (
              <div className="product-rating">
                <div className="stars">
                  {[...Array(5)].map((_, i) => (
                    <span key={i} className={i < Math.round(product.rating) ? 'star filled' : 'star'}>
                      ★
                    </span>
                  ))}
                </div>
                <span className="review-count">({product.reviewCount} değerlendirme)</span>
              </div>
            )}

            <div className="product-price">
              {product.oldPrice && (
                <span className="old-price">{product.oldPrice.toFixed(2)} TL</span>
              )}
              <span className="current-price">{product.price.toFixed(2)} TL</span>
            </div>

            {product.discountPercentage && (
              <div className="discount-badge">
                %{product.discountPercentage} İndirim
              </div>
            )}

            {/* Miktar Seçici */}
            <div className="quantity-section">
              <label>Miktar:</label>
              <div className="quantity-controls">
                <button
                  onClick={() => handleQuantityChange(-1)}
                  disabled={quantity <= 1}
                >
                  -
                </button>
                <input
                  type="number"
                  value={quantity}
                  onChange={(e) => {
                    const val = parseInt(e.target.value);
                    if (val >= 1 && val <= product.stock) {
                      setQuantity(val);
                    }
                  }}
                  min="1"
                  max={product.stock}
                />
                <button
                  onClick={() => handleQuantityChange(1)}
                  disabled={quantity >= product.stock}
                >
                  +
                </button>
              </div>
            </div>

            {/* Sepete Ekle ve Favorilere Ekle Butonları */}
            <div className="action-buttons">
              <button
                className="add-to-cart-btn"
                onClick={handleAddToCart}
                disabled={product.stock === 0}
              >
                {product.stock > 0 ? 'Sepete Ekle' : 'Stokta Yok'}
              </button>
              <button
                className="add-to-wishlist-btn"
                onClick={handleToggleWishlist}
                title={isInWishlist(product.id) ? 'Favorilerden Çıkar' : 'Favorilere Ekle'}
              >
                {isInWishlist(product.id) ? '❤️' : '🤍'}
              </button>
            </div>

            {/* Stok Bilgisi */}
            <div className="stock-info">
              {product.stock > 0 ? (
                <span className="in-stock">✓ Stokta ({product.stock} adet)</span>
              ) : (
                <span className="out-of-stock">✗ Stokta Yok</span>
              )}
            </div>

            {/* Kargo Bilgisi */}
            <div className="shipping-info">
              <div className="shipping-item">
                <span className="shipping-icon">🚚</span>
                <div>
                  <strong>Ücretsiz Kargo</strong>
                  <p>1000 TL ve üzeri</p>
                </div>
              </div>
              <div className="shipping-item">
                <span className="shipping-icon">📦</span>
                <div>
                  <strong>Hızlı Teslimat</strong>
                  <p>1-3 iş günü</p>
                </div>
              </div>
              <div className="shipping-item">
                <span className="shipping-icon">✓</span>
                <div>
                  <strong>Güvenli Alışveriş</strong>
                  <p>256-bit SSL</p>
                </div>
              </div>
            </div>
          </div>
        </div>

        {/* Sekmeler */}
        <div className="product-tabs">
          <div className="tabs-header">
            <button
              className={activeTab === 'description' ? 'active' : ''}
              onClick={() => setActiveTab('description')}
            >
              Açıklama
            </button>
            <button
              className={activeTab === 'specs' ? 'active' : ''}
              onClick={() => setActiveTab('specs')}
            >
              Uyumlu Araçlar
            </button>
            <button
              className={activeTab === 'reviews' ? 'active' : ''}
              onClick={() => setActiveTab('reviews')}
            >
              Yorumlar ({product.reviewCount})
            </button>
          </div>

          <div className="tabs-content">
            {activeTab === 'description' && (
              <div className="tab-pane">
                <h3>Ürün Açıklaması</h3>
                <p>{product.description}</p>
                <div className="product-features">
                  <h4>Özellikler:</h4>
                  <ul>
                    <li>Marka: {product.brand?.name || product.brand}</li>
                    <li>Parça Numarası: {product.partNumber}</li>
                    <li>Kategori: {product.category?.name}</li>
                    {product.isNew && <li>✨ Yeni Ürün</li>}
                    {product.isFeatured && <li>⭐ Öne Çıkan Ürün</li>}
                  </ul>
                </div>
              </div>
            )}

            {activeTab === 'specs' && (
              <div className="tab-pane">
                <h3>Uyumlu Araç Modelleri</h3>
                <p>
                  Bu ürün aşağıdaki araç modelleri ile uyumludur. Montaj öncesi lütfen
                  aracınızın modelini ve yılını kontrol ediniz.
                </p>
                <div className="compatible-vehicles">
                  <p>Uyumluluk bilgisi için müşteri hizmetlerimizle iletişime geçebilirsiniz.</p>
                </div>
              </div>
            )}

            {activeTab === 'reviews' && (
              <div className="tab-pane">
                <h3>Müşteri Yorumları</h3>
                <div className="reviews-summary">
                  <div className="rating-large">
                    <span className="rating-number">{product.rating.toFixed(1)}</span>
                    <div className="stars-large">
                      {[...Array(5)].map((_, i) => (
                        <span key={i} className={i < Math.round(product.rating) ? 'star filled' : 'star'}>
                          ★
                        </span>
                      ))}
                    </div>
                    <p>{product.reviewCount} değerlendirme</p>
                  </div>
                </div>
                <p className="no-reviews">Henüz yorum yapılmamış. İlk yorumu siz yapın!</p>
              </div>
            )}
          </div>
        </div>
      </div>
    </div>
  );
};

export default ProductDetailPage;
