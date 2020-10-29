using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Task4
{

    public partial class Form1 : Form
    {
        public Color[] brickcolor = new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green,
                Color.Blue,Color.DarkBlue,Color.Purple};
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(this.FormClick);
        }

        private void FormClick(object sender, MouseEventArgs e)
        {
                for (int i = 0; i < brickcolor.Length; i++) {
                if (e.Button == MouseButtons)
                    Thread.Sleep(300);
                    this.BackColor = brickcolor[i++];
                }
        }
    }
}
