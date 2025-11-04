import './InfoPages.css';

const ReturnsPage = () => {
  return (
    <div className="info-page">
      <div className="container">
        <h1>İade ve Değişim</h1>

        <div className="info-content">
          <section className="info-section">
            <h2>İade ve Değişim Politikası</h2>
            <p>
              Parça Mühendisi olarak, müşteri memnuniyeti bizim için en önemli
              önceliktir. Satın aldığınız ürünlerle ilgili herhangi bir sorun
              yaşamanız durumunda, kolay iade ve değişim sürecimizden
              faydalanabilirsiniz.
            </p>
          </section>

          <section className="info-section">
            <h2>İade Koşulları</h2>
            <ul className="feature-list">
              <li>✓ Ürün teslim tarihinden itibaren 14 gün içinde iade hakkınız vardır</li>
              <li>✓ İade edilecek ürün kullanılmamış ve orijinal ambalajında olmalıdır</li>
              <li>✓ Ürünün faturası ve tüm aksesuarları eksiksiz olmalıdır</li>
              <li>✓ Montajı yapılmış veya kullanılmış ürünler iade kabul edilmez</li>
              <li>✓ Özel sipariş üzerine getirilen ürünler iade kabul edilmez</li>
              <li>✓ Kampanyalı ürünlerde iade koşulları değişiklik gösterebilir</li>
            </ul>
          </section>

          <section className="info-section">
            <h2>İade Süreci</h2>
            <div className="process-steps">
              <div className="process-step">
                <div className="step-number">1</div>
                <h3>İade Talebi</h3>
                <p>Müşteri hizmetlerimizi arayarak veya e-posta göndererek iade talebinizi oluşturun</p>
              </div>
              <div className="process-step">
                <div className="step-number">2</div>
                <h3>Onay</h3>
                <p>İade talebiniz değerlendirilir ve onaylanır</p>
              </div>
              <div className="process-step">
                <div className="step-number">3</div>
                <h3>Kargo</h3>
                <p>Ürünü size gönderdiğimiz kargo koduyla ücretsiz iade edin</p>
              </div>
              <div className="process-step">
                <div className="step-number">4</div>
                <h3>Kontrol</h3>
                <p>Ürün depomuzda kontrol edilir</p>
              </div>
              <div className="process-step">
                <div className="step-number">5</div>
                <h3>İade</h3>
                <p>Ödemeniz 3-5 iş günü içinde hesabınıza iade edilir</p>
              </div>
            </div>
          </section>

          <section className="info-section">
            <h2>Değişim İşlemleri</h2>
            <p>
              Satın aldığınız ürünü değiştirmek istiyorsanız, aynı iade süreci
              geçerlidir. İade talebinizde "değişim" seçeneğini belirtmeniz
              yeterlidir. Değişim yapmak istediğiniz ürün stoklarımızda mevcut
              ise, ürününüz depoya ulaştıktan sonra yeni ürün tarafınıza
              gönderilir.
            </p>
          </section>

          <section className="info-section">
            <h2>Hatalı/Hasarlı Ürün</h2>
            <p>
              Eğer size ulaşan ürün hatalı veya hasarlı ise, lütfen ürünü teslim
              aldığınız anda kargo görevlisinin önünde kontrol ediniz ve tutanak
              tutunuz. Hatalı veya hasarlı ürünler için kargo ücreti tarafımızdan
              karşılanır ve en kısa sürede yeni ürün tarafınıza gönderilir.
            </p>
          </section>

          <section className="info-section">
            <h2>İade Ücretleri</h2>
            <div className="info-box">
              <h3>Kargo Ücretleri</h3>
              <ul>
                <li><strong>Hatalı/Hasarlı Ürün:</strong> Kargo ücreti tarafımızca karşılanır</li>
                <li><strong>Cayma/İade:</strong> İlk kargo ücreti müşteriye aittir, iade kargo ücreti tarafımızca karşılanır</li>
                <li><strong>Değişim:</strong> Değişim kargo ücreti tarafımızca karşılanır</li>
              </ul>
            </div>
          </section>

          <section className="info-section">
            <h2>Para İadesi</h2>
            <p>
              İade edilen ürünlerin bedeli, ödeme şeklinize göre aşağıdaki
              sürelerde tarafınıza iade edilir:
            </p>
            <ul>
              <li><strong>Kredi Kartı:</strong> 3-5 iş günü (Banka işlem süresine bağlı olarak 1-2 ekstre dönemi sürebilir)</li>
              <li><strong>Banka Havalesi/EFT:</strong> 3-5 iş günü</li>
              <li><strong>Kapıda Ödeme:</strong> Belirttiğiniz hesap numarasına 3-5 iş günü içinde havale edilir</li>
            </ul>
          </section>

          <section className="info-section">
            <h2>İletişim</h2>
            <p>
              İade ve değişim işlemleri için müşteri hizmetlerimizle iletişime geçebilirsiniz:<br /><br />
              <strong>Telefon:</strong> 0850 123 45 67<br />
              <strong>E-posta:</strong> iade@parcamuhendisi.com<br />
              <strong>Çalışma Saatleri:</strong> Hafta içi 09:00 - 18:00
            </p>
          </section>

          <section className="info-section">
            <h2>Sıkça Sorulan Sorular</h2>

            <div className="faq-item">
              <h3>İade sürecim ne kadar sürer?</h3>
              <p>
                Ürün depomuzda teslim alındıktan sonra 2-3 iş günü içinde
                kontrolü yapılır ve uygunsa iadesi gerçekleştirilir. Para
                iadeniz 3-5 iş günü içinde hesabınıza yansır.
              </p>
            </div>

            <div className="faq-item">
              <h3>Montajı yapılmış ürünü iade edebilir miyim?</h3>
              <p>
                Hayır, montajı yapılmış veya kullanılmış ürünler iade kabul
                edilmemektedir. Ancak üründe üretim hatası varsa garanti
                kapsamında değerlendirilebilir.
              </p>
            </div>

            <div className="faq-item">
              <h3>Kampanyalı ürünlerde iade var mı?</h3>
              <p>
                Kampanyalı ürünlerde de iade hakkınız bulunmaktadır. Ancak bazı
                özel kampanyalarda iade koşulları farklılık gösterebilir.
                Detaylar için kampanya açıklamasını inceleyiniz.
              </p>
            </div>

            <div className="faq-item">
              <h3>Yanlış ürün gönderdiyseniz ne yapmalıyım?</h3>
              <p>
                Derhal müşteri hizmetlerimizle iletişime geçin. Yanlış gönderilen
                ürünler için tüm kargo masrafları tarafımızca karşılanır ve doğru
                ürün en kısa sürede size ulaştırılır.
              </p>
            </div>
          </section>
        </div>
      </div>
    </div>
  );
};

export default ReturnsPage;
