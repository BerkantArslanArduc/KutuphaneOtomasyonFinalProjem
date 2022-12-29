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
    public partial class KaynakEkleForm : Form
    {
        //bu kod sql connection kullansaydım bağlantı için yazmam gereken kod.
        //static String baglanti = ConfigurationManager.ConnectionStrings["KutuphaneOtomasyonEntities"].ConnectionString;
        public KaynakEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();
            kaynaklar.kaynak_ad = adKaynaktxt.Text;
            kaynaklar.kaynak_yazar = yazarKaynaktxt.Text;
            kaynaklar.kaynak_yayıncı = yayıncıKaynaktxt.Text;
            kaynaklar.kaynak_sayfasayısı = Convert.ToInt16(numericUpDown1.Value);
            kaynaklar.kaynak_basımtarihi = dateTimePicker1.Value;
            db.Kaynaklar.Add(kaynaklar);
            db.SaveChanges();

            var kliste = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }

        private void KaynakEkleForm_Load(object sender, EventArgs e)
        {
            var kliste = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }
    }
}
