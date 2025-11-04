import { useState } from 'react';
import { useCart } from '../context/CartContext';
import { ordersAPI } from '../services/api';
import { useNavigate } from 'react-router-dom';

const CheckoutPage = () => {
  const { cart, getCartTotal, clearCart } = useCart();
  const navigate = useNavigate();

  const [formData, setFormData] = useState({
    customerName: '',
    customerEmail: '',
    customerPhone: '',
    shippingAddress: '',
    city: '',
    postalCode: '',
  });

  const [loading, setLoading] = useState(false);
  const [error, setError] = useState('');

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setLoading(true);
    setError('');

    try {
      const orderData = {
        ...formData,
        items: cart.map((item) => ({
          productId: item.id,
          quantity: item.quantity,
        })),
      };

      const response = await ordersAPI.create(orderData);
      clearCart();
      alert(`Siparişiniz başarıyla oluşturuldu! Sipariş No: ${response.data.orderNumber}`);
      navigate('/');
    } catch (err) {
      setError('Sipariş oluşturulurken bir hata oluştu. Lütfen tekrar deneyin.');
      console.error('Order error:', err);
    } finally {
      setLoading(false);
    }
  };

  if (cart.length === 0) {
    return (
      <div className="container">
        <div className="empty-cart">
          <h2>Sepetiniz boş!</h2>
          <p>Sipariş vermek için önce sepetinize ürün ekleyin.</p>
        </div>
      </div>
    );
  }

  return (
    <div className="container cart-page">
      <h1 className="section-title">Sipariş Bilgileri</h1>

      {error && (
        <div style={{ color: 'red', marginBottom: '20px', padding: '10px', border: '1px solid red' }}>
          {error}
        </div>
      )}

      <div style={{ display: 'grid', gridTemplateColumns: '2fr 1fr', gap: '30px' }}>
        <form onSubmit={handleSubmit} style={{ backgroundColor: 'white', padding: '30px', borderRadius: '8px', border: '1px solid #e0e0e0' }}>
          <h2 style={{ marginBottom: '20px' }}>İletişim Bilgileri</h2>

          <div style={{ marginBottom: '20px' }}>
            <label style={{ display: 'block', marginBottom: '5px', fontWeight: '600' }}>
              Ad Soyad *
            </label>
            <input
              type="text"
              name="customerName"
              value={formData.customerName}
              onChange={handleChange}
              required
              style={{ width: '100%', padding: '12px', border: '1px solid #e0e0e0', borderRadius: '4px' }}
            />
          </div>

          <div style={{ marginBottom: '20px' }}>
            <label style={{ display: 'block', marginBottom: '5px', fontWeight: '600' }}>
              E-posta *
            </label>
            <input
              type="email"
              name="customerEmail"
              value={formData.customerEmail}
              onChange={handleChange}
              required
              style={{ width: '100%', padding: '12px', border: '1px solid #e0e0e0', borderRadius: '4px' }}
            />
          </div>

          <div style={{ marginBottom: '20px' }}>
            <label style={{ display: 'block', marginBottom: '5px', fontWeight: '600' }}>
              Telefon *
            </label>
            <input
              type="tel"
              name="customerPhone"
              value={formData.customerPhone}
              onChange={handleChange}
              required
              style={{ width: '100%', padding: '12px', border: '1px solid #e0e0e0', borderRadius: '4px' }}
            />
          </div>

          <h2 style={{ marginBottom: '20px', marginTop: '30px' }}>Teslimat Adresi</h2>

          <div style={{ marginBottom: '20px' }}>
            <label style={{ display: 'block', marginBottom: '5px', fontWeight: '600' }}>
              Adres *
            </label>
            <textarea
              name="shippingAddress"
              value={formData.shippingAddress}
              onChange={handleChange}
              required
              rows="3"
              style={{ width: '100%', padding: '12px', border: '1px solid #e0e0e0', borderRadius: '4px' }}
            />
          </div>

          <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '20px' }}>
            <div style={{ marginBottom: '20px' }}>
              <label style={{ display: 'block', marginBottom: '5px', fontWeight: '600' }}>
                Şehir *
              </label>
              <input
                type="text"
                name="city"
                value={formData.city}
                onChange={handleChange}
                required
                style={{ width: '100%', padding: '12px', border: '1px solid #e0e0e0', borderRadius: '4px' }}
              />
            </div>

            <div style={{ marginBottom: '20px' }}>
              <label style={{ display: 'block', marginBottom: '5px', fontWeight: '600' }}>
                Posta Kodu *
              </label>
              <input
                type="text"
                name="postalCode"
                value={formData.postalCode}
                onChange={handleChange}
                required
                style={{ width: '100%', padding: '12px', border: '1px solid #e0e0e0', borderRadius: '4px' }}
              />
            </div>
          </div>

          <button
            type="submit"
            className="checkout-button"
            disabled={loading}
            style={{ marginTop: '20px' }}
          >
            {loading ? 'İşleniyor...' : 'Siparişi Tamamla'}
          </button>
        </form>

        <div>
          <div className="cart-summary">
            <h2 style={{ marginBottom: '20px' }}>Sipariş Özeti</h2>

            {cart.map((item) => (
              <div key={item.id} style={{ display: 'flex', justifyContent: 'space-between', marginBottom: '10px', paddingBottom: '10px', borderBottom: '1px solid #e0e0e0' }}>
                <span>{item.name} x{item.quantity}</span>
                <span>{(item.price * item.quantity).toFixed(2)} TL</span>
              </div>
            ))}

            <div className="cart-total" style={{ marginTop: '20px', paddingTop: '20px', borderTop: '2px solid #e0e0e0' }}>
              <span>Toplam:</span>
              <span>{getCartTotal().toFixed(2)} TL</span>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default CheckoutPage;
