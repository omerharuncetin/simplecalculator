using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecalculator
{
    public partial class FormTopla : Form
    {
        public FormTopla()
        {
            InitializeComponent();
        }

        private int Topla(int birinciSayi, int ikinciSayi)
        {
            return birinciSayi + ikinciSayi;
        }
        
        private bool Dogrula()
        {
            try
            {
                int.Parse(txtBirinciSayi.Text);
                int.Parse(txtIkinciSayi.Text);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void EkraniAyarla(bool toplamBasarili = false)
        {
            if (!toplamBasarili)
            {
                txtBirinciSayi.Text = txtIkinciSayi.Text = "0";
                txtBirinciSayi.Focus();
            }
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            bool dogrulamaSonucu = Dogrula();
            if (Dogrula())
            {
                int toplam = Topla(int.Parse(txtBirinciSayi.Text), int.Parse(txtIkinciSayi.Text));
                txtSonuc.Text = toplam.ToString();
                lvLog.Items.Add("Toplama işlemi başarılı:" + toplam);
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerler hatalı!");
                lvLog.Items.Add("Toplama işlemi başarısız! txtbir = " + txtBirinciSayi.Text + " txtiki = " + txtIkinciSayi.Text);
            }
            EkraniAyarla(dogrulamaSonucu);

        }

        private void FormTopla_Shown(object sender, EventArgs e)
        {
            EkraniAyarla();
        }

        private void txtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
            
        }

        private void txtIkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lvLog.Clear();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            tabToplam.SelectedTab = tabToplama;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            tabToplam.SelectedTab = tabLog;
        }
    }
}
