using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DylanDeSouzaWk13ExB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MIN_HEIGHT = 100, MAX_HEIGHT = 275;
        int[] heights = new int[MIN_HEIGHT];
        int int_total_height = 0, int_average_height = 0;
        int[] height_groups = {120};
        Random random_generator = new Random();
        int int_random_num = 0, int_height_group = 120;
        private void button1_Click(object sender, EventArgs e)
        {
            int_random_num = random_generator.Next(MIN_HEIGHT, MAX_HEIGHT + 1);
            heights.Append(int_random_num);
            for (int indexer = 0; indexer < heights.Length;)
                if (heights.Length == MIN_HEIGHT)
                {
                    int_total_height = heights.Sum();
                    int_average_height = int_total_height / MIN_HEIGHT;
                }
            for (int indexer = 0; height_groups[indexer] != 179; indexer ++)
                {
                    height_groups[indexer] += 19;
                }
            for (int indexer = 0; indexer < height_groups.Length; indexer++)
                {
                    //need add to listbox
                }
            
        }
    }
}
