﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3(Form1 f)
        {
            InitializeComponent();
            textBox1.Text = f.text;
        }
    }
}
