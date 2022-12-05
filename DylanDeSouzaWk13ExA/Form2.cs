using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk13ExA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        float[] flt_random_numbers = new float[10];
        float flt_first_number, flt_second_number;
        Random random_number_generator = new Random();

        private void btnClick_Click(object sender, EventArgs e)
        {
            flt_first_number = float.Parse(txtFirstNumber.Text);
            flt_second_number = float.Parse(txtSecondNumber.Text);
            for (int i = 0; i < flt_second_number; i++)
            {
                flt_random_numbers[i] = random_number_generator.Next((int)flt_first_number, (int)flt_second_number);
                lstRandomNumbers.Items.Add((flt_random_numbers[i]/10).ToString());
            }
        }
    }
}
