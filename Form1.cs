using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonFinalProjem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void PersonelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            // linq sorgusu yapıyorum
            var personel = db.Personeller.Where(x=> x.personel_ad.Equals(gelenAd)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel == null) 
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            else
             MessageBox.Show("Başarılı");
           

        }
    }
}
