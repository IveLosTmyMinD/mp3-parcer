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
            this.lb_check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_namefile
            // 
            this.bt_namefile.Location = new System.Drawing.Point(7, 61);
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
            this.lb_selected.Location = new System.Drawing.Point(4, 96);
            this.lb_selected.Name = "lb_selected";
            this.lb_selected.Size = new System.Drawing.Size(42, 13);
            this.lb_selected.TabIndex = 2;
            this.lb_selected.Text = "Файл: ";
            // 
            // bt_parce
            // 
            this.bt_parce.Location = new System.Drawing.Point(7, 122);
            this.bt_parce.Name = "bt_parce";
            this.bt_parce.Size = new System.Drawing.Size(242, 23);
            this.bt_parce.TabIndex = 3;
            this.bt_parce.Text = "Прочитать";
            this.bt_parce.UseVisualStyleBackColor = true;
            // 
            // lb_parced
            // 
            this.lb_parced.AutoSize = true;
            this.lb_parced.Location = new System.Drawing.Point(4, 161);
            this.lb_parced.Name = "lb_parced";
            this.lb_parced.Size = new System.Drawing.Size(64, 13);
            this.lb_parced.TabIndex = 4;
            this.lb_parced.Text = "Прочитано:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_check
            // 
            this.lb_check.AutoSize = true;
            this.lb_check.Location = new System.Drawing.Point(7, 207);
            this.lb_check.Name = "lb_check";
            this.lb_check.Size = new System.Drawing.Size(38, 13);
            this.lb_check.TabIndex = 5;
            this.lb_check.Text = "Check";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 350);
            this.Controls.Add(this.lb_check);
            this.Controls.Add(this.lb_parced);
            this.Controls.Add(this.bt_parce);
            this.Controls.Add(this.lb_selected);
            this.Controls.Add(this.lb_choose);
            this.Controls.Add(this.bt_namefile);
            this.Name = "mainForm";
            this.Text = "MP3 Parcer";
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
        private System.Windows.Forms.Label lb_check;
    }
}

