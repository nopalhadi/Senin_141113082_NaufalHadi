using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gnt()
        {
            if (scroll1.Value <= scroll2.Value)
            {
                min.Text = "Min = " + scroll1.Value.ToString();
                max.Text = "Max = " + scroll2.Value.ToString();
                MinY.Text = "Min Tahun = " + (2016 - scroll1.Value);
                MaxY.Text = "Max Tahun = " + (2016 + scroll2.Value);
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-scroll1.Value);
                dateTimePicker1.MaxDate = DateTime.Today.AddYears(scroll2.Value);
            }
            else {
                min.Text = "Min = " + scroll2.Value.ToString();
                max.Text = "Max = " + scroll1.Value.ToString();
                MinY.Text = "Min Tahun = " + (2016 - scroll1.Value);
                MaxY.Text = "Max Tahun = " + (2016 + scroll2.Value);
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-scroll2.Value);
                dateTimePicker1.MaxDate = DateTime.Today.AddYears(scroll1.Value);
            }
        }

        private void gnt1(object sender, ScrollEventArgs e)
        {
            sn1.Text = "Scroll 1 = " + scroll1.Value.ToString();
            gnt();
        }
        private void gnt2(object sender, ScrollEventArgs e)
        {
            sn2.Text = "Scroll 2 = " + scroll2.Value.ToString();
            gnt();
        }

        private void sc2_Click(object sender, EventArgs e)
        {

        }

        private void scrol2_Scroll(object sender, ScrollEventArgs e)
        {
            sn2.Text = "Scroll 2 = " + scroll2.Value.ToString();
            gnt();
        }

        private void scrol1_Scroll(object sender, ScrollEventArgs e)
        {
            sn1.Text = "Scroll 1 = " + scroll1.Value.ToString();
            gnt();
        }
    }
}
