using System;
using System.Windows.Forms;

namespace Test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double height;
            double width;

            if (double.TryParse(tbxHeight.Text, out height) && double.TryParse(tbxWidth.Text, out width))
            {
                if (height > 0 && width > 0)
                {
                    double area = height * width;
                    lblArea.Text = area.ToString();

                    double perimeter = 2 * (height * width);
                    lblPerimeter.Text = perimeter.ToString();
                }
                else
                {
                    MessageBox.Show("Positive Values Required", "Rectangle Calculator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Numeric Values Required", "Rectangle Calculator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
