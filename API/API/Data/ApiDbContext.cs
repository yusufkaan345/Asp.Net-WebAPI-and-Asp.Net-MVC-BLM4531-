﻿using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApiDbContext :DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options)
        {
        }
        public DbSet<BasketModel> BasketTable { get; set; }
        public DbSet<ProductModel> ProductTable { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BasketModel>().HasData(
              new BasketModel
              {
                  ProductId = 22,
                  ProductName = "Dağ Bisikleti",
                  ProductCategory = "Spor",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/55/550/11212783550514.jpg/format:webp",
                  ProductFeatures = "Vites:24 Vites ,  Bisiklet Tipi:Dağ Bisikleti , Kadro Malzemesi:Alüminyum Ağırlık 14,6 kg ,  Fren Tipi:Hidrolik Disk Fren , Jant:29 inç, Kadro Boyu:18 inç - 46 cm ,Ön Amortisör :Kilitli Amortisör",
                  ProductPrice = 18000,
                  ProductStar = 10
              });
            modelBuilder.Entity<ProductModel>().HasData(
              new ProductModel
              {
                  ProductId = 1,
                  ProductName = "MSI THIN GF63 12UC-666XTR",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/448/550/110000481950429.jpg/format:webp",
                  ProductFeatures = "Intel Core i7 12650H 16GB 512GB SSD RTX3050 Freedos 15.6\" FHD 144Hz ",
                  ProductPrice = 30999,
                  ProductStar = 9
              },
              new ProductModel
              {
                  ProductId = 2,
                  ProductName = "Apple AirPods 2. Nesil Kulaklık",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/430/222-222/110000462400807.jpg/format:webp",
                  ProductFeatures = "Bluetooth Versiyon5.0, Çift Telefon Desteği Yok, Suya & Tere DayanıklıHayırAktif Gürültü Önleme (ANC)Yok, Kullanım TipiKulakiçi ",
                  ProductPrice = 3199,
                  ProductStar = 9
              },
              new ProductModel
              {
                  ProductId = 3,
                  ProductName = "Samsung Galaxy Tab S7 FE ",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/127/550/110000077439199.jpg/format:webp",
                  ProductFeatures = "İşletim Sistemi Tabanı Android, Ekran Modeli TFT,Ram Kapasitesi 4 GB,Ekran Boyutu 12,4 inç, Max Ekran Çözünürlüğü 2560 x 1600,Mobil BağlantıYok ",
                  ProductPrice = 10719,
                  ProductStar = 9
              },
              new ProductModel
              {
                  ProductId = 4,
                  ProductName = "Asus Vivobook 15 ",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/472/550/110000515070461.jpg/format:webp",
                  ProductFeatures = "Intel Core i3 1215U 8GB 256GB SSD Freedos 15.6",
                  ProductPrice = 11999,
                  ProductStar = 8
              },
              new ProductModel
              {
                  ProductId = 5,
                  ProductName = "Jbl Tune 520BT ",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/406/222-222/110000434230608.jpg/format:webp",
                  ProductFeatures = "Suya & Tere Dayanıklı Hayır ,Aktif Gürültü Önleme (ANC) Yok, Kullanım Tipi Kulaküstü ,Çift Telefon Desteği Var, Bluetooth Versiyon 5.3, ",
                  ProductPrice = 1419,
                  ProductStar = 6
              },
              new ProductModel
              {
                  ProductId = 6,
                  ProductName = "Lenovo Yoga Smart TAB TB-X705F ",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/39/550/10641362518066.jpg/format:webp",
                  ProductFeatures = "İşletim Sistemi Tabanı Android,Dahili Hafıza64 GB,Tablet İşlemci Qualcomm Snapdragon 439, Kamera Çift Kamera ,Mobil Bağlantı Yok ,Wi-Fi Var, Ekran Modeli IPS Ekran, Ram Kapasitesi 4GB , Ekran Boyutu 10,1 inç, Max Ekran Çözünürlüğü 1920 x 1200 ,",
                  ProductPrice = 14999,
                  ProductStar = 7
              },
              new ProductModel
              {
                  ProductId = 7,
                  ProductName = "Laptop Tablet Standı ",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/456/550/110000492217118.jpg/format:webp",
                  ProductFeatures = " Ergonomik tasarım kolay izleme ve yazma, boyun, omuz ve omurga ağrısını yaşamamanız için kullanışlıdır. Dizüstü bilgisayar ve tablet standı 7 kademeli ayarlanabilir yükseklik sağlar, gerçek ihtiyacınıza göre rahat çalışma açısı ve yüksekliğine ayarlayın ",
                  ProductPrice = 330,
                  ProductStar = 9
              },
              new ProductModel
              {
                  ProductId = 8,
                  ProductName = "Monster Abra A7 V13.3.4",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/444/550/110000478561734.jpg/format:webp",
                  ProductFeatures = " Intel Core I7 11800H 32GB 1 TB SSD RTX3050TI Freedos 17.3 ",
                  ProductPrice = 29999,
                  ProductStar = 8
              },
              new ProductModel
              {
                  ProductId = 9,
                  ProductName = "Oyuncu Mouse",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/34/550/10447701934130.jpg/format:webp",
                  ProductFeatures = "Asus TUF GAMING M3 Aura SYNC RGB 7000DPI  ",
                  ProductPrice = 399,
                  ProductStar = 8
              },
              new ProductModel
              {
                  ProductId = 10,
                  ProductName = "Gaming Mouse",
                  ProductCategory = "Teknoloji",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/44/550/10799730393138.jpg/format:webp",
                  ProductFeatures = "Aydınlatma Var , Mouse Formu Sağ, El Mouse Tipi Optik Mouse , Scroll-Tilt Yok,RGB Var, BağlantıKablolu ",
                  ProductPrice = 3512,
                  ProductStar = 10
              },
              new ProductModel
              {
                  ProductId = 11,
                  ProductName = "U.S. Polo Assn. Erkek Antrasit Melanj Sweatshirt ",
                  ProductCategory = "Moda",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/440/550/110000474281671.jpg/format:webp",
                  ProductFeatures = " Cinsiyet: Erkek ,Yaka Stili : Bisiklet Yaka  ,Desen:Düz Renk ,Kol Boyu:Truvakar Kol",
                  ProductPrice = 849,
                  ProductStar = 8
              },
              new ProductModel
              {
                  ProductId = 12,
                  ProductName = "Altınyıldız  Erkek Mont",
                  ProductCategory = "Moda",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/483/550/110000528454412.jpg/format:webp",
                  ProductFeatures = "AC&Co / Altınyıldız Classics Rüzgar Geçirmez Taşınabilir Çantalı Sıcak Tutan Hafif Standart Fit Elyaf Dolgulu Şişme Erkek Mont ",
                  ProductPrice = 1999,
                  ProductStar = 9
              },
              new ProductModel
              {
                  ProductId = 13,
                  ProductName = "Erkek Siyah Kanvas / Chino Pantolo",
                  ProductCategory = "Moda",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/475/550/110000517846540.jpg/format:webp",
                  ProductFeatures = "U.s. Polo Assn. Erkek Siyah Kanvas / Chino Pantolon 50275532-VR046 ",
                  ProductPrice = 750,
                  ProductStar = 10
              },
              new ProductModel
              {
                  ProductId = 14,
                  ProductName = "U.S. Polo Assn. Kadın Lacivert Örme Elbise",
                  ProductCategory = "Moda",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/452/550/110000487051994.jpg/format:webp",
                  ProductFeatures = " Cinsiyet:Kadın Garanti Süresi (Ay) :12",
                  ProductPrice = 1800,
                  ProductStar = 7
              },
              new ProductModel
              {
                  ProductId = 15,
                  ProductName = "Desa Grace Kırmızı Kadın Stiletto Topuklu Ayakkabı",
                  ProductCategory = "Moda",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/477/550/110000519939012.jpg/format:webp",
                  ProductFeatures = " Cinsiyet:Kadın  ,Renk:Kırmızı ,Topuk Boyu:Yüksek ,Topuk Tipi:Stiletto",
                  ProductPrice = 1860,
                  ProductStar = 8
              }
              ,
              new ProductModel
              {
                  ProductId = 16,
                  ProductName = "Incı Wınston 3pr Siyah Erkek Klasik Ayakkabı",
                  ProductCategory = "Moda",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/438/550/110000471317764.jpg/format:webp",
                  ProductFeatures = "Incı Wınston 3pr Siyah Erkek Klasik Ayakkabı 42 Numara ",
                  ProductPrice = 1099,
                  ProductStar = 9
              },
              new ProductModel
              {
                  ProductId = 17,
                  ProductName = "Yılbaşı Biblo Seti",
                  ProductCategory = "Aksesuar",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/482/550/110000527547160.jpg/format:webp",
                  ProductFeatures = "Paradise Work 3'lü Yılbaşı Biblo Seti Noelbaba Kardanadam Penguen ",
                  ProductPrice = 178,
                  ProductStar = 9
              },
              new ProductModel
              {
                  ProductId = 18,
                  ProductName = "Kilim Mobilya Dome Üç Kişilik Kanepe",
                  ProductCategory = "Ev",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/338/550/110000344102191.jpg/format:webp",
                  ProductFeatures = "KİLİM MOBİLYA DOME KANEPE; MİNİMAL BİR ÇİZGİ TANIDIK BİR GÖRÜNÜM; OVAL FORMLAR; Kol kısmında kullanılan oval formlar Dome Kanepe’ye sevimli bir görüntü kazandırırken aynı zamanda yumuşak görünümlü kol yapısıyla kullanım rahatlığı da sağlar.; İ ",
                  ProductPrice = 5600,
                  ProductStar = 10
              },
              new ProductModel
              {
                  ProductId = 19,
                  ProductName = "Serum Extra Yaşlanma Karşıtı ",
                  ProductCategory = "Ciltbakım",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/469/550/110000509693214.jpg/format:webp",
                  ProductFeatures = "Cildin yenilenme hızını artırır, leke ve izlerin daha çabuk iyileşmesini sağlar,Cildin daha sıkı ve pürüzsüz görünmesine yardımcı olur,Cilde nem, parlaklık ve elastikiyet katar,Yaşlanma belirtilerini hafifletir.",
                  ProductPrice = 560,
                  ProductStar = 10
              },
              new ProductModel
              {
                  ProductId = 20,
                  ProductName = " Dağ Bisikleti ",
                  ProductCategory = "Spor",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/55/550/11212783550514.jpg/format:webp",
                  ProductFeatures = "Vites:24 Vites ,  Bisiklet Tipi:Dağ Bisikleti , Kadro Malzemesi:Alüminyum Ağırlık 14,6 kg ,  Fren Tipi:Hidrolik Disk Fren , Jant:29 inç, Kadro Boyu:18 inç - 46 cm ,Ön Amortisör :Kilitli Amortisör",
                  ProductPrice = 18000,
                  ProductStar = 10
              }
              ,
              new ProductModel
              {
                  ProductId = 21,
                  ProductName = " Samsung  Çamaşır Makinesi ",
                  ProductCategory = "Beyaz Eşya",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/76/550/110000017561925.jpg/format:webp",
                  ProductFeatures = "Genişlik (cm):60 , Yükseklik (cm):85 , Derinlik (cm): 55 , Kurutmalı: Hayır,Maksimum Devir Hızı:1200 Yıkama Kapasitesi:9 kg",
                  ProductPrice = 12000,
                  ProductStar = 8
              }
              ,
              new ProductModel
              {
                  ProductId = 23,
                  ProductName = " Bileklik ",
                  ProductCategory = "Aksesuar",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/86/550/110000028825785.jpg/format:webp",
                  ProductFeatures = "Şans Bilekliği, Garanti Süresi: 1 Ay, Renk: Kırmızı, Kullanıcı Cinsiyeti: Unisex",
                  ProductPrice = 50,
                  ProductStar = 8
              }
              ,
              new ProductModel
              {
                  ProductId = 24,
                  ProductName = " Kolye ",
                  ProductCategory = "Aksesuar",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/348/550/110000356146538.jpg/format:webp",
                  ProductFeatures = "Kolye, Garanti Süresi: 1 Ay, Renk: Kırmızı, Kullanıcı Cinsiyeti: Kadın, Kolye Ucu 925 Ayar Gümüş Kaplama üzeri Rose Kaplama",
                  ProductPrice = 200,
                  ProductStar = 9
              }
              ,
              new ProductModel
              {
                  ProductId = 25,
                  ProductName = " Küpe ",
                  ProductCategory = "Aksesuar",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/445/550/110000479147634.jpg/format:webp",
                  ProductFeatures = "Küpe, Garanti Süresi: 3 Ay, Renk: Siyah ve Gümüş, Kullanıcı Cinsiyeti: Kadın, ÜRÜN BOYUTU : HALKA : 8 MM ; FİGÜRLÜ KÜPE : 3 CM ; ZİRKON TAŞ : 4 MM",
                  ProductPrice = 200,
                  ProductStar = 9
              }
              ,
              new ProductModel
              {
                  ProductId = 26,
                  ProductName = " Koltuk ",
                  ProductCategory = "Ev",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/171/550/110000134001181.jpg/format:webp",
                  ProductFeatures = "Üçlü Kanepe, Küçük kırlentlerde dolgu olarak silikon elyaf ve kırpıntı sünger karışımı kullanılmıştır.",
                  ProductPrice = 10000,
                  ProductStar = 7
              }
              ,
              new ProductModel
              {
                  ProductId = 27,
                  ProductName = " Halı ",
                  ProductCategory = "Ev",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/351/550/110000360212172.jpg/format:webp",
                  ProductFeatures = "Renk: Bej, İplik Cinsi (Micro Polyester), Hav Yüksekliği (8 mm), Halı Kalınlığı (12 mm), M2 Ağırlığı (2200 gr/m2), İlme Sayısı (400.000)",
                  ProductPrice = 980,
                  ProductStar = 9
              }
              ,
              new ProductModel
              {
                  ProductId = 28,
                  ProductName = " Perde ",
                  ProductCategory = "Ev",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/37/550/10544399286322.jpg/format:webp",
                  ProductFeatures = "Tül Perde, Taç Ekru Düz Tül 200 x 260 cm, Pilesiz düz dikimdir. Ekstrafordaki iplikler çekilerek istenildiği şekilde pile ayarı yapılabilir.",
                  ProductPrice = 160,
                  ProductStar = 6
              }
              ,
              new ProductModel
              {
                  ProductId = 29,
                  ProductName = " Serum ",
                  ProductCategory = "Ciltbakım",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/352/550/110000360596295.jpg/format:webp",
                  ProductFeatures = "C Vitamini, Parlaklaştırır, Gençleştirir, Lekeleri geçirir, Sabah akşam 1 kere temiz yüze uygulanır.",
                  ProductPrice = 400,
                  ProductStar = 8
              }
              ,
              new ProductModel
              {
                  ProductId = 30,
                  ProductName = " Maske ",
                  ProductCategory = "Ciltbakım",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/519/550/110000575513892.jpg/format:webp",
                  ProductFeatures = "Nemlendirici Bakım Maskesi, Haftada 2 kere temiz yüze ince bir katman halinde uygulanır. Cildi aydınlatır.",
                  ProductPrice = 250,
                  ProductStar = 10
              }
              ,
              new ProductModel
              {
                  ProductId = 31,
                  ProductName = " Maske ",
                  ProductCategory = "Ciltbakım",
                  ProductImgUrl = "https://www.hepsiburada.com/garnier-saf-temiz-peeling-3-u-1-arada-temizleme-maske-150-ml-p-SGGNRGARST3B?magaza=L%27Or%C3%A9al",
                  ProductFeatures = "Üçü bir arada yüz maskesi. Temizleme-Peeling-Maske Aynı anda",
                  ProductPrice = 90,
                  ProductStar = 1
              }
              ,
              new ProductModel
              {
                  ProductId = 32,
                  ProductName = " Ayakkabı ",
                  ProductCategory = "Spor",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/395/600-800/110000419759509.jpg/format:webp",
                  ProductFeatures = "Normal kalıp, Bağcıklı tasarım, Kumaş saya, Cloudfoam orta taban, Kumaş astar.",
                  ProductPrice = 1450,
                  ProductStar = 8
              }
              ,
              new ProductModel
              {
                  ProductId = 33,
                  ProductName = " Ağırlık/Dambıl ",
                  ProductCategory = "Spor",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/433/550/110000466185977.jpg/format:webp",
                  ProductFeatures = "6 KG Dambıl Ağırlık Seti, 2 Adet 3 KG Dambıldan oluşur, Ürünlerimiz üretimden tarafınıza doğrudan sevk edilmektedir.",
                  ProductPrice = 200,
                  ProductStar = 9
              }
              ,
              new ProductModel
              {
                  ProductId = 34,
                  ProductName = " Yürüyüş Bandı ",
                  ProductCategory = "Spor",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/424/550/110000455324829.jpg/format:webp",
                  ProductFeatures = "Motor Gücü: 4,25 hp: Eğim Var, Nabız Ölçme Sistemi: Var, Katlanabilme:Var",
                  ProductPrice = 45000,
                  ProductStar = 10
              }
              ,
              new ProductModel
              {
                  ProductId = 35,
                  ProductName = " Ütü ",
                  ProductCategory = "Beyaz Eşya",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/308/550/110000300858424.jpg/format:webp",
                  ProductFeatures = "Yeni Philips Azur 8000 Serisi ile güçlü ütüleme. 260 g turbo buharla en inatçı kırışıklıkları bile tek seferde yok edebilirsiniz.",
                  ProductStar = 5
              }
              ,
              new ProductModel
              {
                  ProductId = 36,
                  ProductName = " Kurutma Makinesi ",
                  ProductCategory = "Beyaz Eşya",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/495/550/110000546072760.jpg/format:webp",
                  ProductFeatures = "Ekran TipiLED Ekran, Özellik 1: Isı Pompalı, Özellik 2: 10 Kg Kurutma Kapasitesi, Özellik 3: Özel Karıştırıcı ve Çift Filtre",
                  ProductPrice = 22000,
                  ProductStar = 8
              }
              ,
              new ProductModel
              {
                  ProductId = 37,
                  ProductName = " Bulaşık Makinesi ",
                  ProductCategory = "Beyaz Eşya",
                  ProductImgUrl = "https://productimages.hepsiburada.net/s/261/550/110000245316455.jpg/format:webp",
                  ProductFeatures = "Bosch SMS4IKI51T 5 Programlı Bulaşık Makinesi, 13L iç kapasite, A++ Enerji Tasarrufu",
                  ProductPrice = 16700,
                  ProductStar = 7
              }
             );
           



        }
    }

}
