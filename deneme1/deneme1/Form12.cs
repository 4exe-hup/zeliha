﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme1
{
    public partial class Form12 : Form
    {
        public Form12(string gelenMetin) : this()
        {
            // Form2'deki Label'a metni yerleştir
            label1.Text = "MERHABA " + gelenMetin;
        }
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
