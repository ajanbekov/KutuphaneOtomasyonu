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
    
    public partial class UyeListelemefrm : Form
    {
        public UyeListelemefrm()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        SqlConnection baglanti = new SqlConnection // baglantı cümlesi oluşturuyoruz
            ("Data Source=LAPTOP-9LLNTJQM\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;" +
            "Integrated Security=True");
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Uye where tc like '"+ txtTc.Text + "'" ,baglanti);
            SqlDataReader read = komut .ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                comboCinsiyet.Text = read["cinsiyet"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
                txtAdres.Text = read["adres"].ToString();
                txtEmail.Text = read["email"].ToString();
                txtOkunanSayi.Text = read["okukitapsayisi"].ToString();
            }
            baglanti.Close();
        }
        DataSet daset = new DataSet();
        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Uye"].Clear();  // önce temizleyip sonra listelesin
            baglanti.Open ();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Uye where tc like" +
                "'%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(daset,"Uye"); // kayıtları geçici olarak tutacağımız tablo
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close ();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Uye where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Silindi (❁´◡`❁)");
            daset.Tables["Uye"].Clear();
            UyeListele();
            foreach  (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void UyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Uye", baglanti);
            adtr.Fill(daset,"Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
        }
        private void UyeListelemefrm_Load(object sender, EventArgs e)
        {
            UyeListele();
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Uye set adsoyad=@adsoyad,yas=@yas," +
                "cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email," +
                "okukitapsayisi=@okukitapsayisi where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc",txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", int.Parse (txtOkunanSayi.Text));
            daset.Tables["Uye"].Clear();
            UyeListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
