# Auto Parts Store - Yedek Parça E-Ticaret Platformu

Parça Mühendisi benzeri, .NET Core Web API ve React ile geliştirilmiş tam fonksiyonel bir yedek parça satış platformu.

## Özellikler

- Modern ve kullanıcı dostu arayüz
- Gerçek zamanlı ürün arama ve filtreleme
- Sepet yönetimi (LocalStorage ile kalıcı)
- Kategori bazlı ürün listeleme
- Sipariş oluşturma sistemi
- Responsive tasarım (mobil uyumlu)
- Gerçek yedek parça verileri (Shell, Brembo, Bosch, vb.)

## Teknolojiler

### Backend
- .NET 9.0 Web API
- Entity Framework Core
- SQL Server (LocalDB)
- RESTful API Architecture
- CORS desteği

### Frontend
- React 18
- React Router v6
- Axios
- Context API (State Management)
- Modern CSS

## Kurulum

### Gereksinimler

- .NET SDK 9.0 veya üzeri
- Node.js 18.0 veya üzeri
- SQL Server LocalDB (Visual Studio ile birlikte gelir)

### Backend Kurulumu

1. Backend dizinine gidin:
```bash
cd AutoPartsStore/Backend/AutoPartsStore.API
```

2. Veritabanını oluşturun (otomatik olarak seed data ile doldurulur):
```bash
dotnet run
```

Backend API varsayılan olarak `http://localhost:5000` ve `https://localhost:5001` portlarında çalışacaktır.

### Frontend Kurulumu

1. Frontend dizinine gidin:
```bash
cd AutoPartsStore/Frontend/client
```

2. Bağımlılıkları yükleyin:
```bash
npm install
```

3. Development server'ı başlatın:
```bash
npm run dev
```

Frontend uygulaması varsayılan olarak `http://localhost:5173` portunda çalışacaktır.

## API Endpoints

### Categories (Kategoriler)
- `GET /api/categories` - Tüm kategorileri listele
- `GET /api/categories/{id}` - ID'ye göre kategori getir
- `GET /api/categories/slug/{slug}` - Slug'a göre kategori getir

### Products (Ürünler)
- `GET /api/products` - Tüm ürünleri listele (pagination, filter destekli)
- `GET /api/products/{id}` - ID'ye göre ürün getir
- `GET /api/products/featured` - Öne çıkan ürünleri listele
- `GET /api/products/search?query={query}` - Ürün ara

### Orders (Siparişler)
- `POST /api/orders` - Yeni sipariş oluştur
- `GET /api/orders/{id}` - ID'ye göre sipariş getir
- `GET /api/orders/number/{orderNumber}` - Sipariş numarasına göre sipariş getir

## Veritabanı Yapısı

### Categories (Kategoriler)
- Motor Parçaları
- Fren Sistemi
- Filtreler
- Elektrik Aksamı
- Süspansiyon
- Şanzıman
- Karoseri

### Sample Products (Örnek Ürünler)
- Shell Helix Ultra 5W-40
- Castrol Edge 5W-30
- Brembo Fren Diski
- Bosch Fren Balatası
- Mann Yağ Filtresi
- Varta Akü
- ve daha fazlası...

## Kullanım

1. Ana sayfada öne çıkan ürünleri ve kategorileri görüntüleyin
2. Kategorilere tıklayarak kategori bazlı ürünleri listeleyin
3. Ürünleri sepete ekleyin
4. Sepet sayfasından ürün miktarlarını güncelleyin
5. "Sipariş Ver" butonuna tıklayarak ödeme sayfasına gidin
6. İletişim ve teslimat bilgilerinizi girin
7. Siparişi tamamlayın

## Proje Yapısı

```
AutoPartsStore/
├── Backend/
│   └── AutoPartsStore.API/
│       ├── Controllers/
│       │   ├── CategoriesController.cs
│       │   ├── ProductsController.cs
│       │   └── OrdersController.cs
│       ├── Data/
│       │   └── AutoPartsDbContext.cs
│       ├── Models/
│       │   ├── Category.cs
│       │   ├── Product.cs
│       │   └── Order.cs
│       └── Program.cs
└── Frontend/
    └── client/
        ├── src/
        │   ├── components/
        │   │   ├── Header.jsx
        │   │   ├── Footer.jsx
        │   │   └── ProductCard.jsx
        │   ├── pages/
        │   │   ├── HomePage.jsx
        │   │   ├── CategoryPage.jsx
        │   │   ├── CartPage.jsx
        │   │   └── CheckoutPage.jsx
        │   ├── context/
        │   │   └── CartContext.jsx
        │   ├── services/
        │   │   └── api.js
        │   ├── App.jsx
        │   └── main.jsx
        └── package.json
```

## Özelleştirme

### Backend API Portunu Değiştirme

`AutoPartsStore.API/Properties/launchSettings.json` dosyasını düzenleyin.

### Frontend API URL'ini Değiştirme

`client/src/services/api.js` dosyasındaki `API_BASE_URL` değişkenini güncelleyin:

```javascript
const API_BASE_URL = 'http://localhost:5000/api';
```

### Database Connection String

`AutoPartsStore.API/appsettings.json` dosyasındaki connection string'i düzenleyin:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AutoPartsStoreDb;Trusted_Connection=true;MultipleActiveResultSets=true"
}
```

## Güvenlik Notları

Bu proje eğitim amaçlıdır. Production ortamında kullanmadan önce:

- Authentication/Authorization ekleyin
- Input validation güçlendirin
- Rate limiting ekleyin
- HTTPS zorunlu hale getirin
- Sensitive data'yı environment variables'a taşıyın
- SQL injection koruması ekleyin (EF Core zaten korumalıdır)

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır.

## İletişim

Sorularınız için: info@parcamuhendisi.com

## Geliştirme

Katkıda bulunmak için:

1. Fork edin
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Commit edin (`git commit -m 'Add some amazing feature'`)
4. Push edin (`git push origin feature/amazing-feature`)
5. Pull Request açın

## Bilinen Sorunlar

- Ürün görselleri placeholder kullanıyor (gerçek görseller eklenebilir)
- Ödeme entegrasyonu yok (eklenebilir)
- Admin paneli yok (geliştirilebilir)

## Gelecek Geliştirmeler

- [ ] Ürün görsel yükleme sistemi
- [ ] Kullanıcı authentication
- [ ] Admin paneli
- [ ] Ödeme gateway entegrasyonu
- [ ] Email bildirimleri
- [ ] Ürün yorum ve değerlendirme sistemi
- [ ] Favoriler listesi
- [ ] Sipariş takip sistemi
