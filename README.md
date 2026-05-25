# Obyektga Yoʻnaltirilgan Dasturlash (OOP) — Polimorfizm Vazifalari

Ushbu loyiha C# dasturlash tilida OOPning eng muhim ustunlaridan biri boʻlgan **Polimorfizm (Polymorphism)** mavzusiga bagʻishlangan. Loyiha doirasida 5 ta mustaqil tizim yaratilgan boʻlib, ularning har biri alohida `.cs` fayllarda arxitektura qilingan.

---

##  Qoʻyilgan Talablar
1. Barcha ota (Parent) klasslarda `virtual` metodlardan foydalanilgan.
2. Barcha voris (Child) klasslarda `override` kalit soʻzi orqali metodlar qayta yozilgan.
3. Obyektlar **Parent reference** orqali yaratilgan (masalan: `Shape s1 = new Circle();`).
4. Kodlarning barcha qismlari oʻzbek tilida konsolga maʼlumot chiqaradi.

---

##  Loyiha Strukturasi (Vazifalar)

### 1. Shape System (Shakllar Tizimi)
* **Parent:** `Shape` (`Draw()` metodi)
* **Child klasslar:** `Circle`, `Rectangle`, `Triangle`
* **Vazifasi:** Geometrik shakllarni polimorfizm orqali konsolga chizish (matn koʻrinishida).

### 2. Notification System (Xabarnoma Tizimi)
* **Parent:** `Notification` (`Send()` metodi)
* **Child klasslar:** `EmailNotification`, `SmsNotification`, `TelegramNotification`
* **Vazifasi:** Har bir xabarnoma turi uchun oʻziga mos platforma xabarini foydalanuvchiga yetkazish.

### 3. Payment System (Toʻlov Tizimi)
* **Parent:** `Payment` (`Pay()` metodi)
* **Child klasslar:** `ClickPayment`, `PaymePayment`, `CashPayment`
* **Vazifasi:** Oʻzbekistondagi ommabop toʻlov tizimlari integratsiyasini polimorfik modelda simulyatsiya qilish.

### 4. Game Characters (Oʻyin Qahramonlari)
* **Parent:** `Character` (`Name` propertysi va `Attack()` metodi)
* **Child klasslar:** `Warrior`, `Archer`, `Mage`
* **Vazifasi:** Konstruktor orqali qahramon nomini ota klassga uzatish va har bir personajning oʻziga xos qurol bilan hujum qilishini taʼminlash.

### 5. Smart Devices (Aqlli Qurilmalar)
* **Parent:** `Device` (`TurnOn()` metodi)
* **Child klasslar:** `Phone`, `Laptop`, `TV`
* **Vazifasi:** Turli elektron qurilmalarning ishga tushish jarayonini boshqarish.

---

##  Loyihani Ishga Tushirish

Loyihani kompyuteringizda ishga tushirish uchun quyidagi buyruqni terminalga yozing:

```bash
dotnet run
