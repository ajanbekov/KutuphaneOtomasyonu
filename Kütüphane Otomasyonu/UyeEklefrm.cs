using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class UyeEklefrm : Form
    {
        public UyeEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection // baglantı cümlesi oluşturuyoruz
            ("Data Source=LAPTOP-9LLNTJQM\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;" +
            "Integrated Security=True"); 
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uye(tc,adsoyad,yas,cinsiyet," +
                "telefon,adres,email,okukitapsayisi) values(@tc,@adsoyad,@yas,@cinsiyet," +
                "@telefon,@adres,@email,@okukitapsayisi)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text); 
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", txtOkunanSayi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı ^_____^");
            foreach (Control item in Controls) // formlardaki bütün kontrolleri tara / text'leri temizleme işi
            {
                if(item is TextBox) // eger madde textbox ise bunları temizle
                {
                    if (item!=txtOkunanSayi) // okuduğu kitap sayısındaki 0'ı temizlemesin
                    {
                        item.Text = "";
                    }
                }
            }  
        }
    }
}
