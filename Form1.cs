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
using System.Drawing.Drawing2D;

namespace mp3_parcer
{
    public partial class mainForm : Form
    {
        string filename, savefile;
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_parce_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                savefile = "parce_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";
                saveFileDialog1.FileName = savefile;
                using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.UTF8))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null) 
                    {
                        var file = TagLib.File.Create(line);
                        string artist, title, res;
                        artist = String.Join(" ", file.Tag.Performers);
                        title = file.Tag.Title;
                        res = artist + " - " + title;
                        ++i;
                        using (StreamWriter sw = new StreamWriter(savefile, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(res);
                        }
                    }
                    lb_parced.Visible = true;
                    lb_parced.Text = "Прочитано: " + i.ToString(); 
                }
            }
           
        }
    }
}
