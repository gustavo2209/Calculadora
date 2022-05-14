using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void proceso(object sender, EventArgs e)
        {
            // VALIDACION

            double? x1 = null, x2 = null;

            try
            {
                x1 = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Valor 1 incorrecto");
                return;
            }

            try
            {
                x2 = Convert.ToDouble(textBox2.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Valor 2 incorrecto");
                return;
            }

            // PROCESO

            Button button = (Button)sender;

            switch (button.Text)
            {
                case "+":
                    textBox3.Text = (x1 + x2).ToString();
                    break;

                case "-":
                    textBox3.Text = (x1 - x2).ToString();
                    break;

                case "*":
                    textBox3.Text = (x1 * x2).ToString();
                    break;

                case "/":
                    textBox3.Text = (x1 / x2).ToString();
                    break;
            }
        }
    }
}
