import './InfoPages.css';

const AboutPage = () => {
  return (
    <div className="info-page">
      <div className="container">
        <h1>Hakkımızda</h1>

        <div className="info-content">
          <section className="info-section">
            <h2>Parça Mühendisi - Otomotiv Yedek Parça Uzmanı</h2>
            <p>
              Parça Mühendisi olarak, 2010 yılından bu yana otomotiv sektöründe
              kaliteli ve güvenilir yedek parça tedariki konusunda müşterilerimize
              hizmet vermekteyiz. Türkiye'nin dört bir yanına ulaşan geniş ürün
              yelpazemiz ve uzman ekibimizle, aracınız için ihtiyaç duyduğunuz
              her türlü yedek parçayı en uygun fiyatlarla sunuyoruz.
            </p>
          </section>

          <section className="info-section">
            <h2>Vizyonumuz</h2>
            <p>
              Türkiye'nin en güvenilir ve tercih edilen otomotiv yedek parça
              tedarikçisi olmak, müşterilerimize en kaliteli ürünleri en hızlı
              şekilde ulaştırmak vizyonumuzun temelini oluşturmaktadır.
            </p>
          </section>

          <section className="info-section">
            <h2>Misyonumuz</h2>
            <p>
              Müşteri memnuniyetini ön planda tutarak, orijinal ve kaliteli
              yedek parçaları uygun fiyatlarla sunmak, hızlı ve güvenilir
              teslimat ile müşterilerimizin ihtiyaçlarını en iyi şekilde
              karşılamaktır.
            </p>
          </section>

          <section className="info-section">
            <h2>Neden Biz?</h2>
            <ul className="feature-list">
              <li>✓ 15 yıllık sektör tecrübesi</li>
              <li>✓ 10.000+ orijinal ve muadil yedek parça çeşidi</li>
              <li>✓ Türkiye geneline hızlı kargo</li>
              <li>✓ Uzman müşteri hizmetleri ekibi</li>
              <li>✓ Güvenli ödeme seçenekleri</li>
              <li>✓ Kolay iade ve değişim</li>
              <li>✓ Uygun fiyat garantisi</li>
            </ul>
          </section>

          <section className="info-section">
            <h2>Ürün Kalitemiz</h2>
            <p>
              Tüm ürünlerimiz, uluslararası kalite standartlarına uygun olarak
              seçilmekte ve test edilmektedir. Orijinal parça üreticileri ve
              güvenilir tedarikçilerle çalışarak, müşterilerimize en kaliteli
              ürünleri sunmayı garanti ediyoruz.
            </p>
          </section>
        </div>
      </div>
    </div>
  );
};

export default AboutPage;
