using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoPartsStore.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ReviewCount = table.Column<int>(type: "int", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: true),
                    BadgeText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    PartBrandId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_PartBrands_PartBrandId",
                        column: x => x.PartBrandId,
                        principalTable: "PartBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "LogoUrl", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, null, "Mercedes-Benz", "mercedes-benz" },
                    { 2, null, "BMW", "bmw" },
                    { 3, null, "Audi", "audi" },
                    { 4, null, "Volkswagen", "volkswagen" },
                    { 5, null, "Ford", "ford" },
                    { 6, null, "Renault", "renault" },
                    { 7, null, "Fiat", "fiat" },
                    { 8, null, "Peugeot", "peugeot" },
                    { 9, null, "Citroen", "citroen" },
                    { 10, null, "Opel", "opel" },
                    { 11, null, "Toyota", "toyota" },
                    { 12, null, "Honda", "honda" },
                    { 13, null, "Hyundai", "hyundai" },
                    { 14, null, "Kia", "kia" },
                    { 15, null, "Nissan", "nissan" },
                    { 16, null, "Mazda", "mazda" },
                    { 17, null, "Chevrolet", "chevrolet" },
                    { 18, null, "Dacia", "dacia" },
                    { 19, null, "Skoda", "skoda" },
                    { 20, null, "Seat", "seat" },
                    { 21, null, "Volvo", "volvo" },
                    { 22, null, "Land Rover", "land-rover" },
                    { 23, null, "Jeep", "jeep" },
                    { 24, null, "Mitsubishi", "mitsubishi" },
                    { 25, null, "Suzuki", "suzuki" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "ParentCategoryId", "Slug" },
                values: new object[,]
                {
                    { 1, "Motor yağları ve diğer tüm motor parçaları", "/images/categories/motor.jpg", "Motor Parçaları", null, "motor-parcalari" },
                    { 2, "Fren diskleri, balatalar ve hidrolik parçalar", "/images/categories/fren.jpg", "Fren Sistemi", null, "fren-sistemi" },
                    { 3, "Yağ, hava, polen ve yakıt filtreleri", "/images/categories/filtre.jpg", "Filtreler", null, "filtreler" },
                    { 4, "Akü, alternatör, marş motoru", "/images/categories/elektrik.jpg", "Elektrik Aksamı", null, "elektrik-aksami" },
                    { 5, "Amortisörler, salıncaklar ve rotlar", "/images/categories/suspansiyon.jpg", "Süspansiyon", null, "suspansiyon" },
                    { 6, "Şanzıman yağları ve parçaları", "/images/categories/sanziman.jpg", "Şanzıman", null, "sanziman" },
                    { 7, "Kaput, çamurluk ve tampon parçaları", "/images/categories/karoseri.jpg", "Karoseri", null, "karoseri" }
                });

            migrationBuilder.InsertData(
                table: "PartBrands",
                columns: new[] { "Id", "LogoUrl", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, null, "Bosch", "bosch" },
                    { 2, null, "Mann-Filter", "mann-filter" },
                    { 3, null, "Brembo", "brembo" },
                    { 4, null, "Shell", "shell" },
                    { 5, null, "Castrol", "castrol" },
                    { 6, null, "Mobil", "mobil" },
                    { 7, null, "Varta", "varta" },
                    { 8, null, "Sachs", "sachs" },
                    { 9, null, "Total", "total" },
                    { 10, null, "Petrol Ofisi", "petrol-ofisi" },
                    { 11, null, "ATE", "ate" },
                    { 12, null, "TRW", "trw" },
                    { 13, null, "Mahle", "mahle" },
                    { 14, null, "Knecht", "knecht" },
                    { 15, null, "Valeo", "valeo" },
                    { 16, null, "Monroe", "monroe" },
                    { 17, null, "Lemförder", "lemforder" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalImages", "BadgeText", "BrandId", "CategoryId", "CreatedAt", "Description", "DiscountPercentage", "ImageUrl", "IsFeatured", "IsNew", "Name", "OldPrice", "PartBrandId", "PartNumber", "Price", "Rating", "ReviewCount", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "[]", "Orijinal Kalite", 1, 3, new DateTime(2025, 11, 3, 13, 44, 42, 737, DateTimeKind.Utc).AddTicks(3239), "Orijinal kalite yağ filtresi (Bosch üretimi). Mercedes-Benz W205, W213 modelleri için uyumlu. OM651 motor. Premium filtrasyon teknolojisi. 25.000 km kullanım ömrü.", 22, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", true, false, "Motor Yağ Filtresi - Bosch", 315.00m, 1, "MB-A6511800009", 245.00m, 4.9000000000000004, 187, 45, new DateTime(2025, 11, 3, 13, 44, 42, 737, DateTimeKind.Utc).AddTicks(3244) },
                    { 2, "[]", "Orijinal Kalite", 2, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1670), "Ön fren disk seti (Brembo üretimi). F30, F31, F34 modelleri için. 348mm çap, havalandırmalı tasarım. ECE R90 onaylı. Yüksek performans frenleme.", 16, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", true, false, "BMW 3 Serisi Fren Disk Takımı", 2200.00m, 3, "BMW-34116792217", 1850.00m, 4.9000000000000004, 164, 22, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1674) },
                    { 3, "[]", null, 3, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1685), "Düşük küllenme özellikleri ile dizel partikül filtresi koruması. Mercedes-Benz, BMW, VW onaylı. Uzun motor ömrü sağlar.", null, "https://images.unsplash.com/photo-1619642751034-765dfdf7c58e?w=500&q=80", false, true, "Mobil 1 ESP 0W-30", null, 6, "MB-0W30-4L", 599.99m, 4.9000000000000004, 142, 28, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1685) },
                    { 4, "[]", "%15 İndirim", 4, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1689), "Ön fren diski, havalandırmalı tasarım. Volkswagen Golf 7, Audi A3, Skoda Octavia uyumlu. 312mm çap, yüksek performans.", 15, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", true, false, "Brembo Fren Diski", 850.00m, 3, "BR-09.9772.11", 722.50m, 4.5999999999999996, 85, 18, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1690) },
                    { 5, "[]", null, 5, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1695), "Yüksek performanslı ön fren balata takımı. Az toz üreten formül. ECE R90 onaylı. Sessiz ve etkili frenleme.", null, "https://images.unsplash.com/photo-1619642751034-765dfdf7c58e?w=500&q=80", false, false, "Bosch Fren Balatası", null, 1, "BO-0986494396", 385.00m, 4.7000000000000002, 103, 42, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1696) },
                    { 6, "[]", null, 6, 3, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1700), "Orijinal kalite yağ filtresi. W 712/75 model. Premium multi-grade filtrasyon teknolojisi. 25.000 km kullanım ömrü.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Mann Yağ Filtresi", null, 2, "MN-W712/75", 89.99m, 4.7999999999999998, 215, 120, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1700) },
                    { 7, "[]", null, 5, 3, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1704), "Motor hava filtresi. Yüksek filtrasyon performansı. %99.9 toz tutma kapasitesi. Yakıt tasarrufu sağlar.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Bosch Hava Filtresi", null, 1, "BO-1457433529", 125.00m, 4.5999999999999996, 92, 85, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1705) },
                    { 8, "[]", null, 6, 3, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1709), "Aktif karbonlu kabin hava filtresi. Alerjenleri %99 filtreler. Koku ve bakteri önleyici. Sağlıklı kabin havası.", null, "https://images.unsplash.com/photo-1619642751034-765dfdf7c58e?w=500&q=80", false, true, "Mann Polen Filtresi", null, 2, "MN-CUK2545", 165.00m, 4.7000000000000002, 78, 67, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1709) },
                    { 9, "[]", "Çok Satan", 7, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1713), "60AH 540A Blue Dynamic akü. 3 yıl garanti. Start-Stop teknolojisi. Uzun ömürlü ve güvenilir.", 10, "https://images.unsplash.com/photo-1593941707882-a5bba14938c7?w=500&q=80", true, false, "Varta 60AH Akü", 1450.00m, 7, "VR-D59", 1299.99m, 4.7999999999999998, 246, 22, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1714) },
                    { 10, "[]", null, 5, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1756), "77AH 780A Silver Plus akü. Üstün performans. Soğuk havada güçlü çalıştırma. 4 yıl garanti.", null, "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80", false, false, "Bosch S5 77AH Akü", null, 1, "BO-S5008", 1849.99m, 4.9000000000000004, 187, 15, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1757) },
                    { 11, "[]", null, 8, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1761), "Ön amortisör. OE kalitesinde üretim. Gaz basınçlı teknoloji. Konfor ve güvenlik için tasarlandı.", null, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "Sachs Amortisör", null, 8, "SA-311867", 875.00m, 4.7000000000000002, 64, 12, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1761) },
                    { 12, "[]", "%25 İndirim", 5, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1765), "Arka fren balata seti, 4 adet. Seramik formül. Düşük gürültü, uzun ömür. ECE R90 onaylı.", 25, "https://images.unsplash.com/photo-1619642751034-765dfdf7c58e?w=500&q=80", true, false, "Bosch Fren Balatası Takımı", 450.00m, 1, "BO-0986494662", 337.50m, 4.5, 167, 38, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1766) },
                    { 13, "[]", null, 9, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1771), "Tam sentetik motor yağı. Aşırı koşullarda üstün koruma. VW 502.00/505.00, MB 229.5 onaylı.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Total Quartz 9000 5W-40", null, 9, "TT-9000-5W40", 479.99m, 4.7000000000000002, 89, 44, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1771) },
                    { 14, "[]", "Yerli Üretim", 10, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1775), "Yerli üretim tam sentetik motor yağı. API SN Plus, ACEA C3. Yakıt ekonomisi sağlar.", 16, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", true, false, "Petrol Ofisi Maxima 5W-30", 499.99m, 10, "PO-MAX-5W30", 419.99m, 4.5999999999999996, 134, 62, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1776) },
                    { 15, "[]", null, 4, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1780), "DOT 4 fren hidrolik sıvısı. 1 litre. Yüksek kaynama noktası. ABS/ESP uyumlu.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "ATE Fren Hidroliği", null, 11, "AT-706202", 125.00m, 4.7999999999999998, 156, 95, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1781) },
                    { 16, "[]", "%17 İndirim", 5, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1785), "Arka fren disk seti, 2 adet. Ford Focus, Mondeo uyumlu. 278mm çap.", 17, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "TRW Fren Diski Seti", 780.00m, 12, "TRW-DF6363S", 645.00m, 4.5999999999999996, 71, 24, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1786) },
                    { 17, "[]", null, 6, 3, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1811), "Dizel yakıt filtresi. Su tutucu özellikli. Enjektör koruması sağlar.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Mahle Yakıt Filtresi", null, 13, "MH-KL440", 145.00m, 4.7000000000000002, 98, 78, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1812) },
                    { 18, "[]", "Set İndirimi", 4, 3, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1816), "Komple filtre bakım seti: yağ, hava, polen filtresi. Volkswagen, Audi, Seat, Skoda için.", 24, "https://images.unsplash.com/photo-1619642751034-765dfdf7c58e?w=500&q=80", true, true, "Knecht Filtre Seti", 425.00m, 14, "KN-FSK001", 325.00m, 4.9000000000000004, 187, 31, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1817) },
                    { 19, "[]", null, 2, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1821), "120A alternatör. BMW 3 Serisi, 5 Serisi uyumlu. Yüksek verimlilik.", null, "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80", false, false, "Valeo Alternatör", null, 15, "VL-437576", 2499.99m, 4.7000000000000002, 42, 8, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1822) },
                    { 20, "[]", null, 1, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1826), "Güçlü başlatma performansı. Mercedes C-Class, E-Class uyumlu. 2 yıl garanti.", null, "https://images.unsplash.com/photo-1593941707882-a5bba14938c7?w=500&q=80", false, false, "Bosch Marş Motoru", null, 1, "BO-0001109400", 1899.99m, 4.7999999999999998, 65, 11, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1826) },
                    { 21, "[]", "Set", 11, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1830), "4 adet platin buji. Uzun ömürlü, yakıt ekonomisi. 60.000 km kullanım garantisi.", 19, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Bosch Buji Seti", 350.00m, 1, "BO-FR7DPP332S", 285.00m, 4.7999999999999998, 203, 55, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1831) },
                    { 22, "[]", "Komple Set", 11, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1836), "4 adet amortisör seti. Ön ve arka komple. Toyota Corolla uyumlu. Reflex teknolojisi.", 16, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", true, false, "Monroe Amortisör Seti", 3400.00m, 16, "MN-5803SET", 2850.00m, 4.5999999999999996, 38, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1836) },
                    { 23, "[]", null, 10, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1841), "Direksiyon rotil başı. Sağ ve sol uyumlu. Ford, Opel modelleri için.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "TRW Rotil", null, 12, "TRW-JTE1095", 285.00m, 4.5, 52, 28, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1842) },
                    { 24, "[]", null, 4, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1867), "Alt salıncak burç takımı. VW, Audi için. Orijinal ekipman kalitesi.", null, "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80", false, false, "Lemförder Salıncak Burcu", null, 17, "LM-10160", 165.00m, 4.7000000000000002, 76, 47, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1868) },
                    { 25, "[]", null, 17, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1871), "Otomatik şanzıman yağı. 1 litre. GM Dexron VI onaylı. Uzun ömürlü koruma.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Castrol Transmax Dexron VI", null, 5, "CA-DEXVI-1L", 185.00m, 4.7999999999999998, 142, 72, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1872) },
                    { 26, "[]", null, 8, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1876), "Manuel şanzıman yağı. API GL-4. Peugeot, Renault onaylı. 1 litre.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Total Transmission Gear 8 75W-80", null, 9, "TT-TG8-75W80", 145.00m, 4.5999999999999996, 87, 58, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1876) },
                    { 27, "[]", "Komple Set", 7, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1880), "Komple debriyaj takımı: baskı, disk, bilya. Fiat, Opel uyumlu. OE kalitesi.", 15, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", true, false, "Valeo Debriyaj Seti", 1950.00m, 15, "VL-826552", 1650.00m, 4.7000000000000002, 94, 14, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1881) },
                    { 28, "[]", null, 4, 7, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1886), "Ön far camı, sol taraf. VW Golf 7 uyumlu. Orijinal ölçülerde.", null, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "Far Camı Sol", null, 1, "DP-441-1156L", 425.00m, 4.4000000000000004, 31, 16, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1886) },
                    { 29, "[]", null, 5, 7, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1890), "Isıtmalı dış ayna camı, sağ. Ford Focus 3 uyumlu. Kolay montaj.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Dış Ayna Camı Sağ", null, 1, "VW-1859832", 185.00m, 4.5, 45, 33, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1891) },
                    { 30, "[]", "Fırsat", 13, 7, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1894), "Alt ön tampon panjuru/ızgarası. i20 modelleri için. Siyah renk. Orijinal kalite plastik.", 23, "https://images.unsplash.com/photo-1619642751034-765dfdf7c58e?w=500&q=80", false, false, "Hyundai i20 Ön Tampon Panjuru", 385.00m, 1, "HY-865601J000", 295.00m, 4.2999999999999998, 28, 19, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1895) },
                    { 31, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1935), "Yüksek performanslı hava filtresi. BMW, Mercedes uyumlu. Uzun ömürlü.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Mahle Hava Filtresi", null, 14, "MH-LX1780", 195.00m, 4.7000000000000002, 112, 45, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1936) },
                    { 32, "[]", null, 3, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1961), "Aktif karbonlu polen filtresi. Audi, VW uyumlu. Anti-alerjik.", 21, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "Knecht Polen Filtresi", 210.00m, 15, "KN-LA230", 165.00m, 4.5, 89, 38, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1962) },
                    { 33, "[]", null, 11, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1967), "Havalandırmalı fren diski, ön aks. Toyota, Honda uyumlu. Yüksek karbon içerik.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", true, false, "TRW Fren Diski Ön", null, 12, "TRW-DF4823", 850.00m, 4.7999999999999998, 156, 22, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1967) },
                    { 34, "[]", "Kaliteli", 6, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1971), "Komple fren kaliperi, ön sağ. Renault, Dacia uyumlu. Orijinal kalite.", 17, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "ATE Fren Kaliperi Ön Sağ", 1750.00m, 11, "ATE-342019", 1450.00m, 4.5999999999999996, 67, 11, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1972) },
                    { 35, "[]", null, 4, 3, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1977), "60Ah 540A akü. Volkswagen, Seat uyumlu. 2 yıl garanti.", null, "https://images.unsplash.com/photo-1593941707882-a5bba14938c7?w=500&q=80", true, false, "Varta Blue Dynamic 60Ah Akü", null, 7, "VRT-560408054", 2150.00m, 4.7000000000000002, 203, 28, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1977) },
                    { 36, "[]", "Premium", 2, 3, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1981), "75Ah 750A akü. BMW, Mercedes uyumlu. AGM teknoloji.", 11, "https://images.unsplash.com/photo-1593941707882-a5bba14938c7?w=500&q=80", true, false, "Varta Silver Dynamic 75Ah Akü", 3650.00m, 7, "VRT-575301078", 3250.00m, 4.9000000000000004, 187, 15, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1982) },
                    { 37, "[]", null, 4, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1986), "Tam sentetik motor yağı 5W-30. 4 litre. VW 504.00/507.00 onaylı.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", true, false, "Shell Helix Ultra 5W-30", null, 4, "SHL-550040758", 485.00m, 4.7999999999999998, 341, 67, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1987) },
                    { 38, "[]", null, 1, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1991), "Sentetik dizel motor yağı. 5 litre. Mercedes onaylı. DPF uyumlu.", 13, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Mobil 1 ESP Formula 5W-30", 795.00m, 6, "MOB-153767", 695.00m, 4.9000000000000004, 278, 42, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(1991) },
                    { 39, "[]", null, 2, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2016), "Tam sentetik motor yağı 0W-40. 1 litre. BMW Longlife onaylı.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Castrol Edge 0W-40", null, 5, "CST-15669A", 185.00m, 4.7000000000000002, 167, 95, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2017) },
                    { 40, "[]", null, 6, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2021), "Sentetik benzinli motor yağı. 4 litre. Renault onaylı.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Total Quartz 9000 Energy 5W-40", null, 9, "TOT-183199", 395.00m, 4.5999999999999996, 143, 53, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2021) },
                    { 41, "[]", null, 5, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2025), "Yarı sentetik motor yağı. 4 litre. Fiat, Ford uyumlu.", 16, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Petrol Ofisi Maxima 10W-40", 350.00m, 10, "PO-8697406080111", 295.00m, 4.5, 198, 78, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2026) },
                    { 42, "[]", null, 4, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2030), "Gaz yağ amortisör, ön sol. VW, Skoda uyumlu. OE kalitesi.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Monroe Amortisör Ön Sol", null, 16, "MNR-G8223", 875.00m, 4.7000000000000002, 124, 26, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2031) },
                    { 43, "[]", "Takım", 5, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2035), "Gaz yağ amortisör takımı, arka. Ford, Mazda uyumlu. 2'li set.", 15, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", true, false, "Monroe Amortisör Arka Takım", 1950.00m, 16, "MNR-E1130", 1650.00m, 4.7999999999999998, 97, 18, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2035) },
                    { 44, "[]", null, 1, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2040), "Orijinal kalite amortisör. Mercedes, Audi uyumlu. Uzun ömürlü.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Sachs Amortisör Ön Sağ", null, 8, "SCH-313933", 1250.00m, 4.7999999999999998, 156, 21, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2041) },
                    { 45, "[]", null, 2, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2045), "Ön rotbaşı. BMW, Opel uyumlu. Alman kalitesi.", null, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "Lemförder Rotbaşı", null, 17, "LEM-10745", 425.00m, 4.5999999999999996, 82, 34, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2045) },
                    { 46, "[]", null, 4, 5, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2049), "Alt salıncak burcu. Volkswagen, Seat uyumlu. Polyüretan.", 21, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "Lemförder Salıncak Burcu", 235.00m, 17, "LEM-33918", 185.00m, 4.5, 94, 56, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2050) },
                    { 47, "[]", null, 6, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2074), "Debriyaj disk balatası. Renault, Dacia uyumlu. Yüksek sürtünme.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Valeo Debriyaj Balatası", null, 15, "VL-801629", 695.00m, 4.7000000000000002, 118, 29, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2075) },
                    { 48, "[]", null, 3, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2078), "Debriyaj baskı tabağı. Volkswagen, Audi uyumlu. Hidrolik sistem.", 15, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Sachs Debriyaj Baskısı", 1350.00m, 8, "SCH-883089", 1150.00m, 4.7999999999999998, 89, 17, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2079) },
                    { 49, "[]", null, 5, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2084), "4'lü platin buji takımı. Ford, Mazda uyumlu. 60.000 km ömür.", null, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", true, false, "Bosch Buji Takımı", null, 1, "BSH-0242236564", 485.00m, 4.9000000000000004, 267, 43, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2084) },
                    { 50, "[]", null, 2, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2088), "Elektronik ateşleme bobini. BMW, Mercedes uyumlu. Yüksek voltaj.", 15, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "Bosch Ateşleme Bobini", 975.00m, 1, "BSH-0221604103", 825.00m, 4.7000000000000002, 143, 31, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2089) },
                    { 51, "[]", null, 8, 7, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2093), "Komple far ünitesi sağ. Peugeot 308 uyumlu. H7 ampul girişi.", null, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "Valeo Far Komple Sağ", null, 15, "VL-043378", 1850.00m, 4.5999999999999996, 54, 12, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2094) },
                    { 52, "[]", "Xenon", 3, 7, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2098), "D2S Xenon ampul. BMW, Audi uyumlu. 4300K beyaz ışık.", 17, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", true, false, "Bosch Xenon Far Ampulü", 1195.00m, 1, "BSH-1987302904", 995.00m, 4.7999999999999998, 186, 23, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2098) },
                    { 53, "[]", null, 11, 7, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2103), "Arka stop lambası sol. Toyota Corolla uyumlu. LED teknoloji.", null, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "Stop Lambası Komple Sol", null, 1, "TY-8156002640", 645.00m, 4.5, 72, 18, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2104) },
                    { 54, "[]", null, 13, 7, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2127), "Komple ön kaput. Hyundai i20 uyumlu. Boya hazır primer kaplı.", 12, "https://images.unsplash.com/photo-1619642751034-765dfdf7c58e?w=500&q=80", false, false, "Ön Kaput", 3250.00m, 1, "HY-664001J000", 2850.00m, 4.4000000000000004, 28, 7, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2128) },
                    { 55, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2132), "Dizel yakıt filtresi. Mercedes, VW uyumlu. Su tutucu özellik.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, true, "Mann-Filter Yakıt Filtresi", null, 2, "MF-WK820/17", 285.00m, 4.7999999999999998, 214, 51, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2133) },
                    { 56, "[]", null, 3, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2137), "Seramik fren balatası, arka. Audi, VW uyumlu. Az toz bırakır.", 14, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", true, false, "Brembo Fren Balatası Arka", 695.00m, 3, "BRM-P85073", 595.00m, 4.9000000000000004, 289, 36, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2137) },
                    { 57, "[]", null, 6, 2, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2142), "Fren hidrolik hortumu. Renault, Nissan uyumlu. Paslanmaz uçlar.", null, "https://images.unsplash.com/photo-1625047509248-ec889cbff17f?w=500&q=80", false, false, "TRW Fren Hidrolik Hortumu", null, 12, "TRW-PHD1062", 165.00m, 4.5999999999999996, 91, 44, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2143) },
                    { 58, "[]", null, 2, 6, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2146), "Motor termostat. BMW, Opel uyumlu. 87°C açılma sıcaklığı.", 17, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Mahle Termostat", 295.00m, 14, "MH-TX10987D", 245.00m, 4.7000000000000002, 127, 39, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2147) },
                    { 59, "[]", null, 4, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2152), "Sentetik şanzıman yağı. 1 litre. Manuel şanzıman için.", null, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Shell Spirax S5 ATE 75W-90", null, 4, "SHL-550028154", 185.00m, 4.5999999999999996, 148, 62, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2152) },
                    { 60, "[]", null, 12, 4, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2156), "Otomatik şanzıman yağı. 1 litre. Çok araç uyumlu.", 17, "https://images.unsplash.com/photo-1615906655593-ad0386982a0f?w=500&q=80", false, false, "Castrol ATF Dex II Multivehicle", 175.00m, 5, "CST-4008177072130", 145.00m, 4.5, 192, 73, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2157) },
                    { 61, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2161), "4 silindirli motorlar için standart ölçü piston seti. Yüksek dayanıklı alüminyum alaşım. Mercedes, BMW uyumlu.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", true, false, "Mahle Piston Seti STD", null, 14, "MH-PST-5001", 2850.00m, 4.7999999999999998, 45, 12, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2162) },
                    { 62, "[]", null, 2, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2186), "Tamir ölçü piston takımı (+0.50mm). 4 silindirli dizel motorlar için. BMW, Audi uyumlu.", 11, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, true, "Kolbenschmidt Piston Takımı 0.50", 3600.00m, 12, "KS-PST-8450", 3200.00m, 4.9000000000000004, 32, 8, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2187) },
                    { 63, "[]", null, 4, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2191), "Motor devir sensörü. Hassas ölçüm teknolojisi. Volkswagen, Audi, Seat uyumlu.", null, "https://images.unsplash.com/photo-1492144534655-ae79c964c9d7?w=500&q=80", false, false, "Bosch Krank Mili Sensörü", null, 1, "BSH-0261210318", 450.00m, 4.7000000000000002, 89, 35, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2192) },
                    { 64, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2196), "Ön krank kasnağı. Titreşim damperi dahil. Mercedes, BMW dizel motorlar uyumlu.", 12, "https://images.unsplash.com/photo-1492144534655-ae79c964c9d7?w=500&q=80", false, false, "SKF Krank Kasnağı", 2100.00m, 16, "SKF-VKM-35012", 1850.00m, 4.5999999999999996, 56, 15, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2196) },
                    { 65, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2201), "Yüksek performanslı su pompası. Metal gövde, uzun ömürlü rulman. Mercedes, BMW uyumlu.", null, "https://images.unsplash.com/photo-1581092918056-0c4c3acd3789?w=500&q=80", true, false, "Bosch Devirdaim Su Pompası", null, 1, "BSH-1987949454", 875.00m, 4.7999999999999998, 124, 28, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2202) },
                    { 66, "[]", null, 4, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2205), "Su pompası conta seti dahil. Alüminyum gövde. Volkswagen, Audi, Skoda uyumlu.", 18, "https://images.unsplash.com/photo-1581092918056-0c4c3acd3789?w=500&q=80", false, false, "Hepu Devirdaim + Conta", 850.00m, 13, "HPU-P514", 695.00m, 4.5, 98, 32, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2206) },
                    { 67, "[]", null, 2, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2211), "Elektrikli su pompası. Verimli soğutma sistemi. BMW, Audi hibrit modeller uyumlu.", null, "https://images.unsplash.com/photo-1581092918056-0c4c3acd3789?w=500&q=80", false, true, "Graf Devirdaim Elektrikli", null, 15, "GRF-PA1234", 1650.00m, 4.9000000000000004, 67, 9, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2211) },
                    { 68, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2233), "4 silindirli motorlar için emme supap takımı. Isıya dayanıklı özel alaşım. Mercedes, Audi uyumlu.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Mahle Emme Supabı Seti", null, 14, "MH-VS-50001", 1250.00m, 4.7000000000000002, 41, 14, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2234) },
                    { 69, "[]", null, 2, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2237), "Egzoz supap seti 8 adet. Yüksek sıcaklık dayanımlı. BMW, Volkswagen uyumlu.", 12, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "TRW Egzoz Supabı Takımı", 1650.00m, 11, "TRW-EX-8800", 1450.00m, 4.5999999999999996, 38, 11, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2238) },
                    { 70, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2243), "Metal takviyeli silindir kapak contası. 4 silindirli motorlar. Mercedes, BMW uyumlu.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", true, false, "Elring Silindir Kapak Contası", null, 8, "ELR-026.980", 950.00m, 4.7999999999999998, 156, 22, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2243) },
                    { 71, "[]", null, 4, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2247), "Motor üst takım conta seti. Tüm contalar dahil. Volkswagen, Audi, Seat uyumlu.", 14, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Victor Reinz Üst Takım Contas", 1800.00m, 9, "VR-02-37805-01", 1550.00m, 4.7000000000000002, 92, 17, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2248) },
                    { 72, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2252), "Standart ölçü piston segman takımı. 4 silindir. Mercedes, BMW, Audi uyumlu.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, false, "Goetze Piston Segmanı STD", null, 10, "GTZ-08-109800-00", 850.00m, 4.5999999999999996, 73, 19, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2253) },
                    { 73, "[]", null, 4, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2257), "Tamir ölçü segman seti (+0.25mm). Dizel ve benzinli motorlar. Volkswagen uyumlu.", null, "https://images.unsplash.com/photo-1486262715619-67b85e0b08d3?w=500&q=80", false, true, "Mahle Segman Takımı 0.25", null, 14, "MH-028-RS-00114-0N0", 920.00m, 4.7999999999999998, 55, 16, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2257) },
                    { 74, "[]", null, 1, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2261), "Motor termostatı 87 derece. Hızlı açılma özelliği. Mercedes, BMW uyumlu.", null, "https://images.unsplash.com/photo-1581092918056-0c4c3acd3789?w=500&q=80", false, false, "Wahler Termostat 87°C", null, 13, "WAH-4471.87D", 385.00m, 4.5, 112, 45, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2262) },
                    { 75, "[]", null, 4, 1, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2265), "Termostat conta dahil 92°C. Volkswagen, Audi, Skoda, Seat uyumlu.", 15, "https://images.unsplash.com/photo-1581092918056-0c4c3acd3789?w=500&q=80", false, false, "Gates Termostat + Conta", 500.00m, 7, "GTS-TH35492G1", 425.00m, 4.7000000000000002, 145, 38, new DateTime(2025, 11, 3, 13, 44, 42, 738, DateTimeKind.Utc).AddTicks(2266) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PartBrandId",
                table: "Products",
                column: "PartBrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PartBrands");
        }
    }
}
