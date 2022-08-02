using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mksheet_vtex_gui
{
    public partial class VTEXConfig : Form
    {

        public string text;

        public VTEXConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.VTEXConfig = textBox1.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void VTEXConfig_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.VTEXConfig;
        }
    }
}
