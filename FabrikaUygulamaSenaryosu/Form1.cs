using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaUygulamaSenaryosu
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
     
        private Fabrika fabrika = new Fabrika();
        private void EkranTemizle()
        {
            txtPersonelNo.Text = txtBirim.Text = mskTcKimlik.Text = txtAd.Text = txtSoyad.Text = "";
            txtPersonelNo.Focus();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                fabrika.FabrikaAdi = "Bakırçay Fabrikası";
                fabrika.FabrikaAdresi = "izmir/seyrek";
                txtFabrikaAdı.Text = fabrika.FabrikaAdi;
                txtFabrikaAdresi.Text = fabrika.FabrikaAdresi;
                Personel personel = new Personel();
                personel.PersonelNO = Convert.ToDecimal(txtPersonelNo.Text);
                personel.Birim = txtBirim.Text;
                personel.kimlik.TCKimlikNo = Convert.ToDecimal(mskTcKimlik.Text);
                personel.kimlik.Ad = txtAd.Text;
                personel.kimlik.Soyad = txtSoyad.Text;
                fabrika.PersonelEkle(personel);
                EkranTemizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Eksik veya Hatalı bilgi girdiniz. Lütfen tekrar kontrol ediniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            } 
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstListele.Items.Clear();
            foreach (var personel in fabrika.PersonelListele())
            {
                lstListele.Items.Add(personel);
            }      
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            lstListele.Items.Remove(lstListele.Items[lstListele.SelectedIndex]);
        }
    }
}
