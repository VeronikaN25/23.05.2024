namespace _23._05._2024
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(29, 45);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(190, 29);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Введите сумму";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmount.Location = new System.Drawing.Point(274, 40);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(121, 34);
            this.textBoxAmount.TabIndex = 1;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "KZT"});
            this.comboBoxFrom.Location = new System.Drawing.Point(274, 103);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 37);
            this.comboBoxFrom.TabIndex = 3;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "KZT"});
            this.comboBoxTo.Location = new System.Drawing.Point(274, 164);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 37);
            this.comboBoxTo.TabIndex = 4;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConvert.Location = new System.Drawing.Point(34, 228);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(272, 47);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Конвертировать";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(358, 237);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 29);
            this.labelResult.TabIndex = 6;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Исходная валюта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Целевая валюта:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}