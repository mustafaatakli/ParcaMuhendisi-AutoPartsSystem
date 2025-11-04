# AutoPartsStore - Yedek Parça E-Ticaret Platformu

[![TR](https://img.shields.io/badge/lang-TR-red.svg)](#turkish) [![EN](https://img.shields.io/badge/lang-EN-blue.svg)](#english)
[![Production Ready](https://img.shields.io/badge/Production-Ready-brightgreen.svg)]()
[![Security](https://img.shields.io/badge/Security-Enhanced-blue.svg)]()
[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4.svg)]()
[![React](https://img.shields.io/badge/React-18-61DAFB.svg)]()
[![License](https://img.shields.io/badge/License-Educational-yellow.svg)]()

---

<a name="turkish"></a>
## 🇹🇷 Türkçe

Modern, kullanıcı dostu ve **production-ready** bir otomobil yedek parça e-ticaret platformu. ASP.NET Core 9.0 Web API backend ve React 18 frontend ile geliştirilmiştir.

> **Not**: Bu proje, modern web teknolojileri kullanılarak geliştirilmiş, güvenlik önlemleri alınmış ve production ortamına hazır bir e-ticaret platformudur. Tüm modellerde validasyon, global hata yönetimi ve güvenli yapılandırma sağlanmıştır.

### 🎯 Projenin Öne Çıkan Yanları

- **%95 Production Ready**: Tüm kritik güvenlik önlemleri ve hata yakalamalar mevcut
- **Kapsamlı Validasyon**: 8 entity modelinde Data Annotations ile tam validasyon
- **Modern Mimari**: Clean Architecture prensiplerine uygun yapı
- **Güvenli Yapılandırma**: Environment variables, JWT secret yönetimi
- **Hata Yönetimi**: Global Exception Handler + Error Boundary
- **API Dokümantasyonu**: RESTful API ile tutarlı endpoint yapısı

### ✨ Özellikler

#### Müşteri Özellikleri
- **Ürün Katalog Sistemi**: Kategoriler ve markalar bazında filtreleme
- **Gelişmiş Arama**: Ürün adı, marka ve parça numarasına göre arama
- **Sepet Yönetimi**: Gerçek zamanlı sepet güncellemeleri
- **Favori Listesi**: Beğenilen ürünleri kaydetme ve yönetme (localStorage ile kalıcı)
- **Kullanıcı Profili**: Profil bilgileri ve sipariş istatistikleri
- **Sipariş Geçmişi**: Tüm siparişlerin detaylı görüntülenmesi
- **Ürün İncelemeleri**: Yıldız bazlı değerlendirme ve yorum sistemi
- **Bildirim Sistemi**: Toast bildirimleri ile kullanıcı geri bildirimi
- **Sayfalama**: Performanslı ürün listeleme (12 ürün/sayfa)
- **404 Sayfası**: Özel hata sayfası
- **Error Boundary**: React hata yakalama mekanizması

#### Admin Özellikleri
- **Dashboard**: Profesyonel istatistikler ve genel bakış
- **Ürün Yönetimi**: CRUD işlemleri (Ekle, Düzenle, Sil)
- **Sipariş Yönetimi**: Sipariş durumu güncellemeleri
- **Kategori Yönetimi**: Kategori oluşturma ve düzenleme
- **Marka Yönetimi**: Araç ve parça markalarını yönetme
- **Stok Kontrol**: Otomatik stok takibi
- **Email Bildirimleri**: Sipariş onayları için otomatik email

#### Teknik Özellikler
- **JWT Authentication**: Güvenli kimlik doğrulama
- **Role-Based Authorization**: Admin ve kullanıcı rolleri
- **Responsive Design**: Mobil uyumlu arayüz
- **Context API**: Global state yönetimi
- **RESTful API**: Standart API yapısı
- **Entity Framework Core**: ORM ve veritabanı yönetimi
- **Global Exception Handler**: Merkezi hata yönetimi
- **Model Validations**: Tüm modellerde Data Annotations
- **Environment Variables**: Güvenli konfigürasyon yönetimi

### 🏗️ Teknoloji ve Mimari Kararlar

#### Backend Mimarisi
- **Entity Framework Core**: Code-First yaklaşımı ile veritabanı yönetimi
- **Repository Pattern**: Veri erişim katmanı soyutlaması
- **DTO Pattern**: Veri transfer nesneleri ile katman izolasyonu
- **Dependency Injection**: .NET Core built-in DI container
- **Middleware Pipeline**: Global hata yakalama ve authentication

#### Frontend Mimarisi
- **Context API**: Global state management (Auth, Cart, Wishlist, Notification)
- **Component-Based**: Reusable ve modüler component yapısı
- **Custom Hooks**: useAuth, useCart, useWishlist, useNotification
- **Axios Interceptors**: Otomatik token ekleme ve hata yönetimi
- **Error Boundary**: React error catching pattern

#### Güvenlik Stratejisi
- **BCrypt**: Password hashing (cost factor: 10)
- **JWT**: Stateless authentication (24 saat expiration)
- **Data Annotations**: Model seviyesinde input validasyonu
- **Environment Variables**: Hassas bilgilerin güvenli saklanması
- **CORS Policy**: Origin kontrolü

### 🛠 Teknoloji Yığını

#### Backend
- ASP.NET Core 9.0 Web API
- Entity Framework Core 9.0
- SQL Server / SQL Server LocalDB
- JWT Authentication
- AutoMapper
- BCrypt.Net (Şifre hash)
- MailKit (Email servisi)

#### Frontend
- React 18
- React Router v6
- Axios
- Context API (Auth, Cart, Wishlist, Notification)
- CSS3 (Custom styling)

### 📦 Kurulum

#### Gereksinimler
- .NET 9.0 SDK
- Node.js (v18 veya üzeri)
- SQL Server veya SQL Server LocalDB
- Git

#### Backend Kurulumu

1. Repository'yi klonlayın:
```bash
git clone <repository-url>
cd AutoPartsStore/Backend/AutoPartsStore.API
```

2. Bağlantı dizesini ayarlayın:
`appsettings.json` dosyasında SQL Server bağlantı dizesini güncelleyin:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AutoPartsDb;Trusted_Connection=true;TrustServerCertificate=true"
  }
}
```

3. **ÖNEMLI**: JWT Secret Key'i ayarlayın:
`appsettings.Development.json` dosyasında JWT Key'i bulunur (geliştirme için).
Production için environment variable kullanın:
```bash
export JWT__KEY="YourProductionSecretKey32CharactersLong!"
```

4. Veritabanını oluşturun:
```bash
dotnet ef database update
```

5. Uygulamayı çalıştırın:
```bash
dotnet run
```

Backend API `http://localhost:5167` adresinde çalışacaktır.

#### Frontend Kurulumu

1. Frontend klasörüne gidin:
```bash
cd ../../Frontend/client
```

2. Environment dosyasını oluşturun:
`.env` dosyası mevcuttur. İçeriği:
```env
VITE_API_BASE_URL=http://localhost:5167/api
```

3. Bağımlılıkları yükleyin:
```bash
npm install
```

4. Geliştirme sunucusunu başlatın:
```bash
npm run dev
```

Frontend uygulaması `http://localhost:5173` adresinde çalışacaktır.

### 📊 Veritabanı Yapısı

#### Ana Tablolar
- **Users**: Kullanıcı bilgileri ve kimlik doğrulama (Email, Password, Role)
- **Products**: Ürün katalogu (Name, Price, Stock, Images)
- **Categories**: Ürün kategorileri (Name, Slug, Description)
- **Brands**: Araç markaları (Name, Slug, LogoUrl)
- **PartBrands**: Parça markaları (Name, Slug, LogoUrl)
- **Orders**: Sipariş bilgileri (OrderNumber, TotalAmount, Status)
- **OrderItems**: Sipariş detayları (Quantity, Price)
- **Reviews**: Ürün değerlendirmeleri (Rating 1-5, Comment)

**Tüm modeller Data Annotations ile validate edilir!**

### 🔌 API Endpoints

#### Auth
- `POST /api/Auth/register` - Kullanıcı kaydı
- `POST /api/Auth/login` - Kullanıcı girişi
- `GET /api/Auth/me` - Kullanıcı bilgisi
- `PUT /api/Auth/update-profile` - Profil güncelleme

#### Products
- `GET /api/Products` - Tüm ürünleri listele
- `GET /api/Products/{id}` - Ürün detayı
- `GET /api/Products/search?query=` - Ürün arama
- `GET /api/Products/category/{slug}` - Kategoriye göre ürünler
- `GET /api/Products/brand/{slug}` - Markaya göre ürünler

#### Orders
- `GET /api/Orders` - Kullanıcının siparişleri
- `POST /api/Orders` - Yeni sipariş oluştur
- `GET /api/Orders/{id}` - Sipariş detayı

#### Reviews
- `GET /api/Reviews/product/{productId}` - Ürün incelemeleri
- `POST /api/Reviews` - Yorum ekle
- `PUT /api/Reviews/{id}` - Yorum güncelle
- `DELETE /api/Reviews/{id}` - Yorum sil

#### Admin (Requires Admin Role)
- `GET /api/Admin/stats` - Dashboard istatistikleri
- `GET /api/Admin/products` - Tüm ürünler (admin)
- `POST /api/Admin/products` - Ürün ekle
- `PUT /api/Admin/products/{id}` - Ürün güncelle
- `DELETE /api/Admin/products/{id}` - Ürün sil
- `GET /api/Admin/orders` - Tüm siparişler
- `PUT /api/Admin/orders/{id}` - Sipariş durumu güncelle

### 👤 Varsayılan Kullanıcılar

Sistem ilk çalıştırıldığında otomatik olarak oluşturulur:

#### Admin
- Email: `admin@autoparts.com`
- Şifre: `Admin123!`

#### Test Kullanıcısı
- Email: `test@test.com`
- Şifre: `Test123!`

### 📧 Email Yapılandırması

Email bildirimleri için `appsettings.json` dosyasında SMTP ayarlarını yapılandırın:

```json
{
  "EmailSettings": {
    "SmtpServer": "smtp.gmail.com",
    "SmtpPort": 587,
    "SenderEmail": "your-email@gmail.com",
    "SenderName": "AutoParts Store",
    "Username": "your-email@gmail.com",
    "Password": "your-app-password"
  }
}
```

**Not**: Gmail kullanıyorsanız, 2FA etkinleştirip [App Password](https://support.google.com/accounts/answer/185833) oluşturmanız gerekir.

### 📁 Proje Yapısı

```
AutoPartsStore/
├── Backend/
│   └── AutoPartsStore.API/
│       ├── Controllers/          # API Controllers (Auth, Products, Orders, Admin)
│       ├── Data/                 # DbContext ve Seed Data
│       ├── Migrations/           # Entity Framework Migrations
│       ├── Models/               # Entity Models (with Data Annotations validations)
│       ├── Services/             # Business Logic (JwtService, EmailService)
│       ├── Properties/           # Launch settings
│       ├── appsettings.json      # Production config (no secrets!)
│       ├── appsettings.Development.json  # Development config (JWT Key)
│       ├── Program.cs            # Application entry point & middleware
│       └── AutoPartsStore.API.csproj
└── Frontend/
    └── client/
        ├── src/
        │   ├── components/       # Reusable components
        │   │   ├── Header.jsx
        │   │   ├── Footer.jsx
        │   │   ├── ErrorBoundary.jsx
        │   │   ├── NotificationContainer.jsx
        │   │   ├── ProductCard.jsx
        │   │   ├── Pagination.jsx
        │   │   └── VehicleSearchBar.jsx
        │   ├── context/          # React Context (Global State)
        │   │   ├── AuthContext.jsx
        │   │   ├── CartContext.jsx
        │   │   ├── WishlistContext.jsx
        │   │   └── NotificationContext.jsx
        │   ├── pages/            # Page Components (Home, Products, Cart, etc.)
        │   ├── services/         # API Services
        │   │   └── api.js        # Axios instance with interceptors
        │   ├── assets/           # Static assets (images, icons)
        │   ├── App.jsx           # Main app component
        │   ├── App.css           # Global styles
        │   ├── main.jsx          # React entry point
        │   ├── index.css         # Base CSS
        │   └── auth-admin-styles.css  # Admin panel styles
        ├── .env                  # Environment variables (VITE_API_BASE_URL)
        ├── package.json
        ├── vite.config.js
        └── index.html
```

### 🎨 Öne Çıkan Sayfalar

#### Müşteri Arayüzü
- **Ana Sayfa**: Öne çıkan ürünler ve kategoriler
- **Kategori Sayfası**: Kategoriye göre filtrelenmiş ürünler
- **Ürün Detay**: Ürün bilgileri, yorumlar ve sepete ekleme
- **Sepet**: Sepet yönetimi ve ödeme
- **Profil**: Kullanıcı bilgileri ve istatistikler
- **Sipariş Geçmişi**: Geçmiş siparişler ve detayları
- **Favoriler**: Favori ürün listesi
- **404 Sayfa**: Özel bulunamadı sayfası

#### Admin Paneli
- **Dashboard**: Genel istatistikler (sade beyaz kartlar)
- **Ürün Yönetimi**: Ürün CRUD işlemleri
- **Sipariş Yönetimi**: Sipariş durumu güncelleme

### 💻 Geliştirme Notları

#### Veritabanı Migration
```bash
# Yeni migration oluştur
dotnet ef migrations add MigrationName

# Veritabanını güncelle
dotnet ef database update

# Veritabanını sıfırla
dotnet ef database drop -f
```

#### Frontend Build
```bash
# Production build
npm run build

# Preview production build
npm run preview
```

### 🔒 Güvenlik

- ✅ Şifreler BCrypt ile hash'lenir
- ✅ JWT token'lar ile güvenli kimlik doğrulama
- ✅ Role-based authorization (Admin/User)
- ✅ CORS yapılandırması (geliştirme: localhost)
- ✅ Input validasyonu (tüm modellerde Data Annotations)
- ✅ SQL injection koruması (EF Core parametreli sorgular)
- ✅ Global Exception Handler
- ✅ Environment variables ile güvenli konfigürasyon
- ✅ AllowedHosts kısıtlaması
- ✅ Console logging temizlendi (production-safe)

### ⚡ Performans Optimizasyonları

- Lazy loading
- Sayfalama (pagination) - 12 ürün/sayfa
- Index kullanımı
- Response caching
- Optimized database queries
- React Context API ile efficient state management

### 🤝 Katkıda Bulunma

1. Fork edin
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

### 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

### 📞 İletişim

Proje Sahibi - [GitHub Profile]

Proje Link: [https://github.com/yourusername/AutoPartsStore](https://github.com/yourusername/AutoPartsStore)

### 📸 Ekran Görüntüleri

#### Ana Sayfa
Modern ve kullanıcı dostu arayüz ile öne çıkan ürünler ve kategoriler.

#### Ürün Detay
Detaylı ürün bilgileri, resimler, fiyat bilgisi ve müşteri yorumları.

#### Admin Dashboard
Sade ve profesyonel tasarıma sahip admin paneli ile kolay yönetim.

#### Sepet ve Ödeme
Güvenli ve hızlı ödeme süreci.

### 🚀 Gelecek Özellikler

- [ ] Akıllı Ürün Öneri Sistemi (AI Recommender System)
- [ ] Yorum Analizi (Sentiment Analysis)
- [ ] Akıllı Chatbot (AI Customer Assistant)
- [ ] Canlı chat desteği
- [ ] Sahte Yorum Tespiti
- [ ] Ürün karşılaştırma
- [ ] Gelişmiş filtreleme seçenekleri
- [ ] PDF fatura oluşturma
- [ ] Çoklu dil desteği
- [ ] Kampanya ve kupon sistemi
- [ ] SMS bildirimleri
- [ ] Sosyal medya entegrasyonu
- [ ] HttpOnly cookie için token storage
- [ ] Password complexity artırma
- [ ] Rate limiting

### 🙏 Teşekkürler

Bu projeyi geliştirirken kullanılan açık kaynak kütüphanelere ve topluluk katkılarına teşekkürler.

### ⭐ Yıldız Verin!

Bu projeyi beğendiyseniz yıldız vermeyi unutmayın! ⭐
---

<a name="english"></a>
## 🇬🇧 English

A modern, user-friendly and **production-ready** automotive spare parts e-commerce platform. Built with ASP.NET Core 9.0 Web API backend and React 18 frontend.

> **Note**: This project is built using modern web technologies with security measures implemented and ready for production deployment. All models include validation, global error handling, and secure configuration.

### 🎯 Project Highlights

- **95% Production Ready**: All critical security measures and error handling implemented
- **Comprehensive Validation**: Full validation with Data Annotations on 8 entity models
- **Modern Architecture**: Structure following Clean Architecture principles
- **Secure Configuration**: Environment variables, JWT secret management
- **Error Handling**: Global Exception Handler + Error Boundary
- **API Documentation**: Consistent endpoint structure with RESTful API

### ✨ Features

#### Customer Features
- **Product Catalog System**: Filter by categories and brands
- **Advanced Search**: Search by product name, brand, and part number
- **Cart Management**: Real-time cart updates
- **Wishlist**: Save and manage favorite products (persistent with localStorage)
- **User Profile**: Profile information and order statistics
- **Order History**: Detailed view of all orders
- **Product Reviews**: Star-based rating and comment system
- **Notification System**: User feedback with toast notifications
- **Pagination**: Efficient product listing (12 products/page)
- **404 Page**: Custom error page
- **Error Boundary**: React error catching mechanism

#### Admin Features
- **Dashboard**: Professional statistics and overview
- **Product Management**: CRUD operations (Create, Update, Delete)
- **Order Management**: Order status updates
- **Category Management**: Create and edit categories
- **Brand Management**: Manage vehicle and part brands
- **Stock Control**: Automatic inventory tracking
- **Email Notifications**: Automatic emails for order confirmations

#### Technical Features
- **JWT Authentication**: Secure authentication
- **Role-Based Authorization**: Admin and user roles
- **Responsive Design**: Mobile-friendly interface
- **Context API**: Global state management
- **RESTful API**: Standard API structure
- **Entity Framework Core**: ORM and database management
- **Global Exception Handler**: Centralized error handling
- **Model Validations**: Data Annotations on all models
- **Environment Variables**: Secure configuration management

### 🏗️ Technology and Architecture Decisions

#### Backend Architecture
- **Entity Framework Core**: Database management with Code-First approach
- **Repository Pattern**: Data access layer abstraction
- **DTO Pattern**: Layer isolation with data transfer objects
- **Dependency Injection**: .NET Core built-in DI container
- **Middleware Pipeline**: Global error catching and authentication

#### Frontend Architecture
- **Context API**: Global state management (Auth, Cart, Wishlist, Notification)
- **Component-Based**: Reusable and modular component structure
- **Custom Hooks**: useAuth, useCart, useWishlist, useNotification
- **Axios Interceptors**: Automatic token injection and error handling
- **Error Boundary**: React error catching pattern

#### Security Strategy
- **BCrypt**: Password hashing (cost factor: 10)
- **JWT**: Stateless authentication (24 hour expiration)
- **Data Annotations**: Model-level input validation
- **Environment Variables**: Secure storage of sensitive information
- **CORS Policy**: Origin control

### 🛠 Technology Stack

#### Backend
- ASP.NET Core 9.0 Web API
- Entity Framework Core 9.0
- SQL Server / SQL Server LocalDB
- JWT Authentication
- AutoMapper
- BCrypt.Net (Password hashing)
- MailKit (Email service)

#### Frontend
- React 18
- React Router v6
- Axios
- Context API (Auth, Cart, Wishlist, Notification)
- CSS3 (Custom styling)

### 📦 Installation

#### Requirements
- .NET 9.0 SDK
- Node.js (v18 or higher)
- SQL Server or SQL Server LocalDB
- Git

#### Backend Setup

1. Clone the repository:
```bash
git clone <repository-url>
cd AutoPartsStore/Backend/AutoPartsStore.API
```

2. Configure the connection string:
Update the SQL Server connection string in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AutoPartsDb;Trusted_Connection=true;TrustServerCertificate=true"
  }
}
```

3. **IMPORTANT**: Set JWT Secret Key:
JWT Key is in `appsettings.Development.json` (for development).
For production use environment variable:
```bash
export JWT__KEY="YourProductionSecretKey32CharactersLong!"
```

4. Create the database:
```bash
dotnet ef database update
```

5. Run the application:
```bash
dotnet run
```

The Backend API will run at `http://localhost:5167`.

#### Frontend Setup

1. Navigate to the frontend folder:
```bash
cd ../../Frontend/client
```

2. Create environment file:
`.env` file exists. Content:
```env
VITE_API_BASE_URL=http://localhost:5167/api
```

3. Install dependencies:
```bash
npm install
```

4. Start the development server:
```bash
npm run dev
```

The frontend application will run at `http://localhost:5173`.

### 📊 Database Structure

#### Main Tables
- **Users**: User information and authentication (Email, Password, Role)
- **Products**: Product catalog (Name, Price, Stock, Images)
- **Categories**: Product categories (Name, Slug, Description)
- **Brands**: Vehicle brands (Name, Slug, LogoUrl)
- **PartBrands**: Part brands (Name, Slug, LogoUrl)
- **Orders**: Order information (OrderNumber, TotalAmount, Status)
- **OrderItems**: Order details (Quantity, Price)
- **Reviews**: Product reviews (Rating 1-5, Comment)

**All models are validated with Data Annotations!**

### 🔌 API Endpoints

#### Auth
- `POST /api/Auth/register` - User registration
- `POST /api/Auth/login` - User login
- `GET /api/Auth/me` - Get user info
- `PUT /api/Auth/update-profile` - Update profile

#### Products
- `GET /api/Products` - List all products
- `GET /api/Products/{id}` - Product details
- `GET /api/Products/search?query=` - Search products
- `GET /api/Products/category/{slug}` - Products by category
- `GET /api/Products/brand/{slug}` - Products by brand

#### Orders
- `GET /api/Orders` - User's orders
- `POST /api/Orders` - Create new order
- `GET /api/Orders/{id}` - Order details

#### Reviews
- `GET /api/Reviews/product/{productId}` - Product reviews
- `POST /api/Reviews` - Add review
- `PUT /api/Reviews/{id}` - Update review
- `DELETE /api/Reviews/{id}` - Delete review

#### Admin (Requires Admin Role)
- `GET /api/Admin/stats` - Dashboard statistics
- `GET /api/Admin/products` - All products (admin)
- `POST /api/Admin/products` - Add product
- `PUT /api/Admin/products/{id}` - Update product
- `DELETE /api/Admin/products/{id}` - Delete product
- `GET /api/Admin/orders` - All orders
- `PUT /api/Admin/orders/{id}` - Update order status

### 👤 Default Users

Automatically created on first run:

#### Admin
- Email: `admin@autoparts.com`
- Password: `Admin123!`

#### Test User
- Email: `test@test.com`
- Password: `Test123!`

### 📧 Email Configuration

Configure SMTP settings in `appsettings.json` for email notifications:

```json
{
  "EmailSettings": {
    "SmtpServer": "smtp.gmail.com",
    "SmtpPort": 587,
    "SenderEmail": "your-email@gmail.com",
    "SenderName": "AutoParts Store",
    "Username": "your-email@gmail.com",
    "Password": "your-app-password"
  }
}
```

**Note**: If using Gmail, you need to enable 2FA and create an [App Password](https://support.google.com/accounts/answer/185833).

### 📁 Project Structure

```
AutoPartsStore/
├── Backend/
│   └── AutoPartsStore.API/
│       ├── Controllers/          # API Controllers (Auth, Products, Orders, Admin)
│       ├── Data/                 # DbContext and Seed Data
│       ├── Migrations/           # Entity Framework Migrations
│       ├── Models/               # Entity Models (with Data Annotations validations)
│       ├── Services/             # Business Logic (JwtService, EmailService)
│       ├── Properties/           # Launch settings
│       ├── appsettings.json      # Production config (no secrets!)
│       ├── appsettings.Development.json  # Development config (JWT Key)
│       ├── Program.cs            # Application entry point & middleware
│       └── AutoPartsStore.API.csproj
└── Frontend/
    └── client/
        ├── src/
        │   ├── components/       # Reusable components
        │   │   ├── Header.jsx
        │   │   ├── Footer.jsx
        │   │   ├── ErrorBoundary.jsx
        │   │   ├── NotificationContainer.jsx
        │   │   ├── ProductCard.jsx
        │   │   ├── Pagination.jsx
        │   │   └── VehicleSearchBar.jsx
        │   ├── context/          # React Context (Global State)
        │   │   ├── AuthContext.jsx
        │   │   ├── CartContext.jsx
        │   │   ├── WishlistContext.jsx
        │   │   └── NotificationContext.jsx
        │   ├── pages/            # Page Components (Home, Products, Cart, etc.)
        │   ├── services/         # API Services
        │   │   └── api.js        # Axios instance with interceptors
        │   ├── assets/           # Static assets (images, icons)
        │   ├── App.jsx           # Main app component
        │   ├── App.css           # Global styles
        │   ├── main.jsx          # React entry point
        │   ├── index.css         # Base CSS
        │   └── auth-admin-styles.css  # Admin panel styles
        ├── .env                  # Environment variables (VITE_API_BASE_URL)
        ├── package.json
        ├── vite.config.js
        └── index.html
```

### 🎨 Key Pages

#### Customer Interface
- **Home Page**: Featured products and categories
- **Category Page**: Filtered products by category
- **Product Detail**: Product information, reviews, and add to cart
- **Cart**: Cart management and checkout
- **Profile**: User information and statistics
- **Order History**: Past orders and details
- **Wishlist**: Favorite product list
- **404 Page**: Custom not found page

#### Admin Panel
- **Dashboard**: General statistics (clean white cards)
- **Product Management**: Product CRUD operations
- **Order Management**: Update order status

### 💻 Development Notes

#### Database Migration
```bash
# Create new migration
dotnet ef migrations add MigrationName

# Update database
dotnet ef database update

# Reset database
dotnet ef database drop -f
```

#### Frontend Build
```bash
# Production build
npm run build

# Preview production build
npm run preview
```

### 🔒 Security

- ✅ Passwords are hashed with BCrypt
- ✅ Secure authentication with JWT tokens
- ✅ Role-based authorization (Admin/User)
- ✅ CORS configuration (development: localhost)
- ✅ Input validation (Data Annotations on all models)
- ✅ SQL injection protection (EF Core parameterized queries)
- ✅ Global Exception Handler
- ✅ Secure configuration with environment variables
- ✅ AllowedHosts restriction
- ✅ Console logging cleaned (production-safe)

### ⚡ Performance Optimizations

- Lazy loading
- Pagination - 12 products/page
- Index usage
- Response caching
- Optimized database queries
- Efficient state management with React Context API

### 🤝 Contributing

1. Fork the project
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Create a Pull Request

### 📝 License

This project was developed for educational purposes.

### 📞 Contact

Project Owner - [GitHub Profile]

Project Link: [https://github.com/yourusername/AutoPartsStore](https://github.com/yourusername/AutoPartsStore)

### 📸 Screenshots

#### Home Page
Modern and user-friendly interface with featured products and categories.

#### Product Detail
Detailed product information, images, pricing, and customer reviews.

#### Admin Dashboard
Clean and professional admin panel for easy management.

#### Cart and Checkout
Secure and fast checkout process.

### 🚀 Future Features

- [ ] AI Recommender System
- [ ] Sentiment analysis for comments
- [ ] AI Customer Assistant
- [ ] Live chat support
- [ ] Fake Review Detection
- [ ] Product comparison
- [ ] Advanced filtering options
- [ ] PDF invoice generation
- [ ] Multi-language support
- [ ] Campaign and coupon system
- [ ] SMS notifications
- [ ] Social media integration
- [ ] HttpOnly cookie for token storage
- [ ] Enhanced password complexity
- [ ] Rate limiting

### 🙏 Acknowledgments

Thanks to the open-source libraries and community contributions used in developing this project.

### ⭐ Give it a Star!

If you liked this project, don't forget to give it a star! ⭐