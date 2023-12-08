using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class colorcreate : Form
    {
        public colorcreate()
        {
            InitializeComponent();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            RenkGuncelle();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            RenkGuncelle();


        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            RenkGuncelle();

        }
        private void RenkGuncelle()
        {
            // TrackBar'ların değerlerini al
            int redValue = trackBarRed.Value;
            int greenValue = trackBarGreen.Value;
            int blueValue = trackBarBlue.Value;

            // Yeni rengi oluştur
            Color yeniRenk = Color.FromArgb(redValue, greenValue, blueValue);

            // Panelin arka plan rengini ayarla
            panel1.BackColor = yeniRenk;

            // Rengin RGB değerlerini göster
            textBox1.Text = $"R: {redValue}, G: {greenValue}, B: {blueValue}";

            // Rengin HEX değerini hesapla ve göster
            string hexDegeri = ColorToHex(yeniRenk);
            textBox2.Text = $"HEX: {hexDegeri}";
        }

        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        private void colorcreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            ColorShow colorShow = new ColorShow();
            colorShow.Show();
        }

        private void colorcreate_Load(object sender, EventArgs e)
        {

        }
    }
}
