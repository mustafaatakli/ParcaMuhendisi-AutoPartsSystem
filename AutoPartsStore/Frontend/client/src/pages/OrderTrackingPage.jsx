import { useState } from 'react';
import './InfoPages.css';

const OrderTrackingPage = () => {
  const [orderNumber, setOrderNumber] = useState('');
  const [email, setEmail] = useState('');
  const [orderStatus, setOrderStatus] = useState(null);

  const handleSubmit = (e) => {
    e.preventDefault();

    // Demo sipariş durumu
    setOrderStatus({
      orderNumber: orderNumber,
      date: '15.01.2025',
      status: 'Kargoda',
      items: [
        { name: 'Fren Diski Ön', quantity: 2, price: 450.00 },
        { name: 'Fren Balatası Takımı', quantity: 1, price: 280.00 }
      ],
      total: 1180.00,
      trackingSteps: [
        { step: 'Sipariş Alındı', date: '15.01.2025 10:30', completed: true },
        { step: 'Hazırlanıyor', date: '15.01.2025 14:20', completed: true },
        { step: 'Kargoya Verildi', date: '16.01.2025 09:15', completed: true },
        { step: 'Dağıtımda', date: '17.01.2025 08:00', completed: true },
        { step: 'Teslim Edildi', date: '-', completed: false }
      ],
      cargoCompany: 'MNG Kargo',
      cargoTrackingNo: 'MNG123456789TR',
      estimatedDelivery: '18.01.2025'
    });
  };

  return (
    <div className="info-page">
      <div className="container">
        <h1>Sipariş Takibi</h1>

        <div className="info-content">
          <section className="info-section">
            <h2>Siparişinizi Takip Edin</h2>
            <p>
              Sipariş numaranız ve e-posta adresinizle siparişinizin durumunu
              anlık olarak takip edebilirsiniz.
            </p>

            <form className="tracking-form" onSubmit={handleSubmit}>
              <div className="form-group">
                <label htmlFor="orderNumber">Sipariş Numarası *</label>
                <input
                  type="text"
                  id="orderNumber"
                  value={orderNumber}
                  onChange={(e) => setOrderNumber(e.target.value)}
                  placeholder="Örn: ORD-2025-12345"
                  required
                />
              </div>

              <div className="form-group">
                <label htmlFor="email">E-posta Adresi *</label>
                <input
                  type="email"
                  id="email"
                  value={email}
                  onChange={(e) => setEmail(e.target.value)}
                  placeholder="ornek@email.com"
                  required
                />
              </div>

              <button type="submit" className="submit-btn">
                Sorgula
              </button>
            </form>
          </section>

          {orderStatus && (
            <section className="info-section order-result">
              <h2>Sipariş Detayları</h2>

              <div className="order-info-grid">
                <div className="order-info-item">
                  <strong>Sipariş No:</strong> {orderStatus.orderNumber}
                </div>
                <div className="order-info-item">
                  <strong>Sipariş Tarihi:</strong> {orderStatus.date}
                </div>
                <div className="order-info-item">
                  <strong>Durum:</strong> <span className="status-badge">{orderStatus.status}</span>
                </div>
                <div className="order-info-item">
                  <strong>Tahmini Teslimat:</strong> {orderStatus.estimatedDelivery}
                </div>
              </div>

              <div className="tracking-timeline">
                <h3>Sipariş Durumu</h3>
                <div className="timeline">
                  {orderStatus.trackingSteps.map((step, index) => (
                    <div key={index} className={`timeline-item ${step.completed ? 'completed' : 'pending'}`}>
                      <div className="timeline-marker">
                        {step.completed ? '✓' : index + 1}
                      </div>
                      <div className="timeline-content">
                        <h4>{step.step}</h4>
                        <p>{step.date}</p>
                      </div>
                    </div>
                  ))}
                </div>
              </div>

              <div className="cargo-info">
                <h3>Kargo Bilgileri</h3>
                <p><strong>Kargo Firması:</strong> {orderStatus.cargoCompany}</p>
                <p><strong>Takip No:</strong> {orderStatus.cargoTrackingNo}</p>
              </div>

              <div className="order-items">
                <h3>Sipariş İçeriği</h3>
                <table className="items-table">
                  <thead>
                    <tr>
                      <th>Ürün</th>
                      <th>Adet</th>
                      <th>Fiyat</th>
                    </tr>
                  </thead>
                  <tbody>
                    {orderStatus.items.map((item, index) => (
                      <tr key={index}>
                        <td>{item.name}</td>
                        <td>{item.quantity}</td>
                        <td>{item.price.toFixed(2)} TL</td>
                      </tr>
                    ))}
                  </tbody>
                  <tfoot>
                    <tr>
                      <td colSpan="2"><strong>Toplam</strong></td>
                      <td><strong>{orderStatus.total.toFixed(2)} TL</strong></td>
                    </tr>
                  </tfoot>
                </table>
              </div>
            </section>
          )}

          <section className="info-section">
            <h2>Sıkça Sorulan Sorular</h2>
            <div className="faq-item">
              <h3>Sipariş numaram nerede?</h3>
              <p>
                Siparişiniz tamamlandıktan sonra, kayıtlı e-posta adresinize
                sipariş numaranızı içeren bir onay e-postası gönderilir.
              </p>
            </div>
            <div className="faq-item">
              <h3>Kargo ne kadar sürede ulaşır?</h3>
              <p>
                Siparişler genellikle 1-3 iş günü içinde kargoya verilir ve
                2-4 iş günü içinde teslim edilir.
              </p>
            </div>
            <div className="faq-item">
              <h3>Kargo takip numaramı nasıl öğrenirim?</h3>
              <p>
                Siparişiniz kargoya verildikten sonra, kargo takip numaranız
                e-posta ile tarafınıza iletilir. Ayrıca bu sayfadan sipariş
                sorgulama yaparak da öğrenebilirsiniz.
              </p>
            </div>
          </section>
        </div>
      </div>
    </div>
  );
};

export default OrderTrackingPage;
