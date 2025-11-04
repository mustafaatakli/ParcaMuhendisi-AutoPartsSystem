import './InfoPages.css';

const CareerPage = () => {
  const openPositions = [
    {
      id: 1,
      title: 'Satış Danışmanı',
      department: 'Satış',
      location: 'İstanbul',
      type: 'Tam Zamanlı',
      description: 'Müşterilerimize yedek parça konusunda danışmanlık yapacak, satış süreçlerini yönetecek deneyimli satış danışmanları arıyoruz.'
    },
    {
      id: 2,
      title: 'Depo Sorumlusu',
      department: 'Lojistik',
      location: 'İstanbul',
      type: 'Tam Zamanlı',
      description: 'Depo operasyonlarını yönetecek, stok kontrolü yapacak ve lojistik süreçleri koordine edecek depo sorumlusu aranmaktadır.'
    },
    {
      id: 3,
      title: 'Müşteri Hizmetleri Uzmanı',
      department: 'Müşteri Hizmetleri',
      location: 'İstanbul',
      type: 'Tam Zamanlı',
      description: 'Müşteri memnuniyetini ön planda tutarak, telefon ve e-posta kanallarından gelen talepleri karşılayacak uzman arıyoruz.'
    },
    {
      id: 4,
      title: 'Web Developer',
      department: 'Bilgi Teknolojileri',
      location: 'İstanbul / Uzaktan',
      type: 'Tam Zamanlı',
      description: 'E-ticaret platformumuzun geliştirilmesi ve bakımı için .NET ve React teknolojilerinde deneyimli yazılım geliştirici aranmaktadır.'
    }
  ];

  return (
    <div className="info-page">
      <div className="container">
        <h1>Kariyer</h1>

        <div className="info-content">
          <section className="info-section">
            <h2>Parça Mühendisi Ailesine Katılın</h2>
            <p>
              Otomotiv sektöründe büyüyen ve gelişen ekibimizin bir parçası olmak
              ister misiniz? Parça Mühendisi olarak, yetenekli ve tutkulu
              profesyonelleri aramaktayız. Birlikte büyüyelim!
            </p>
          </section>

          <section className="info-section">
            <h2>Neden Parça Mühendisi?</h2>
            <ul className="feature-list">
              <li>✓ Dinamik ve genç çalışma ortamı</li>
              <li>✓ Rekabetçi maaş ve yan haklar</li>
              <li>✓ Kariyer gelişim fırsatları</li>
              <li>✓ Eğitim ve gelişim programları</li>
              <li>✓ Esnek çalışma saatleri</li>
              <li>✓ Performans primi</li>
              <li>✓ Özel sağlık sigortası</li>
              <li>✓ Yemek ve ulaşım desteği</li>
            </ul>
          </section>

          <section className="info-section">
            <h2>Açık Pozisyonlar</h2>
            <div className="job-listings">
              {openPositions.map(job => (
                <div key={job.id} className="job-card">
                  <div className="job-header">
                    <h3>{job.title}</h3>
                    <span className="job-type">{job.type}</span>
                  </div>
                  <div className="job-meta">
                    <span className="job-department">📋 {job.department}</span>
                    <span className="job-location">📍 {job.location}</span>
                  </div>
                  <p className="job-description">{job.description}</p>
                  <button className="apply-btn" onClick={() => alert('Başvuru formu yakında aktif olacak!')}>
                    Başvur
                  </button>
                </div>
              ))}
            </div>
          </section>

          <section className="info-section">
            <h2>Başvuru Süreci</h2>
            <div className="process-steps">
              <div className="process-step">
                <div className="step-number">1</div>
                <h3>Başvuru</h3>
                <p>İlgilendiğiniz pozisyon için başvurunuzu yapın</p>
              </div>
              <div className="process-step">
                <div className="step-number">2</div>
                <h3>Değerlendirme</h3>
                <p>İnsan Kaynakları ekibimiz başvurunuzu inceler</p>
              </div>
              <div className="process-step">
                <div className="step-number">3</div>
                <h3>Görüşme</h3>
                <p>Uygun adaylarla telefon veya yüz yüze görüşme</p>
              </div>
              <div className="process-step">
                <div className="step-number">4</div>
                <h3>Değerlendirme</h3>
                <p>Teknik ve kişisel yetkinlik değerlendirmesi</p>
              </div>
              <div className="process-step">
                <div className="step-number">5</div>
                <h3>Teklif</h3>
                <p>Başarılı adaylara iş teklifi sunulur</p>
              </div>
            </div>
          </section>

          <section className="info-section">
            <h2>İletişim</h2>
            <p>
              Kariyer fırsatları hakkında daha fazla bilgi almak için:<br />
              <strong>E-posta:</strong> kariyer@parcamuhendisi.com<br />
              <strong>Telefon:</strong> 0850 123 45 67
            </p>
          </section>
        </div>
      </div>
    </div>
  );
};

export default CareerPage;
