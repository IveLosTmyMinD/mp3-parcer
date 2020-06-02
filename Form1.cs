using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TagLib;
using System.Threading;

namespace mp3_parcer
{
    public partial class mainForm : Form
    {
        string filename;
        public mainForm()
        {
            InitializeComponent();
        }

        private void bt_namefile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                filename = openFileDialog1.FileName;
                lb_selected.Text = Path.GetDirectoryName(filename) + "\\" + Path.GetFileName(filename);
            }
        }
    }
}
