using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors; //DevExpress dahil ettik

namespace Oop_Saldiri_Oyunu
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Oyuncu oyuncu = new Oyuncu(); //instance aldık
        int dusmanCani;//dusman canını olusturduk

        private void btnSec_Click(object sender, EventArgs e)
        {
            if
               (
               string.IsNullOrEmpty(txtOyuncuAdi.Text) ||
               string.IsNullOrEmpty(cmbOyuncuBrans.Text) ||
               string.IsNullOrEmpty(cmbOyuncuIrk.Text) ||
               string.IsNullOrEmpty(cmbOyuncuSilah.Text)
               )
            {
                MessageBox.Show("Lütfen Tüm Alanları eksiksiz doldurunuz");
                return;
            }
            oyuncu.OyuncuAdi = txtOyuncuAdi.Text;
            oyuncu.OyuncuBrans = cmbOyuncuBrans.Text;
            oyuncu.OyuncuIrk = cmbOyuncuIrk.Text;
            oyuncu.OyuncuSilah = cmbOyuncuSilah.Text;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dusmanCani =lblDusmanCani.Width; //form acılınca dusman canını dusmancanılabelnın uzunluguna eşitle

            //Form açılınca arra içindeki değerleri comboxa ekledik

            string[] OyuncuIrk = { "Savaşçı", "Ninja", "Sura", "Şaman", "Lycan"};

            foreach (string irk in OyuncuIrk) 
            {
                cmbOyuncuIrk.Properties.Items.Add(irk);
            }

            string[] OyuncuBrans = { "Karabüyü", "Ofansif", "Defansif" };

            foreach (string brans in OyuncuBrans)
            {
                cmbOyuncuBrans.Properties.Items.Add(brans);
            }

            string[] OyuncuSilah = {
            "Saldırı Tüfeği",
            "Nişancı Tüfeği",
            "Tabanca",
            "Hafif Makineli Tüfek",
            "Pompalı Tüfek",
            "Hafif Makineli Silah",
            "Keskin Nişancı Tüfeği"
            };

            foreach (string silah in OyuncuSilah)
            {
                cmbOyuncuSilah.Properties.Items.Add(silah);
            }



        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            oyuncu.Saldir();
            dusmanCani = dusmanCani - oyuncu.SaldiriGucu; //dusman canını saldırı gucu kadar azalt
            lblDusmanCani.Width = dusmanCani; //dusman labelinin uzunluguna canını yazdık
            XtraMessageBox.Show($"Düşmana {oyuncu.SaldiriGucu} gücünde vurdunuz"); //ekrana vurdugumuz gücü yazdık

            if (dusmanCani <= 0) //dusmanın canı 0 dan küçükse
            {
                XtraMessageBox.Show("Düsmanı Yendiniz");
            }

            if(oyuncu.SaldiriGucu == 0)
            {
                XtraMessageBox.Show("Lütfen alanları doldurup seç butonuna basınız" +
                    "Eğer seçtiginiz halde sorun devam ediyorsa sistem yöneticisine başvurunuz");
            }


        }
    }
}
