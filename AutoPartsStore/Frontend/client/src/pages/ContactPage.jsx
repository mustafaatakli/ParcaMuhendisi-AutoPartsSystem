import { useState } from 'react';
import './InfoPages.css';

const ContactPage = () => {
  const [formData, setFormData] = useState({
    name: '',
    email: '',
    phone: '',
    subject: '',
    message: ''
  });

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    alert('Mesajınız alındı! En kısa sürede size dönüş yapacağız.');
    setFormData({
      name: '',
      email: '',
      phone: '',
      subject: '',
      message: ''
    });
  };

  return (
    <div className="info-page">
      <div className="container">
        <h1>İletişim</h1>

        <div className="info-content">
          <div className="contact-grid">
            <div className="contact-info">
              <h2>İletişim Bilgileri</h2>

              <div className="contact-item">
                <div className="contact-icon">📞</div>
                <div>
                  <h3>Telefon</h3>
                  <p>0850 123 45 67</p>
                  <p className="text-small">Hafta içi 09:00 - 18:00</p>
                </div>
              </div>

              <div className="contact-item">
                <div className="contact-icon">✉️</div>
                <div>
                  <h3>E-posta</h3>
                  <p>info@parcamuhendisi.com</p>
                  <p className="text-small">24 saat içinde yanıt</p>
                </div>
              </div>

              <div className="contact-item">
                <div className="contact-icon">📍</div>
                <div>
                  <h3>Adres</h3>
                  <p>Atatürk Mahallesi</p>
                  <p>Otomotiv Caddesi No: 123</p>
                  <p>Kadıköy / İstanbul</p>
                </div>
              </div>

              <div className="contact-item">
                <div className="contact-icon">⏰</div>
                <div>
                  <h3>Çalışma Saatleri</h3>
                  <p>Pazartesi - Cuma: 09:00 - 18:00</p>
                  <p>Cumartesi: 09:00 - 15:00</p>
                  <p>Pazar: Kapalı</p>
                </div>
              </div>
            </div>

            <div className="contact-form-container">
              <h2>Bize Ulaşın</h2>
              <form className="contact-form" onSubmit={handleSubmit}>
                <div className="form-group">
                  <label htmlFor="name">Ad Soyad *</label>
                  <input
                    type="text"
                    id="name"
                    name="name"
                    value={formData.name}
                    onChange={handleChange}
                    required
                  />
                </div>

                <div className="form-group">
                  <label htmlFor="email">E-posta *</label>
                  <input
                    type="email"
                    id="email"
                    name="email"
                    value={formData.email}
                    onChange={handleChange}
                    required
                  />
                </div>

                <div className="form-group">
                  <label htmlFor="phone">Telefon</label>
                  <input
                    type="tel"
                    id="phone"
                    name="phone"
                    value={formData.phone}
                    onChange={handleChange}
                  />
                </div>

                <div className="form-group">
                  <label htmlFor="subject">Konu *</label>
                  <input
                    type="text"
                    id="subject"
                    name="subject"
                    value={formData.subject}
                    onChange={handleChange}
                    required
                  />
                </div>

                <div className="form-group">
                  <label htmlFor="message">Mesajınız *</label>
                  <textarea
                    id="message"
                    name="message"
                    rows="5"
                    value={formData.message}
                    onChange={handleChange}
                    required
                  ></textarea>
                </div>

                <button type="submit" className="submit-btn">
                  Gönder
                </button>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ContactPage;
