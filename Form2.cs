using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepentanceChallengeCreator
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        // Form1 form1 = new Form1();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coinCounter.Value = 99;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            passiveItemsList.Items.Add("Deep Pockets");
            coinCounter.Value = coinCounter.Maximum = 999;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        decimal prevValue = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > prevValue)
            {
                groupBox1.Controls.Add(pictureBox4);
                groupBox1.Show();
            }
            else
            {
                groupBox1.Controls.Remove(pictureBox4);
                groupBox1.Show();
            }
            prevValue = numericUpDown1.Value;
        }
    }
}
