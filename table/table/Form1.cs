using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            msjresult.Visible = false;
            results.Items.Clear();
            int calculo = 0;
            string result;

            for (int i=0; i<12; i++)
            {
                calculo = (int) captureNum.Value * i;
                result = captureNum.Value + "x" + i + "=" + calculo;
                results.Items.Add(result);
            }
             
        }

        private void captureNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
