
namespace Moop_LR11
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.advertisingCheckBox = new System.Windows.Forms.CheckBox();
            this.SumCheckBox = new System.Windows.Forms.CheckBox();
            this.DataCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressCheckBox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(323, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(271, 383);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 37);
            this.button1.TabIndex = 31;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // advertisingCheckBox
            // 
            this.advertisingCheckBox.AutoSize = true;
            this.advertisingCheckBox.Location = new System.Drawing.Point(41, 184);
            this.advertisingCheckBox.Name = "advertisingCheckBox";
            this.advertisingCheckBox.Size = new System.Drawing.Size(187, 21);
            this.advertisingCheckBox.TabIndex = 30;
            this.advertisingCheckBox.Text = "Рекламное объявление";
            this.advertisingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SumCheckBox
            // 
            this.SumCheckBox.AutoSize = true;
            this.SumCheckBox.Location = new System.Drawing.Point(41, 145);
            this.SumCheckBox.Name = "SumCheckBox";
            this.SumCheckBox.Size = new System.Drawing.Size(72, 21);
            this.SumCheckBox.TabIndex = 29;
            this.SumCheckBox.Text = "Сумма";
            this.SumCheckBox.UseVisualStyleBackColor = true;
            // 
            // DataCheckBox
            // 
            this.DataCheckBox.AutoSize = true;
            this.DataCheckBox.Checked = true;
            this.DataCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DataCheckBox.Enabled = false;
            this.DataCheckBox.Location = new System.Drawing.Point(41, 106);
            this.DataCheckBox.Name = "DataCheckBox";
            this.DataCheckBox.Size = new System.Drawing.Size(118, 21);
            this.DataCheckBox.TabIndex = 28;
            this.DataCheckBox.Text = "Данные чека";
            this.DataCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddressCheckBox
            // 
            this.AddressCheckBox.AutoSize = true;
            this.AddressCheckBox.Location = new System.Drawing.Point(41, 67);
            this.AddressCheckBox.Name = "AddressCheckBox";
            this.AddressCheckBox.Size = new System.Drawing.Size(70, 21);
            this.AddressCheckBox.TabIndex = 27;
            this.AddressCheckBox.Text = "Адрес";
            this.AddressCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(41, 25);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(144, 21);
            this.NameCheckBox.TabIndex = 26;
            this.NameCheckBox.Text = "Название фирмы";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advertisingCheckBox);
            this.Controls.Add(this.SumCheckBox);
            this.Controls.Add(this.DataCheckBox);
            this.Controls.Add(this.AddressCheckBox);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox advertisingCheckBox;
        private System.Windows.Forms.CheckBox SumCheckBox;
        private System.Windows.Forms.CheckBox DataCheckBox;
        private System.Windows.Forms.CheckBox AddressCheckBox;
        private System.Windows.Forms.CheckBox NameCheckBox;
    }
}

