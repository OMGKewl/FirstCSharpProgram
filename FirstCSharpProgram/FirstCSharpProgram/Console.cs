using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib; // Autoit Library

namespace FirstCSharpProgram
{
    public partial class Console : Form
    {
        public Console()
        {
            InitializeComponent();
        }

        AutoItX3 au3 = new AutoItX3(); //Create a new autoit object
        private void btn_console_save_Click(object sender, EventArgs e)
        {
            au3.MouseMove(0, 0, 10);
            au3.Sleep(100);

        }
    }
}
