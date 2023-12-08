using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace ColorPicker
{
    public partial class Sr : Form
    {
        public Sr()
        {
            InitializeComponent();
            Sr_LoadRgbValues("color_history.txt");
        }

        private void Sr_LoadRgbValues(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Dosyayı satır satır oku
                    string[] lines = File.ReadAllLines(filePath);

                    // Eğer satır sayısı 9'dan fazlaysa, sadece ilk 9 satırı al
                    int lineCount = Math.Min(lines.Length, 9);

                    for (int i = 0; i < lineCount; i++)
                    {
                        // Regex deseni tanımla
                        string pattern = @"R:\s*(\d+)\s*,\s*G:\s*(\d+)\s*,\s*B:\s*(\d+)";

                        // Regex eşleşmelerini bul
                        Match match = Regex.Match(lines[i], pattern);

                        // Eğer eşleşme varsa, sayıları al ve label'a ata
                        if (match.Success)
                        {
                            int r = int.Parse(match.Groups[1].Value);
                            int g = int.Parse(match.Groups[2].Value);
                            int b = int.Parse(match.Groups[3].Value);

                            // Label'ın adını oluştur
                            string labelName = $"label{i + 1}";

                            // Kontrolü bul
                            Label label = Controls.Find(labelName, true).FirstOrDefault() as Label;

                            // Label varsa RGB değerini yaz
                            if (label != null)
                            {
                                label.Text = $"R: {r}, G: {g}, B: {b}";

                                // Buton adını oluştur
                                string buttonName = $"button{i + 1}";

                                // Kontrolü bul
                                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                                // Buton varsa BackColor'u ayarla
                                if (button != null)
                                {
                                    button.BackColor = Color.FromArgb(r, g, b);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show($"Dosya okuma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sr_Load(object sender, EventArgs e)
        {

        }

        private void Sr_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label5.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label6.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label7.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label8.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label9.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clipboard işlemi başarısız oldu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sr_FormClosing(object sender, FormClosingEventArgs e)
        {
            ColorShow fr = new ColorShow();
            fr.Show();
        }

        private void Sr_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            ColorShow color = new ColorShow();
            color.Show();

        }
    }
}
