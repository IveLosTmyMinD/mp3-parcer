namespace mp3_parcer
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_namefile = new System.Windows.Forms.Button();
            this.lb_choose = new System.Windows.Forms.Label();
            this.lb_selected = new System.Windows.Forms.Label();
            this.bt_parce = new System.Windows.Forms.Button();
            this.lb_parced = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_namefile
            // 
            this.bt_namefile.Location = new System.Drawing.Point(7, 48);
            this.bt_namefile.Name = "bt_namefile";
            this.bt_namefile.Size = new System.Drawing.Size(242, 23);
            this.bt_namefile.TabIndex = 0;
            this.bt_namefile.Text = "Открыть";
            this.bt_namefile.UseVisualStyleBackColor = true;
            this.bt_namefile.Click += new System.EventHandler(this.bt_namefile_Click);
            // 
            // lb_choose
            // 
            this.lb_choose.AutoSize = true;
            this.lb_choose.Location = new System.Drawing.Point(4, 32);
            this.lb_choose.Name = "lb_choose";
            this.lb_choose.Size = new System.Drawing.Size(245, 13);
            this.lb_choose.TabIndex = 1;
            this.lb_choose.Text = "Выберите текстовый файл с именами файлов:";
            // 
            // lb_selected
            // 
            this.lb_selected.AutoSize = true;
            this.lb_selected.Location = new System.Drawing.Point(4, 74);
            this.lb_selected.Name = "lb_selected";
            this.lb_selected.Size = new System.Drawing.Size(42, 13);
            this.lb_selected.TabIndex = 2;
            this.lb_selected.Text = "Файл: ";
            // 
            // bt_parce
            // 
            this.bt_parce.Location = new System.Drawing.Point(7, 90);
            this.bt_parce.Name = "bt_parce";
            this.bt_parce.Size = new System.Drawing.Size(242, 23);
            this.bt_parce.TabIndex = 3;
            this.bt_parce.Text = "Прочитать";
            this.bt_parce.UseVisualStyleBackColor = true;
            this.bt_parce.Click += new System.EventHandler(this.bt_parce_Click);
            // 
            // lb_parced
            // 
            this.lb_parced.AutoSize = true;
            this.lb_parced.Location = new System.Drawing.Point(4, 116);
            this.lb_parced.Name = "lb_parced";
            this.lb_parced.Size = new System.Drawing.Size(64, 13);
            this.lb_parced.TabIndex = 4;
            this.lb_parced.Text = "Прочитано:";
            this.lb_parced.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "txt файлы(*.txt)|*.txt";
            this.openFileDialog1.Title = "Открыть текстовый документ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt файлы|*.txt";
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 141);
            this.Controls.Add(this.lb_parced);
            this.Controls.Add(this.bt_parce);
            this.Controls.Add(this.lb_selected);
            this.Controls.Add(this.lb_choose);
            this.Controls.Add(this.bt_namefile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "MP3 Parcer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_namefile;
        private System.Windows.Forms.Label lb_choose;
        private System.Windows.Forms.Label lb_selected;
        private System.Windows.Forms.Button bt_parce;
        private System.Windows.Forms.Label lb_parced;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

