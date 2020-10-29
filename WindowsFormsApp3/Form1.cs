using System.Windows.Forms;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {

        int leftButton = 0, rightButton = 0;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(this.Form_click);
        }

        private void Form_click(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                leftButton += 1;
                this.textLable.Text = "Left button click";
                this.times.Text = leftButton.ToString();

            }
            else if (e.Button == MouseButtons.Right)
            {
                rightButton += 1;
                this.textLable.Text = "Right button click";
                this.times.Text = rightButton.ToString();
            }
        }


    }


}
