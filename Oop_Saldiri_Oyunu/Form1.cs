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
            oyuncu.OyuncuAdi = txtOyuncuAdi.Text;
            oyuncu.OyuncuBrans = cmbOyuncuBrans.Text;
            oyuncu.OyuncuIrk = cmbOyuncuIrk.Text;
            oyuncu.OyuncuSilah = cmbOyuncuSilah.Text;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dusmanCani =lblDusmanCani.Width; //form acılınca dusman canını dusmancanılabelnın uzunluguna eşitle





        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            oyuncu.Saldir();
            dusmanCani = dusmanCani - oyuncu.SaldiriGucu; //dusman canını saldırı gucu kadar azalt
            lblDusmanCani.Width = dusmanCani; //dusman labelinin uzunluguna canını yazdık
            MessageBox.Show($"Düşmana {oyuncu.SaldiriGucu} gücünde vurdunuz"); //ekrana vurdugumuz gücü yazdık

            if (dusmanCani <= 0) //dusmanın canı 0 dan küçükse
            {
                XtraMessageBox.Show("Düsmanı Yendiniz");
            }
        }
    }
}
