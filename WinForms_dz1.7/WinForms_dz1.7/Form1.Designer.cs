namespace WinForms_dz1._7
{
    partial class Form1
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.rdbGod = new System.Windows.Forms.RadioButton();
            this.rdbMesaz = new System.Windows.Forms.RadioButton();
            this.rdbDen = new System.Windows.Forms.RadioButton();
            this.rdbMinuta = new System.Windows.Forms.RadioButton();
            this.rdbSecunda = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(40, 24);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 0;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // txbResult
            // 
            this.txbResult.Enabled = false;
            this.txbResult.Location = new System.Drawing.Point(40, 228);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(200, 20);
            this.txbResult.TabIndex = 1;
            // 
            // rdbGod
            // 
            this.rdbGod.AutoSize = true;
            this.rdbGod.Location = new System.Drawing.Point(40, 63);
            this.rdbGod.Name = "rdbGod";
            this.rdbGod.Size = new System.Drawing.Size(49, 17);
            this.rdbGod.TabIndex = 2;
            this.rdbGod.TabStop = true;
            this.rdbGod.Text = "Года";
            this.rdbGod.UseVisualStyleBackColor = true;
            this.rdbGod.CheckedChanged += new System.EventHandler(this.rdbGod_CheckedChanged);
            // 
            // rdbMesaz
            // 
            this.rdbMesaz.AutoSize = true;
            this.rdbMesaz.Location = new System.Drawing.Point(40, 91);
            this.rdbMesaz.Name = "rdbMesaz";
            this.rdbMesaz.Size = new System.Drawing.Size(64, 17);
            this.rdbMesaz.TabIndex = 3;
            this.rdbMesaz.TabStop = true;
            this.rdbMesaz.Text = "Месяца";
            this.rdbMesaz.UseVisualStyleBackColor = true;
            this.rdbMesaz.CheckedChanged += new System.EventHandler(this.rdbMesaz_CheckedChanged);
            // 
            // rdbDen
            // 
            this.rdbDen.AutoSize = true;
            this.rdbDen.Location = new System.Drawing.Point(40, 122);
            this.rdbDen.Name = "rdbDen";
            this.rdbDen.Size = new System.Drawing.Size(46, 17);
            this.rdbDen.TabIndex = 4;
            this.rdbDen.TabStop = true;
            this.rdbDen.Text = "Дни";
            this.rdbDen.UseVisualStyleBackColor = true;
            this.rdbDen.CheckedChanged += new System.EventHandler(this.rdbDen_CheckedChanged);
            // 
            // rdbMinuta
            // 
            this.rdbMinuta.AutoSize = true;
            this.rdbMinuta.Location = new System.Drawing.Point(40, 154);
            this.rdbMinuta.Name = "rdbMinuta";
            this.rdbMinuta.Size = new System.Drawing.Size(64, 17);
            this.rdbMinuta.TabIndex = 5;
            this.rdbMinuta.TabStop = true;
            this.rdbMinuta.Text = "Минуты";
            this.rdbMinuta.UseVisualStyleBackColor = true;
            this.rdbMinuta.CheckedChanged += new System.EventHandler(this.rdbMinuta_CheckedChanged);
            // 
            // rdbSecunda
            // 
            this.rdbSecunda.AutoSize = true;
            this.rdbSecunda.Location = new System.Drawing.Point(40, 186);
            this.rdbSecunda.Name = "rdbSecunda";
            this.rdbSecunda.Size = new System.Drawing.Size(69, 17);
            this.rdbSecunda.TabIndex = 6;
            this.rdbSecunda.TabStop = true;
            this.rdbSecunda.Text = "Секунды";
            this.rdbSecunda.UseVisualStyleBackColor = true;
            this.rdbSecunda.CheckedChanged += new System.EventHandler(this.rdbSecunda_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rdbSecunda);
            this.Controls.Add(this.rdbMinuta);
            this.Controls.Add(this.rdbDen);
            this.Controls.Add(this.rdbMesaz);
            this.Controls.Add(this.rdbGod);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.dtpData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.RadioButton rdbGod;
        private System.Windows.Forms.RadioButton rdbMesaz;
        private System.Windows.Forms.RadioButton rdbDen;
        private System.Windows.Forms.RadioButton rdbMinuta;
        private System.Windows.Forms.RadioButton rdbSecunda;
    }
}

