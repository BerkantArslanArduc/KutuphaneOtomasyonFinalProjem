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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            // Kullanıcı butonlarının girişte kapalı olduğunu belirtir.
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;

            // Kaynak butonlarının girişte kapalı olduğunu belirtir.
            ekleKaynakbtn.Visible = false;
            guncelleKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false;
        }

                 private KullaniciListeForm klisteForm;

         /// <summary>
         /// kullanıcı liste ve butonları açar.
         /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if(ekleKullanicibtn.Visible == false)
            {
                  ekleKullanicibtn.Visible = true;
                  guncelleKullanicibtn.Visible = true;
                  silKullanicibtn.Visible = true;
                  klisteForm = new KullaniciListeForm();
                  klisteForm.MdiParent= this;
                  klisteForm.Show();
            }
            else
            {
                 ekleKullanicibtn.Visible = false;
                 guncelleKullanicibtn.Visible = false;
                 silKullanicibtn.Visible = false;

                 klisteForm.Hide();
            }
            
         
        }
        private KullaniciEkleForm ekleForm;
        private bool ekleKullaniciDurum = false;
        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            
            if(ekleKullaniciDurum == false)
            {
                ekleForm = new KullaniciEkleForm();
                ekleForm.MdiParent = this;
                ekleForm.Show();
                ekleKullaniciDurum = true;
            }
            else
            {
                ekleForm.Close();
                ekleKullaniciDurum = false;

            }
          
        }
        private KullaniciSilForm Ksil;
        private bool SilKullaniciDurum = false;
        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            if(SilKullaniciDurum == false)
            {
                Ksil = new KullaniciSilForm();
                Ksil.MdiParent = this;
                Ksil.Show();
                SilKullaniciDurum = true;
            }
            else
            {
                Ksil.Close();
                SilKullaniciDurum = false;
            }
        }
        private KullaniciGuncelleForm kGuncel;
        private bool GuncelleKullaniciDurum = false;
        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            if(GuncelleKullaniciDurum == false)
            {
              kGuncel = new KullaniciGuncelleForm();
              kGuncel.MdiParent = this;
              kGuncel.Show();
              GuncelleKullaniciDurum = true;
            }
            else
            {
                kGuncel.Close();
                GuncelleKullaniciDurum = false;
            }
            
        }

        private KaynakListeForm kliste;
        /// <summary>
        /// Kaynak liste ve butonları açar.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if(ekleKaynakbtn.Visible == false)
            {
                ekleKaynakbtn.Visible = true;
                guncelleKaynakbtn.Visible = true;
                silKaynakbtn.Visible = true;

                kliste = new KaynakListeForm();
                kliste.MdiParent = this;
                kliste.Show();
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                guncelleKaynakbtn.Visible = false;
                silKaynakbtn.Visible = false;

                kliste.Close();
            }
             
            
        }

        private KaynakEkleForm KEkle;
        private bool EkleKaynakDurum = false;
        private void ekleKaynakbtn_Click(object sender, EventArgs e)
        {
            if(EkleKaynakDurum == false)
            {
                KEkle = new KaynakEkleForm();
                KEkle.MdiParent = this;
                KEkle.Show();
                EkleKaynakDurum = true;
            }
            else
            {
                KEkle.Close();
                EkleKaynakDurum = false;
            }
            
        }
        private KaynakSilForm Kasil;
        private bool SilKaynakDurum = false;
        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
               
            if (SilKaynakDurum == false)

            {   Kasil = new KaynakSilForm();
                Kasil.MdiParent = this;
                Kasil.Show();
                SilKaynakDurum = true;
            }

            else
            {
                Kasil.Close();
                SilKaynakDurum = false;
            }
            
                

            
        }

        private KaynakGüncelleForm KaGuncel;
        private bool GuncelleKaynakDurum = false;
        private void guncelleKaynakbtn_Click(object sender, EventArgs e)
        {
            if(GuncelleKaynakDurum == false)
            {
                KaGuncel = new KaynakGüncelleForm();
                KaGuncel.MdiParent = this;
                KaGuncel.Show();
                GuncelleKaynakDurum = true;
            }
            else
            {
                KaGuncel.Close();
                GuncelleKaynakDurum = false;
            }
            
        }
        
        

    }
}
