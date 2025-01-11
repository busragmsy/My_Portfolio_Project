# 🌟 MVC Admin Paneli Portföy Sitesi

Bu proje, admin paneli üzerinden portföy yönetimi yapılmasını sağlayan bir web uygulamasıdır. Dinamik veriler SQL Server veritabanında saklanmakta ve ASP.NET MVC ile kullanıcıya sunulmaktadır.

---

## 🚀 Kullanılan Teknolojiler ve Uygulamalar
- 🗄️ **Microsoft SQL Server (MSSQL) Veritabanı**
- 🖥️ **ASP.NET MVC**
- 🛠️ **Entity Framework**
- 🖌️ **Layout Kontrolü**
- 📂 **Db First Yaklaşımı**
- ✏️ **CRUD İşlemleri**
- 🌐 **HTML**
- 🎨 **CSS**
- 🅱️ **Bootstrap**

---

## 📊 Veri Tabloları

Projenin temel veritabanı yapısı aşağıdaki gibidir:

![Veri Tabloları]([path/to/veri-tablolari.png](https://github.com/busragmsy/My_Portfolio_Project/issues/1#issue-2781868122))

---

## 🖼️ Portfolyo Sayfamdan Görseller

Proje portföy sayfasından alınan bazı ekran görüntüleri:

> ![Anasayfa](https://private-user-images.githubusercontent.com/151780255/402265608-9644d6f2-8ed9-4b5d-a662-8240560cc9dd.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzY2MDI1NjMsIm5iZiI6MTczNjYwMjI2MywicGF0aCI6Ii8xNTE3ODAyNTUvNDAyMjY1NjA4LTk2NDRkNmYyLThlZDktNGI1ZC1hNjYyLTgyNDA1NjBjYzlkZC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMTExJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDExMVQxMzMxMDNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT0zZmE3YTg4Mjc0YzU2ZTJiMzY0MGEzZTcyNTBhYzVjMDgyN2NiZTliYTU2NmFmZjk3OGQ1YjVlZDViN2QxYzMyJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.ZN4F2_xR6ruCLcuRzWAURcIKhbFItCQTQi2EV9jo_Z4) ![Hakkımda](https://private-user-images.githubusercontent.com/151780255/402265618-09b29008-1936-42e4-89e0-4937332ad6e3.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzY2MDI1NjMsIm5iZiI6MTczNjYwMjI2MywicGF0aCI6Ii8xNTE3ODAyNTUvNDAyMjY1NjE4LTA5YjI5MDA4LTE5MzYtNDJlNC04OWUwLTQ5MzczMzJhZDZlMy5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMTExJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDExMVQxMzMxMDNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT03YmJlZTkyNmUzYzllMjc1MTEzY2E0ODMxNjU2YmM0OGM2Zjk4NTgyYmVhZWZiYjYwZDVhNzkzZjJkMmJkY2EzJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.OS0_RNQ8_Km7q4-CZytZQmTw9Wz_CWavylmredHGVTc) ![Hizmetlerim](https://private-user-images.githubusercontent.com/151780255/402265621-2bcd4ba2-126e-4c50-9641-3fa46844f73a.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzY2MDI1NjMsIm5iZiI6MTczNjYwMjI2MywicGF0aCI6Ii8xNTE3ODAyNTUvNDAyMjY1NjIxLTJiY2Q0YmEyLTEyNmUtNGM1MC05NjQxLTNmYTQ2ODQ0ZjczYS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMTExJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDExMVQxMzMxMDNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1jNGMzY2MyZmYxNzlkNzEwZjQ3MjMwYmNjNGE4MDg5MGFmYjE1MzA3ZGRmZGQzMTM5ZjY2NzA2OTRmNzYwYzQ0JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.ILapQmcVPTBGr4ibonMnSdl3IOpBqit2eVYfEnmQuRI) ![İletişim](https://private-user-images.githubusercontent.com/151780255/402265623-0545807d-c420-4de2-a308-0f555f341104.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzY2MDI1NjMsIm5iZiI6MTczNjYwMjI2MywicGF0aCI6Ii8xNTE3ODAyNTUvNDAyMjY1NjIzLTA1NDU4MDdkLWM0MjAtNGRlMi1hMzA4LTBmNTU1ZjM0MTEwNC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMTExJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDExMVQxMzMxMDNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1jMzhhNTk5ZGZiY2ZmNDZlZWRhMThiZjZmYTFiMTY1MDJlZmM1ZDEyODIxODgwOGM1NjZkMTRmMWQwNGNjNTRkJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.zbjabwiqIhpbhhiWHdBPz-72NaFcmCRGrFi1fTtz5NU) ![Projelerim](https://private-user-images.githubusercontent.com/151780255/402265627-4dbe6c72-56af-4c48-a72b-cb12fa0f0cd7.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzY2MDI1NjMsIm5iZiI6MTczNjYwMjI2MywicGF0aCI6Ii8xNTE3ODAyNTUvNDAyMjY1NjI3LTRkYmU2YzcyLTU2YWYtNGM0OC1hNzJiLWNiMTJmYTBmMGNkNy5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMTExJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDExMVQxMzMxMDNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT03YTNhNjA2ZDRkNjc0OTczOGJjOGYxNWQ1YzRlMzBkMzVkMzk1NjI2MjU2MzUyMWViNTY5MGM4NDNlMTFiOWRiJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.ZckUfuFTaKp0M9vtcVEAgPlQ9Y8ZFjymMeo-B1n8ttQ) ![Referanslarım](https://private-user-images.githubusercontent.com/151780255/402265630-d466c61d-76c7-465f-acac-379628caa362.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzY2MDI1NjMsIm5iZiI6MTczNjYwMjI2MywicGF0aCI6Ii8xNTE3ODAyNTUvNDAyMjY1NjMwLWQ0NjZjNjFkLTc2YzctNDY1Zi1hY2FjLTM3OTYyOGNhYTM2Mi5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwMTExJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDExMVQxMzMxMDNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1iYWIwOThmNTkxMGNiZTNkMTY4YTUxYmU4NzJmNzYyMjQ4MTVlM2ViNjIyYmU5N2ZjM2Y1ZDAyYzE0Yjk4MDkxJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.8EGxUmtBEH-QSvu3ceQNEIBX4u1Sh2LUP6vwn_BCSyg)


---

## 🔐 Admin Panelim

Admin panelinden alınan bazı ekran görüntüleri:

### 🛡️ Admin Panel Görsel 1
![Admin Panel Görsel 1](path/to/adminpanel-gorsel1.png)

### 🛡️ Admin Panel Görsel 2
![Admin Panel Görsel 2](path/to/adminpanel-gorsel2.png)

### 🛡️ Admin Panel Görsel 3
![Admin Panel Görsel 3](path/to/adminpanel-gorsel3.png)

### 🛡️ Admin Panel Görsel 4
![Admin Panel Görsel 4](path/to/adminpanel-gorsel4.png)
