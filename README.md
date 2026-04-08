# Stock & Order Management System 📦

C# ve Windows Forms kullanılarak geliştirilmiş bu masaüstü uygulaması, temel stok ve sipariş süreçlerini yönetmek amacıyla tasarlanmıştır.
Proje, katmanlı mimari prensiplerini uygulayarak sürdürülebilir ve genişletilebilir bir yapı oluşturmayı hedefler.

Bu çalışma, yazılım geliştirme becerilerimi sergilemek ve özellikle .NET ekosisteminde backend mantığını güçlendirmek amacıyla hazırlanmıştır.


# Projenin Amacı 🚀

Bu projede odaklandığım şey sadece CRUD yapmak değil:

Katmanlı mimariyi doğru şekilde kurgulamak
UI ile iş mantığını net biçimde ayırmak
Gerçek hayatta kullanılabilecek bir mini ERP mantığı kurmak



# Mimari Yapı 🏗️


Proje, N-Tier (Katmanlı Mimari) prensiplerine uygun olarak geliştirilmiştir:

UI (Presentation Layer)
Kullanıcı arayüzü işlemleri (WinForms)
Business Layer
İş kuralları ve veri kontrol süreçleri
Data Access Layer
Veritabanı işlemleri (ADO.NET + Repository Pattern)
Entity / Type Layer
Veri modelleri

🔹 Katmanlar birbirinden bağımsız olacak şekilde tasarlanmıştır.

🔹 Bağımlılıkların azaltılmasına özellikle dikkat edilmiştir.


# Kullanılan Teknolojiler 🛠️

C# (.NET Framework)

Windows Forms (WinForms)

SQL Server

ADO.NET

Repository Pattern


# Uygulama Modülleri 📋

📁 Kategori Yönetimi

🏷️ Marka Yönetimi

📦 Ürün Yönetimi

👤 Kullanıcı Yönetimi

🧾 Sipariş Yönetimi



# Özellikler ⚙️



Tüm modüller için CRUD işlemleri (Create, Read, Update, Delete)

Ayrı form yapıları ile modüler UI tasarımı

Temel veri doğrulama kontrolleri

Katmanlar arası bağımsız yapı

Genişletilebilir mimari yapı



# Veritabanı 🗄️

Proje geliştirme sürecinde Northwind veritabanı referans alınmıştır.

Ancak sistem:

✔ Özel veritabanına kolayca adapte edilebilir

✔ Tablo yapıları yeniden düzenlenebilir

✔ Genişletmeye açıktır

# Not 📌

Bu proje, temel seviyede bir stok & sipariş yönetim sistemi olup,
ilerleyen aşamalarda aşağıdaki geliştirmeler planlanabilir:

Authentication & Authorization (rol bazlı yetkilendirme)
Entity Framework entegrasyonu
API katmanı eklenmesi
Modern UI (WPF / Web)

# Uygulama Görselleri 📸

🧾 Ürün Ekleme Formu

🧾Proje

🔄 Kullanıcı Güncelleme / Silme
