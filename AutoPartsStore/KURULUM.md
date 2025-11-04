# Hızlı Başlangıç Kılavuzu

## İlk Kurulum

### 1. Backend'i Başlatın

Yeni bir terminal/komut satırı penceresi açın ve şu dosyayı çalıştırın:

```bash
start-backend.bat
```

veya manuel olarak:

```bash
cd Backend\AutoPartsStore.API
dotnet run
```

Backend şu adreslerde çalışacaktır:
- API: http://localhost:5167
- Swagger UI: http://localhost:5167/swagger

İlk çalıştırmada veritabanı otomatik olarak oluşturulacak ve örnek verilerle dolacaktır.

### 2. Frontend'i Başlatın

Yeni bir terminal/komut satırı penceresi açın (backend çalışırken) ve şu dosyayı çalıştırın:

```bash
start-frontend.bat
```

veya manuel olarak:

```bash
cd Frontend\client
npm install  # İlk kurulumda gerekli
npm run dev
```

Frontend şu adreste çalışacaktır:
- Web Sitesi: http://localhost:5173

### 3. Tarayıcınızda Açın

http://localhost:5173 adresine giderek uygulamayı kullanmaya başlayın!

## Test Etme

1. Ana sayfada öne çıkan ürünleri görün
2. Kategorilere tıklayın
3. Ürünleri sepete ekleyin
4. Sepet sayfasına gidin
5. Sipariş verin

## Sorun Giderme

### Backend Başlamıyor

- .NET SDK 9.0'ın yüklü olduğundan emin olun: `dotnet --version`
- SQL Server LocalDB'nin yüklü olduğundan emin olun

### Frontend Başlamıyor

- Node.js'in yüklü olduğundan emin olun: `node --version`
- `npm install` komutunu çalıştırdığınızdan emin olun

### API Bağlantı Hatası

- Backend'in çalıştığından emin olun
- Backend'in http://localhost:5167 portunda çalıştığını kontrol edin
- CORS hatası alıyorsanız, backend'i yeniden başlatın

## Swagger ile API Test Etme

http://localhost:5167/swagger adresine giderek tüm API endpoint'lerini test edebilirsiniz.

### Örnek API Çağrıları:

1. **Tüm Kategorileri Listele**
   - GET /api/categories

2. **Öne Çıkan Ürünleri Getir**
   - GET /api/products/featured

3. **Ürün Ara**
   - GET /api/products/search?query=shell

4. **Sipariş Oluştur**
   - POST /api/orders
   - Body:
   ```json
   {
     "customerName": "Ahmet Yılmaz",
     "customerEmail": "ahmet@example.com",
     "customerPhone": "05551234567",
     "shippingAddress": "Test Caddesi No: 123",
     "city": "İstanbul",
     "postalCode": "34000",
     "items": [
       {
         "productId": 1,
         "quantity": 2
       }
     ]
   }
   ```

## Veritabanını Sıfırlama

Veritabanını sıfırlamak isterseniz:

1. Backend'i durdurun
2. `Backend\AutoPartsStore.API` dizinine gidin
3. LocalDB'deki veritabanını silin veya `AutoPartsDbContext.cs` dosyasındaki seed data'yı değiştirin
4. Backend'i yeniden başlatın - veritabanı otomatik olarak yeniden oluşturulacaktır

## Geliştirme

### Hot Reload

Her iki uygulama da hot reload destekliyor:
- Backend: Kod değişikliklerinde otomatik yeniden derlenir
- Frontend: Kod değişikliklerinde tarayıcı otomatik yenilenir

### Yeni Ürün Ekleme

`Backend\AutoPartsStore.API\Data\AutoPartsDbContext.cs` dosyasındaki `SeedData` metodunu düzenleyin.

### Stil Değişiklikleri

`Frontend\client\src\App.css` dosyasını düzenleyin.

## Production Deployment

Production için:

1. Backend için: `dotnet publish -c Release`
2. Frontend için: `npm run build`
3. Ortam değişkenlerini ayarlayın
4. SSL sertifikası ekleyin
5. Database connection string'i güncelleyin

## Destek

Sorularınız için README.md dosyasına bakın veya GitHub Issues kullanın.
