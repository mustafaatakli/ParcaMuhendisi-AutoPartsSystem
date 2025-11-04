using System.Net;
using System.Net.Mail;
using AutoPartsStore.API.Models;

namespace AutoPartsStore.API.Services
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task SendOrderConfirmationEmail(Order order)
        {
            try
            {
                var subject = $"Sipariş Onayı - {order.OrderNumber}";
                var body = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h2>Parça Mühendisi - Sipariş Onayı</h2>
                        <p>Merhaba {order.CustomerName},</p>
                        <p>Siparişiniz başarıyla alınmıştır.</p>

                        <h3>Sipariş Detayları:</h3>
                        <p><strong>Sipariş No:</strong> {order.OrderNumber}</p>
                        <p><strong>Sipariş Tarihi:</strong> {order.OrderDate:dd.MM.yyyy HH:mm}</p>
                        <p><strong>Toplam Tutar:</strong> {order.TotalAmount:F2} TL</p>

                        <h3>Teslimat Bilgileri:</h3>
                        <p>{order.ShippingAddress}</p>
                        <p>{order.City} / {order.PostalCode}</p>
                        <p><strong>Telefon:</strong> {order.CustomerPhone}</p>

                        <h3>Ürünler:</h3>
                        <ul>
                            {string.Join("", order.OrderItems.Select(item =>
                                $"<li>{item.Product?.Name ?? "Ürün"} - {item.Quantity} adet - {item.Price:F2} TL</li>"
                            ))}
                        </ul>

                        <p>Siparişinizi <a href='http://localhost:5173/siparis-takibi'>buradan</a> takip edebilirsiniz.</p>

                        <p>Teşekkür ederiz!</p>
                        <p><strong>Parça Mühendisi</strong></p>
                    </body>
                    </html>
                ";

                await SendEmail(order.CustomerEmail, subject, body);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to send order confirmation email for order {OrderNumber}", order.OrderNumber);
                // Email gönderimi başarısız olsa da sipariş işlemini etkilemesin
            }
        }

        public async Task SendLowStockAlert(Product product, int threshold = 10)
        {
            try
            {
                var adminEmail = _configuration["Email:AdminEmail"] ?? "admin@parcamuhendisi.com";
                var subject = $"Düşük Stok Uyarısı - {product.Name}";
                var body = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h2>Düşük Stok Uyarısı</h2>
                        <p>Aşağıdaki ürünün stok seviyesi kritik seviyeye düştü:</p>

                        <h3>Ürün Bilgileri:</h3>
                        <p><strong>Ürün Adı:</strong> {product.Name}</p>
                        <p><strong>Parça No:</strong> {product.PartNumber}</p>
                        <p><strong>Mevcut Stok:</strong> {product.Stock} adet</p>
                        <p><strong>Eşik Değer:</strong> {threshold} adet</p>

                        <p>Lütfen stok yenilemesi yapınız.</p>

                        <p><a href='http://localhost:5173/admin'>Admin Paneline Git</a></p>
                    </body>
                    </html>
                ";

                await SendEmail(adminEmail, subject, body);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to send low stock alert for product {ProductId}", product.Id);
            }
        }

        private async Task SendEmail(string toEmail, string subject, string body)
        {
            var smtpHost = _configuration["Email:SmtpHost"] ?? "smtp.gmail.com";
            var smtpPort = int.Parse(_configuration["Email:SmtpPort"] ?? "587");
            var fromEmail = _configuration["Email:FromEmail"] ?? "noreply@parcamuhendisi.com";
            var fromPassword = _configuration["Email:FromPassword"] ?? "";

            // Eğer email ayarları yapılmamışsa console'a log bas
            if (string.IsNullOrEmpty(fromPassword))
            {
                _logger.LogWarning("Email configuration is missing. Email not sent.");
                _logger.LogInformation("Email would be sent to: {ToEmail}", toEmail);
                _logger.LogInformation("Subject: {Subject}", subject);
                return;
            }

            using var smtpClient = new SmtpClient(smtpHost, smtpPort)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fromEmail, fromPassword)
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail, "Parça Mühendisi"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            mailMessage.To.Add(toEmail);

            await smtpClient.SendMailAsync(mailMessage);
            _logger.LogInformation("Email sent successfully to {ToEmail}", toEmail);
        }
    }
}
