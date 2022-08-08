using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class form_pi : Form
    {
        public form_pi()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            int terms;
            double divisor = 3;
            double pi = 4;

            // Input validation, check for integer
            if(!int.TryParse(tbx_input.Text, out terms))
            {
                MessageBox.Show("Enter a valid integer");
            }
            else
            {
                for (int i = 0; i <= terms; i++)
                {
                    if (terms == 0)
                    {
                        lbl_output.Text = pi.ToString();
                    }
                    // Add if current term # is even, subtract if odd
                    else if ((i % 2) == 0)
                    {
                        pi -= (4 / divisor);
                    }
                    else
                    {
                        pi += (4 / divisor);
                    }
                    // Increase divisor by 2 every iteration
                    divisor += 2;
                }
                // Display output
                lbl_output.Text = "Approximate value of pi after " + terms + " terms: " + pi.ToString();
            }
        }
    }
}
