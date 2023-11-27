using System.Diagnostics.Metrics;

namespace ColorPicker;

public partial class ColorShow : Form
{
    private const int MaxStoredColors = 9;
    private readonly Stack<string> colorStack = new Stack<string>();
    public ColorShow()
    {
        InitializeComponent();
        MouseClickHandler.ColorShowFormInstance = this;
        MouseClickHandler.Clicked += ColorPicker;
        HomeKeyHandler.KeyDown += HomePushed;
        this.TopLevel = true;
    }

    private void HomePushed()
    {
        this.Visible = !this.Visible;
    }

    private void ColorPicker()
    {
        Point mousePosition = Cursor.Position;
        Color pixelColor = GetPixelColor(mousePosition.X, mousePosition.Y);

        lbl_color.Text = $"R: {pixelColor.R}, G: {pixelColor.G}, B: {pixelColor.B}";
        btn_colorShow.BackColor = pixelColor;


    }


    private static Color GetPixelColor(int x, int y)
    {
        using (Bitmap bitmap = new Bitmap(1, 1))
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
            }
            return bitmap.GetPixel(0, 0);
        }
    }

    private void ColorShow_Load(object sender, EventArgs e)
    {

    }

    private void btn_colorShow_Click(object sender, EventArgs e)
    {
        Point mousePosition = Cursor.Position;
        Color pixelColor = GetPixelColor(mousePosition.X, mousePosition.Y);

        string colorInfo = $"R: {pixelColor.R}, G: {pixelColor.G}, B: {pixelColor.B}";
        lbl_color.Text = colorInfo;
        btn_colorShow.BackColor = pixelColor;

        // Renk bilgisini stack'e ekle
        colorStack.Push(colorInfo);

        // Renk bilgilerini dosyaya yaz
        WriteColorsToFile("color_history.txt");
    }

    private void WriteColorsToFile(string filePath)
    {
        try
        {
            // Stack'teki öðeleri geçici bir liste olarak al
            List<string> tempColorList = colorStack.ToList();

            // Belirtilen dosya yoluna metin dosyasýný oluþtur ve yaz
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // En üstteki öðeyi alarak stack'ten çýkar
                string removedColor = colorStack.Pop();

                // Geçici listeyi kullanarak dosyaya yaz
                foreach (var color in tempColorList)
                {
                    sw.WriteLine(color);
                }

                // En üstteki öðeyi geri ekleyerek stack'i eski durumuna getir
                colorStack.Push(removedColor);
            }
        }
        catch (Exception ex)
        {
            // Hata durumunda kullanýcýya bilgi ver
            MessageBox.Show($"Dosya yazma hatasý: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void toolStripLabel1_Click(object sender, EventArgs e)
    {
        Sr sform = new Sr();
        sform.Show();
        this.Hide();
    }


}
