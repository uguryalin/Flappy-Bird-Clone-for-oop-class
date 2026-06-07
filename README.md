# Flappy Bird Clone - OOP Class Assignment / Nesne Yönelimli Programlama Ödevi

[Türkçe](#türkçe) | [English](#english)

---

## Türkçe

### Proje Hakkında
Bu proje, **Nesne Yönelimli Programlama (OOP)** dersi kapsamında geliştirilmiş bir Flappy Bird klonudur. Proje, temel nesne yönelimli programlama kavramlarını (sınıflar, encapsulation/kapsülleme, nesnelerin çalışma zamanı etkileşimleri) C# ve Windows Forms teknolojisi kullanarak sergilemektedir.

### Kullanılan OOP Yaklaşımları
- **Sınıf Tasarımı & Modülerlik:** Kuş (`Bird`), engeller/borular (`Pipe`) ve oyun sabitleri (`GameSettings`) kendi sorumluluklarına göre ayrı sınıflar olarak tasarlanmıştır.
- **Kapsülleme (Encapsulation):** Nesnelerin iç durumları (örn. hız, konum, PictureBox nesneleri) private setter ve metotlar aracılığıyla korunmuş ve dışarıya kontrollü bir şekilde sunulmuştur.
- **Olay Yönetimi (Event-Driven Programming):** Windows Forms üzerindeki klavye basışları ve zamanlayıcı (Timer) olayları ile nesnelerin durumları anlık olarak güncellenmektedir.

### Nasıl Çalıştırılır?
1. Bilgisayarınızda **.NET SDK 8.0** veya daha güncel bir sürümün yüklü olduğundan emin olun.
2. Terminal veya komut istemcisini bu proje klasöründe açın.
3. Aşağıdaki komutu çalıştırın:
   ```bash
   dotnet run
   ```
4. Oyunu başlatmak ve zıplamak için **Boşluk (Space)** tuşunu kullanın.

---

## English

### About the Project
This project is a Flappy Bird clone developed as a project assignment for the **Object-Oriented Programming (OOP)** course. It demonstrates foundational OOP concepts (class design, encapsulation, and runtime object interaction) using C# and Windows Forms.

### OOP Principles Applied
- **Class Design & Modularity:** Key game components like the player (`Bird`), obstacles (`Pipe`), and configuration (`GameSettings`) are decoupled into specialized classes.
- **Encapsulation:** Internal states of objects (e.g., velocity, positions, PictureBox components) are shielded using private setters and exposed via public methods.
- **Event-Driven Programming:** Leverages Windows Forms keyboard events and timer ticks to update the game loop and render sprite movement dynamically.

### How to Run
1. Make sure **.NET SDK 8.0** or later is installed on your machine.
2. Open your terminal or command prompt in the project root directory.
3. Run the following command:
   ```bash
   dotnet run
   ```
4. Press **Space** to start the game and jump.