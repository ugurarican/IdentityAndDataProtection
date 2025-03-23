# IdentityAndDataProtection

Bu proje, ASP.NET Core Identity kullanarak kimlik doğrulama ve yetkilendirme işlemlerini gerçekleştiren bir Web API uygulamasıdır.

## 🚀 Başlangıç

Bu projeyi çalıştırmak için aşağıdaki adımları takip edebilirsiniz.

### 1️⃣ Gerekli Bağımlılıkları Yükleyin

Proje klasörüne giderek aşağıdaki komutu çalıştırın:

```sh
dotnet restore
```

### 2️⃣ Veritabanını Güncelleyin

Aşağıdaki komut ile Entity Framework Core Migrations'ı uygulayın:

```sh
dotnet ef database update
```

> **Not:** `appsettings.json` içinde `DefaultConnection` bağlantı dizesini kendi SQL Server bağlantınıza göre güncelleyin.

### 3️⃣ Projeyi Çalıştırın

Aşağıdaki komutu kullanarak projeyi başlatabilirsiniz:

```sh
dotnet run
```

Proje çalıştırıldığında Swagger UI'ya şu adresten erişebilirsiniz:

```
http://localhost:5000/swagger/index.html
```

## 📌 API Bitiş Noktaları (Endpoints)

### 🔹 Kullanıcı Kaydı (Register)

- **URL:** `POST /api/auth/register`

- **İstek Gövdesi:**

  ```json
  {
    "email": "kullanici@example.com",
    "password": "Sifre123!"
  }
  ```

- **Yanıt (Başarılı):**

  ```json
  "Kullanıcı başarıyla oluşturuldu."
  ```

- **Yanıt (Hata - Geçersiz Şifre Formatı):**

  ```json
  {
    "errors": {
      "Password": [
        "Şifre en az bir harf ve bir rakam içermelidir."
      ]
    }
  }
  ```
## Database Ekran Görüntüsü  
![IdentityandDataProtection](https://github.com/ugurarican/IdentityAndDataProtection/blob/master/IdentityandDataProtection.png)  
## 📦 Kullanılan Teknolojiler

- **ASP.NET Core 7.0**
- **Entity Framework Core**
- **SQL Server**
- **ASP.NET Identity**
- **Swagger (API Dokümantasyonu)**

## 🛠 Yapılandırma

Veritabanı bağlantısını `appsettings.json` dosyasında yapılandırabilirsiniz:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SAMSUNG\\MSSQLSERVER01; database=IdentityAndDataProtectionDb; Trusted_Connection=True;TrustServerCertificate=true"
}
```

## 📜 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır.
