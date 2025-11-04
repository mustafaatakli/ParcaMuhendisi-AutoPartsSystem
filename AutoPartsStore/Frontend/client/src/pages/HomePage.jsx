import { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import ProductCard from '../components/ProductCard';
import Pagination from '../components/Pagination';
import { productsAPI, categoriesAPI } from '../services/api';

const HomePage = () => {
  const [featuredProducts, setFeaturedProducts] = useState([]);
  const [allProducts, setAllProducts] = useState([]);
  const [categories, setCategories] = useState([]);
  const [loading, setLoading] = useState(true);
  const [showAllProducts, setShowAllProducts] = useState(false);
  const [currentPage, setCurrentPage] = useState(1);
  const productsPerPage = 12;

  useEffect(() => {
    const fetchData = async () => {
      try {
        const [productsResponse, categoriesResponse] = await Promise.all([
          productsAPI.getFeatured(),
          categoriesAPI.getAll(),
        ]);

        setFeaturedProducts(productsResponse.data);
        setCategories(categoriesResponse.data);
      } catch (error) {
        console.error('Error fetching data:', error);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, []);

  const handleShowAllProducts = async () => {
    setShowAllProducts(true);

    if (allProducts.length === 0) {
      try {
        const response = await productsAPI.getAll();
        setAllProducts(response.data);
      } catch (error) {
        console.error('Error fetching all products:', error);
      }
    }

    // Scroll to products section
    setTimeout(() => {
      const productsSection = document.querySelector('.featured-products-modern');
      if (productsSection) {
        productsSection.scrollIntoView({ behavior: 'smooth', block: 'start' });
      }
    }, 100);
  };

  if (loading) {
    return <div className="loading">Yükleniyor...</div>;
  }

  return (
    <div>
      {/* Hero Section */}
      <section className="hero-modern">
        <div className="hero-overlay"></div>
        <div className="container">
          <div className="hero-content-modern">
            <div className="hero-badge">✓ Güvenilir Kalite</div>
            <h1 className="hero-title">
              Araçlarınız İçin <span className="highlight">Kaliteli</span> Yedek Parçalar
            </h1>
            <p className="hero-description">
              Güvenilir markalar, uygun fiyatlar ve hızlı teslimat ile araçlarınızın
              ihtiyaç duyduğu tüm parçalar burada!
            </p>
            <div className="hero-features">
              <div className="hero-feature">
                <span className="feature-icon">🚚</span>
                <span>Hızlı Kargo</span>
              </div>
              <div className="hero-feature">
                <span className="feature-icon">✓</span>
                <span>Orijinal Ürün</span>
              </div>
              <div className="hero-feature">
                <span className="feature-icon">💳</span>
                <span>Güvenli Ödeme</span>
              </div>
            </div>
            <button onClick={handleShowAllProducts} className="hero-button-modern">
              Tüm Ürünleri Keşfet
              <span className="button-arrow">→</span>
            </button>
          </div>
        </div>
      </section>

      {/* Stats Section */}
      <section className="stats-section">
        <div className="container">
          <div className="stats-grid">
            <div className="stat-item">
              <div className="stat-number">10.000+</div>
              <div className="stat-label">Ürün Çeşidi</div>
            </div>
            <div className="stat-item">
              <div className="stat-number">50+</div>
              <div className="stat-label">Marka</div>
            </div>
            <div className="stat-item">
              <div className="stat-number">24/7</div>
              <div className="stat-label">Müşteri Desteği</div>
            </div>
            <div className="stat-item">
              <div className="stat-number">99%</div>
              <div className="stat-label">Müşteri Memnuniyeti</div>
            </div>
          </div>
        </div>
      </section>

      {/* Categories Section */}
      <div className="container">
        <section className="categories-section-modern">
          <div className="section-header">
            <h2 className="section-title-modern">Popüler Kategoriler</h2>
            <p className="section-subtitle">Aradığınız parçayı kolayca bulun</p>
          </div>
          <div className="categories-grid-modern">
            {categories.map((category) => {
              const categoryImages = {
                'motor-parcalari': '/images/categories/motor-parcalari.png',
                'fren-sistemi': '/images/categories/fren-sistemi.png',
                'filtreler': '/images/categories/filtreler.png',
                'elektrik-aksami': '/images/categories/elektrik-aksami.png',
                'suspansiyon': '/images/categories/suspansiyon.png',
                'sanziman': '/images/categories/sanziman.png',
                'karoseri': '/images/categories/karoseri.png'
              };

              const categoryIcons = {
                'motor-parcalari': '⚙️',
                'fren-sistemi': '🛑',
                'filtreler': '🔧',
                'elektrik-aksami': '⚡',
                'suspansiyon': '🔩',
                'sanziman': '⚙️',
                'karoseri': '🚗'
              };

              return (
                <Link
                  key={category.id}
                  to={`/category/${category.slug}`}
                  className="category-card-modern"
                >
                  <div className="category-icon-modern">{categoryIcons[category.slug]}</div>
                  <img
                    src={categoryImages[category.slug]}
                    alt={category.name}
                    className="category-image-modern"
                  />
                  <h3 className="category-name-modern">{category.name}</h3>
                  <p className="category-description">{category.description}</p>
                  <span className="category-arrow">→</span>
                </Link>
              );
            })}
          </div>
        </section>

        {/* Featured Products Section */}
        <section className="featured-products-modern">
          <div className="section-header">
            <h2 className="section-title-modern">
              {showAllProducts ? 'Tüm Ürünler' : 'Öne Çıkan Ürünler'}
            </h2>
            <p className="section-subtitle">En çok tercih edilen ürünler</p>
          </div>
          <div className="products-grid">
            {(() => {
              const products = showAllProducts ? allProducts : featuredProducts;
              const indexOfLastProduct = currentPage * productsPerPage;
              const indexOfFirstProduct = indexOfLastProduct - productsPerPage;
              const currentProducts = products.slice(indexOfFirstProduct, indexOfLastProduct);

              return currentProducts.map((product) => (
                <ProductCard key={product.id} product={product} />
              ));
            })()}
          </div>

          {showAllProducts && allProducts.length > productsPerPage && (
            <Pagination
              currentPage={currentPage}
              totalPages={Math.ceil(allProducts.length / productsPerPage)}
              onPageChange={(page) => {
                setCurrentPage(page);
                window.scrollTo({ top: 0, behavior: 'smooth' });
              }}
            />
          )}
        </section>
      </div>
    </div>
  );
};

export default HomePage;
