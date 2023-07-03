using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class KitapEklefrm : Form
    {
        public KitapEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection // baglantı cümlesi oluşturuyoruz
           ("Data Source=LAPTOP-9LLNTJQM\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;" +
           "Integrated Security=True");
        private void KitapEklefrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(barkodno,kitapadi," +
                "yazari,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayittarihi) " +
                "values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu," +
                "@stoksayisi,@rafno,@aciklama,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@turu", comboTuru.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            komut.Parameters.AddWithValue("@kayittarihi",DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Yapıldı (●'◡'●)");
            foreach (Control item in Controls) // formlardaki bütün kontrolleri tara / text'leri temizleme işi
            {
                if (item is TextBox) // eger madde textbox ise bunları temizle
                {
                        item.Text = "";
                }
            } 
        }
    }
}
