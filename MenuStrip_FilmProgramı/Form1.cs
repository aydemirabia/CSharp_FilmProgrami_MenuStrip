using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_FilmProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yüzüklerinEfendisiKralınDönüşüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Yüzüklerin Efendisi: Kralın Dönüşü, Tek Yüzük'ün yok edilmesi için verilen mücadeleyi konu ediyor. Sauron'un orduları büyüdükçe büyümektedirler. Frodo ve onun can dostu Sam, korku dolu bir yolculuğun göbeğinde, korkunç Mordor'a adım adım yaklaşmaktadırlar.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\1.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Beyoğlu Yeşilçam Adres: Şehit Muhtar Mahallesi İstiklal Cad.İmam Adnan Sokak No:8, 34435 Beyoğlu / İstanbul Tel: (212) 2936800" + "\n\n" +
                "Biz Cevahir Haliç AVM Site Adres: Alibeyköy Mah. Vardar Bulvarı No: 5-11 Biz Cevahir Haliç AVM Eyüp/İstanbul Tel: (212) 6276666" + "\n\n"+
                "Arnavutköy Cinemaximum (Avlu 34) Adres: Arnavutköy Merkez Mah. Avlu 34 AVM 34275 Arnavutköy/İstanbul Tel: (085) 02200967" + "\n\n" +
                "Beşiktaş Cinemaximum (Zorlu Center) Adres: Koru Sok. No: 2/13 Zorlu Center AVM Beşiktaş/İstanbul Tel: (085) 02200967"; ;
        }

        private void karaŞövalyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kara Şövalye, halk için büyük bir tehdit oluşturan Joker'in ortaya çıkması ile kaosa dönen Gotham Sokakları'nın yeniden kurtarıcılığını üstlenen Batman'in hikayesini konu ediyor.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\2.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void gladyatörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "İmparator Marcus Aurelius'un hüküm sürdüğü Roma'da bir general olan Maximus, imparatorluğun hiyerarşik basamaklarında gitgide yükselmiştir. Babasının kendisini kayırmak yerine Maximus adındaki bir generali el üstünde tutması da tahtın asıl varisi olan Commodus'u rahatsız etmektedir.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\3.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void ahmakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Hindistan'ın en iyi mühendislik okuluna başlayan öğrencilerin hayatını anlatıyor özet olarak. Sistemin daima yarış üzerine kurulu olduğu, herkesin en iyi olmaya çabaladığı bir okulda sistemi değiştirmeye çalışan bir öğrenci ve onun en yakın 2 arkadaşı.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\4.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void gORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Türkiye'nin turistik kentlerinden biri olan Antalya'da tüccarlık yapan Arif uzaylılar tarafından kaçırılarak G.O.R.A. isimli gezegene götürülür. Arif, gezegende tutsakken gezegeni bir alev topundan kurtarır ve bu sırada Ceku isimli prensesle tanışır. Bütün bunlar olurken, G.O.R.A. gezegeninin kötü kalpli komutanı Logar, Ceku ile evlenerek gezegenin yönetimini ele geçirmek istemektedir. Arif bunu öğrenir ve gezegenden kaçarken Ceku'yu da yanında götürmek ister, fakat bunun için Komutan Logar'a karşı mücadele vermesi gerekmektedir";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\5.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void buzDevriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "2006 yılında bu başarıyı aşan devam filmi, Buz Devri: Erime çekilmiştir. Buz Devri, Dünyanın buzla kaplanmaya başladığı dönemde, Buzul Çağında bir mamut, bir kılıç dişli kaplan, bir miskin ve bir bebeğin maceralarını anlatıyor.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\6.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void evdeTekBaşınaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ailesini pek sevmeyen Kevin (Macaulay Culkin) aldığı ceza üzerine geceyi evlerinin çatıkatında geçirir ve ertesi gün yatağında uyandığında ailesinin evde olmadığını, tatile giderken onu unuttuklarını fark eder. Başta panikleyen Kevin bunun fırsat olduğunu çok geçmeden anlar ve yalnızlığın keyfini çıkarır.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\7.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void yıldızlararasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Başrollerinde Matthew McConaughey, Anne Hathaway, Jessica Chastain ve Michael Caine yer almaktadır. Filmde bir grup astronotun bir solucan deliğinden geçerek insanların yaşayabileceği yeni bir yer arayışı konu edilmektedir."+
                                "İşte filmin ana teması da aslında kara deliğin içinde neler olup bittiğini bilmememize dayanmakta. Kara deliklere ilişkin alternatif fizik modelleri vardır.Bu modellerden bazıları kuantum kuramıyla kütleçekimi birleştiren kuantum kütleçekim kuramlarıdır ki, en popülerleri arasında sicim kuramları yer alır.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\8.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void yenilmezlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Yenilmezler, bazı ülkelerde Avengers Assemble olarak da bilinmektedir. Marvel Studios tarafından üretilen ve Marvel Comics'in süper kahraman ekibidir. Dağıtımını Wss Whedon yazıp yönetmiştir. Ayrıca altıncı Marvel Sinematik Evreni filmi olup 1. Evre'nin kapanış filmidir."+
                                "SHIELD ismiyle bilinen uluslararası bir barış örgütü, tüm dünya için büyük bir tehdit oluşturan bir düşmanla karşı karşıya gelir. Bu düşmanla savaşabilecek kişiler sadece süper kahramanlardır";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\9.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void ıronManToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "Marvel Sinematik Evreni'nin yüzü haline gelen Tony Stark, 2019 tarihli filmde sonsuzluk taşlarını kullanarak kendini feda etmişti. Böylece evreni Thanos'tan kurtaran süper kahramana veda edilmişti.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\10.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void transformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Bir tarafta Autobotlar denen İyi robotlar ve Decepticonlar adlı kötü robotlar olarak farklı hedeflerin peşinde koşan bu Transformer'lar, gezegenlerindeki Energon Küpleri adı verilen yakıt stoklarının azalması sonucu, uzayda farklı yakıt kaynaklarının arayışı içine girerler.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\11.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void lastChristmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Emilia Clarke'ın başrolünde yer aldığı Last Christmas, bir önceki Noel'de geçirdiği ciddi hastalıktan sonra şansı bir türlü yaver gitmeyen, biraz da vurdumduymaz Kate'in, yeni bir Noel'e yaklaşırken Tom ile tanışması sonrası gelişen olayları konu ediniyor.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\12.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void mucize2AşkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kötülerin ve ön yargılı insanların her yerde var olduğu dünyamızda Aziz ve Mızgin kendi başlarına ayakta kalmayı, hayata tutunmayı, çabalamayı ve çalışmayı öğreneceklerdir. Aziz deliler gibi âşık olduğu karısı Mızgin için, kusurlarından ve engellerinden kurtulmak için büyük bir azimle mücadeleye başlar.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\13.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void siyahTelefonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Siyah Telefon, 13 yaşında kaçırılan bir çocuğun yaşadıklarına odaklanıyor. Utangaç, ama zeki bir çocuk olan Finney Shaw, sadist bir katil tarafından ses geçirmez bir bodrum katında alıkonulur. Duvarda duran ve bağlı gibi görünmeyen telefon çalmaya başladığında işler değişir. Finney, telefon aracılığıyla katilin diğer kurbanlarının sesini duyabiliyordur. Finney, diğer kurbanların başlarına gelenlerin kendi başına gelmemesi konusunda kararlıdır ve bunun için zorlu bir mücadeleye girişir.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\14.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void kırmızıDeğirmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Bir şair olan Christian, sık sık ziyaret ettiği bir gece kulübü olan Moulin Rouge'daki dansçılardan bir tanesine delicesine aşık olur. Ancak ortada büyük bir sorun vardır. Zira oldukça kıskanç bir karakter yapısına sahip olan bir Dük de, aynı kıza sırılsıklam aşıktır.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\15.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void ölüGelinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "19 yüzyılda bir Avrupa köyünde geçen film, aniden yer altına gidiveren ve Ölü Gelin ile evlendirilen genç adam Victor'un hikayesini anlatıyor. Bu arada gerçek gelin Victoria da onu yaşayanların arasında beklemektedir.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\16.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void operadakiHayaletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Paris Opera Binası'nın mahzeninde, yüzü tanınmayacak derecede ürkütücü olduğu için insanlara görünmeden bir hayalet gibi yaşayan müzik dehası Opera Hayaleti, korodaki Christine'e gizlice müzik dersleri vererek onun ünlü bir soprano olmasını sağlar ve zaman geçtikçe ona büyük bir sevgiyle bağlanır.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\17.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void zincirsizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Zincirsiz, Köle Django'nun Alman asıllı ödül avcısı Dr. King Schultz ile yolunun kesişmesiyle başlıyor. Django, eski efendisini ölü ya da diri ele geçirmek isteyen Schultz ile anlaşmaya varır ve özgürlüğü karşısında Brittle kardeşleri kendisine getirme sözü verir.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\18.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void ölüAdamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Jim Jarmusch'un klasik filmlerinden Dead Man, vahşi batıya doğru bir yolculuğa çıkan William Blake'in, Hiç Kimse adındaki Kızılderili ile tanıştıktan sonra yaşadıklarını anlatıyor. Kaybedecek hiçbir şeyi kalmayan William Blake, vahşi batıya uzanan bir yolculuğa çıkar.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\19.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Stephen King'in Rita Hayworth ve Shawshank'in Kefareti adlı novellasından uyarlanan film, masumiyetini iddia etmesine rağmen karısını ve sevgilisini öldürdüğü gerekçesiyle Shawshank Devlet Cezaevi'nde yaklaşık 20 yılını geçiren bankacı Andy Dufresne'in hikâyesini anlatır.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\20.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }

        private void yeşilYolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Oldukça iri bir adam olan John Coffey, iki küçük kızı tecavüz ederek öldürmek suçundan idama mahkûm olmuştur. Ürkütücü görünümünün aksine oldukça ince ve karmaşık bir iç dünyası olan John Coffey, bazı doğaüstü güçlere sahiptir.";
            pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MenuStrip_FilmProgramı\\21.jpg";
            PictureBoxSizeMode.StretchImage.ToString();
        }
    }
}

