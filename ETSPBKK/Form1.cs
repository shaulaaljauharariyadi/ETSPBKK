using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETSPBKK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conv_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(amount_txt.Text);
            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Dollar")
            {
                int conver = i / 82;
                label4.Text = "Converted Amount : " + conver + "\t Dollar";

            }
            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Euro")
            {
                int conver = i / 90;
                label4.Text = "Converted Amount : " + conver + "\t Euro";
            }

            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Rupees")
            {
                int conver = i;
                label4.Text = "Converted Amount : " + conver + "\t Rupees";
            }

            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Rupees")
            {
                int conver = i * 82;
                label4.Text = "Converted Amount : " + conver + "\t Rupees";

            }
            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Euro")
            {
                double conver = i * 0.9;
                label4.Text = "Converted Amount : " + conver + "\t Euro";
            }

            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Dollar")
            {
                double conver = i;
                label4.Text = "Converted Amount : " + conver + "\t Dollar";
            }


            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Rupees")
            {
                int conver = i * 90;
                label4.Text = "Converted Amount : " + conver + "\t Rupees";

            }
            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Dollar")
            {
                double conver = i * 1.1;
                label4.Text = "Converted Amount : " + conver + "\t Dollar";
            }
            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Euro")
            {
                double conver = i;
                label4.Text = "Converted Amount : " + conver + "\t Euro";
            }
        }
        private void label4_Click(object receiver, EventArgs e)
        {

        }
    }
}