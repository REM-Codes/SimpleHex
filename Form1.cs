namespace SimpleHex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            string hexes = "123456789abcdef";
            char a = hexes[rnd.Next(15)];
            char b = hexes[rnd.Next(15)];
            char c = hexes[rnd.Next(15)];
            char d = hexes[rnd.Next(15)];
            char fe = hexes[rnd.Next(15)];
            char f = hexes[rnd.Next(15)];
            colorBox.BackColor = ColorTranslator.FromHtml($"#{a}{b}{c}{d}{fe}{f}");
            hexCode.Text = $"#{a}{b}{c}{d}{fe}{f}";
        }

        private void btnViewFaves_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFaves_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hexCode.Text);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string hexes = "123456789abcdef";
            char a = hexes[rnd.Next(15)];
            char b = hexes[rnd.Next(15)];
            char c = hexes[rnd.Next(15)];
            char d = hexes[rnd.Next(15)];
            char fe = hexes[rnd.Next(15)];
            char f = hexes[rnd.Next(15)];
            colorBox.BackColor = ColorTranslator.FromHtml($"#{a}{b}{c}{d}{fe}{f}");
            hexCode.Text = $"#{a}{b}{c}{d}{fe}{f}";
        }
    }
}