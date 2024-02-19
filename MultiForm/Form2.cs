using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form2 : Form
    {
        public Form2(Form1 f)
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataHandler.zvoleneDatum = (DateTime)monthCalendar1.SelectionRange.Start;
            this.Close();
        }
    }
}
