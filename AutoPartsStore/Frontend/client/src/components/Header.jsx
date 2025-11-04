import { Link, useNavigate } from 'react-router-dom';
import { useState, useEffect } from 'react';
import { useCart } from '../context/CartContext';
import { useAuth } from '../context/AuthContext';
import { useWishlist } from '../context/WishlistContext';
import { categoriesAPI, brandsAPI } from '../services/api';

const Header = () => {
  const { getCartCount } = useCart();
  const { wishlistCount } = useWishlist();
  const { user, logout, isAdmin } = useAuth();
  const navigate = useNavigate();
  const [categories, setCategories] = useState([]);
  const [brands, setBrands] = useState([]);
  const [selectedBrand, setSelectedBrand] = useState('');
  const [isDropdownOpen, setIsDropdownOpen] = useState(false);
  const [isUserMenuOpen, setIsUserMenuOpen] = useState(false);
  const [searchQuery, setSearchQuery] = useState('');

  useEffect(() => {
    const fetchCategories = async () => {
      try {
        console.log('Fetching categories...');
        const response = await categoriesAPI.getAll();
        console.log('Categories response:', response.data);
        setCategories(response.data);
        console.log('Categories set to state, length:', response.data.length);
      } catch (error) {
        console.error('Error fetching categories:', error);
        console.error('Error details:', error.response?.data);
      }
    };
    fetchCategories();
  }, []);

  useEffect(() => {
    const fetchBrands = async () => {
      try {
        const response = await brandsAPI.getAll();
        setBrands(response.data);
      } catch (error) {
        console.error('Error fetching brands:', error);
      }
    };
    fetchBrands();
  }, []);

  const handleBrandChange = (e) => {
    const brandSlug = e.target.value;
    setSelectedBrand(brandSlug);
    if (brandSlug) {
      navigate(`/brand/${brandSlug}`);
    }
  };

  const handleSearch = (e) => {
    e.preventDefault();
    if (searchQuery.trim()) {
      navigate(`/search?q=${encodeURIComponent(searchQuery.trim())}`);
    }
  };

  return (
    <header className="header">
      <div className="header-top">
        <div className="container">
          <div>Hoş Geldiniz! Yedek Parça Mühendisi</div>
          <div>
            {user ? (
              <div className="user-menu-container">
                <span onClick={() => setIsUserMenuOpen(!isUserMenuOpen)} style={{ cursor: 'pointer' }}>
                  👤 {user.fullName}
                </span>
                {isUserMenuOpen && (
                  <div className="user-dropdown-menu">
                    <Link to="/profile" onClick={() => setIsUserMenuOpen(false)}>
                      👤 Profilim
                    </Link>
                    <Link to="/orders" onClick={() => setIsUserMenuOpen(false)}>
                      📦 Siparişlerim
                    </Link>
                    <Link to="/wishlist" onClick={() => setIsUserMenuOpen(false)}>
                      ❤️ Favorilerim
                    </Link>
                    {isAdmin() && (
                      <Link to="/admin" onClick={() => setIsUserMenuOpen(false)}>
                        🔧 Admin Panel
                      </Link>
                    )}
                    <a onClick={() => { logout(); setIsUserMenuOpen(false); }}>
                      🚪 Çıkış Yap
                    </a>
                  </div>
                )}
              </div>
            ) : (
              <>
                <Link to="/login" style={{ color: 'white', textDecoration: 'none' }}>Giriş Yap</Link> | <Link to="/register" style={{ color: 'white', textDecoration: 'none' }}>Üye Ol</Link>
              </>
            )}
          </div>
        </div>
      </div>

      <div className="header-main">
        <div className="container">
          <Link to="/" className="logo">
            Parça Mühendisi
          </Link>

          <div className="search-bar">
            <form className="search-form" onSubmit={handleSearch}>
              <select
                className="brand-select"
                value={selectedBrand}
                onChange={handleBrandChange}
              >
                <option value="">Marka Seç</option>
                {brands.map((brand) => (
                  <option key={brand.id} value={brand.slug}>
                    {brand.name}
                  </option>
                ))}
              </select>
              <input
                type="text"
                className="search-input"
                placeholder="Yedek parça ara..."
                value={searchQuery}
                onChange={(e) => setSearchQuery(e.target.value)}
              />
              <button type="submit" className="search-button">
                Ara
              </button>
            </form>
          </div>

          <div className="header-actions">
            <Link to="/wishlist" className="header-action">
              <span>❤️</span>
              <span>Favorilerim</span>
              {wishlistCount > 0 && (
                <span className="cart-badge">{wishlistCount}</span>
              )}
            </Link>
            <Link to="/cart" className="header-action">
              <span>🛒</span>
              <span>Sepetim</span>
              {getCartCount() > 0 && (
                <span className="cart-badge">{getCartCount()}</span>
              )}
            </Link>
          </div>
        </div>
      </div>

      <nav className="nav">
        <div className="container nav-with-dropdown">
          <div className="category-dropdown">
            <button
              className="category-dropdown-button"
              onClick={() => setIsDropdownOpen(!isDropdownOpen)}
            >
              <span className="menu-icon">☰</span>
              <span>Tüm Kategoriler</span>
              <span className="arrow-icon">{isDropdownOpen ? '▲' : '▼'}</span>
            </button>

            {isDropdownOpen && (
              <div className="category-dropdown-menu">
                {categories.map((category) => (
                  <Link
                    key={category.id}
                    to={`/category/${category.slug}`}
                    className="category-dropdown-item"
                    onClick={() => setIsDropdownOpen(false)}
                  >
                    <span className="category-icon">📦</span>
                    {category.name}
                  </Link>
                ))}
              </div>
            )}
          </div>

          <ul className="nav-container">
            <li><Link to="/category/motor-parcalari" className="nav-link">Motor Parçaları</Link></li>
            <li><Link to="/category/fren-sistemi" className="nav-link">Fren Sistemi</Link></li>
            <li><Link to="/category/filtreler" className="nav-link">Filtreler</Link></li>
            <li><Link to="/category/elektrik-aksami" className="nav-link">Elektrik Aksamı</Link></li>
            <li><Link to="/category/suspansiyon" className="nav-link">Süspansiyon</Link></li>
            <li><Link to="/category/sanziman" className="nav-link">Şanzıman</Link></li>
            <li><Link to="/category/karoseri" className="nav-link">Karoseri</Link></li>
          </ul>
        </div>
      </nav>
    </header>
  );
};

export default Header;
