﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCSharpProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_console_Click(object sender, EventArgs e)
        {
            Console consoleForm = new Console(); //Create a new object
            consoleForm.Show(); //Show the new form
        }
    }
}
