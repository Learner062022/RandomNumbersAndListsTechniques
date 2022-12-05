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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int int_size_array = 0;
        int[] int_children_ages;
        Random random_age_generator = new Random();

        private void btnClick_Click(object sender, EventArgs e)
        {
            int_size_array = int.Parse(txtAmountChildren.Text);
            int_children_ages = new int[int_size_array];
            for (int i = 0; i < int_size_array; i++)
            {
                int_children_ages[i] = random_age_generator.Next(0, int_size_array);
                lstAgesChildren.Items.Add(int_children_ages[i].ToString());
            }
        }
    
    }
}
