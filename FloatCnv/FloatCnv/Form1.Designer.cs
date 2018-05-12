namespace FloatCnv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textResult = new System.Windows.Forms.TextBox();
            this.textFloatToConvert = new System.Windows.Forms.TextBox();
            this.textHexToCnv1 = new System.Windows.Forms.TextBox();
            this.textFloat = new System.Windows.Forms.TextBox();
            this.textHexToCnv2 = new System.Windows.Forms.TextBox();
            this.textHexToCnv3 = new System.Windows.Forms.TextBox();
            this.textHexToCnv4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textHex1 = new System.Windows.Forms.TextBox();
            this.textHex2 = new System.Windows.Forms.TextBox();
            this.textHex3 = new System.Windows.Forms.TextBox();
            this.textHex4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(269, 28);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(306, 20);
            this.textResult.TabIndex = 0;
            // 
            // textFloatToConvert
            // 
            this.textFloatToConvert.Location = new System.Drawing.Point(31, 28);
            this.textFloatToConvert.Name = "textFloatToConvert";
            this.textFloatToConvert.Size = new System.Drawing.Size(151, 20);
            this.textFloatToConvert.TabIndex = 1;
            // 
            // textHexToCnv1
            // 
            this.textHexToCnv1.Location = new System.Drawing.Point(31, 116);
            this.textHexToCnv1.Name = "textHexToCnv1";
            this.textHexToCnv1.Size = new System.Drawing.Size(72, 20);
            this.textHexToCnv1.TabIndex = 3;
            // 
            // textFloat
            // 
            this.textFloat.Location = new System.Drawing.Point(28, 171);
            this.textFloat.Name = "textFloat";
            this.textFloat.Size = new System.Drawing.Size(228, 20);
            this.textFloat.TabIndex = 2;
            // 
            // textHexToCnv2
            // 
            this.textHexToCnv2.Location = new System.Drawing.Point(127, 116);
            this.textHexToCnv2.Name = "textHexToCnv2";
            this.textHexToCnv2.Size = new System.Drawing.Size(72, 20);
            this.textHexToCnv2.TabIndex = 4;
            // 
            // textHexToCnv3
            // 
            this.textHexToCnv3.Location = new System.Drawing.Point(228, 116);
            this.textHexToCnv3.Name = "textHexToCnv3";
            this.textHexToCnv3.Size = new System.Drawing.Size(72, 20);
            this.textHexToCnv3.TabIndex = 5;
            // 
            // textHexToCnv4
            // 
            this.textHexToCnv4.Location = new System.Drawing.Point(325, 116);
            this.textHexToCnv4.Name = "textHexToCnv4";
            this.textHexToCnv4.Size = new System.Drawing.Size(72, 20);
            this.textHexToCnv4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "►►";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "▼▼";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textHex1
            // 
            this.textHex1.Location = new System.Drawing.Point(269, 54);
            this.textHex1.Name = "textHex1";
            this.textHex1.Size = new System.Drawing.Size(72, 20);
            this.textHex1.TabIndex = 3;
            // 
            // textHex2
            // 
            this.textHex2.Location = new System.Drawing.Point(347, 54);
            this.textHex2.Name = "textHex2";
            this.textHex2.Size = new System.Drawing.Size(72, 20);
            this.textHex2.TabIndex = 4;
            // 
            // textHex3
            // 
            this.textHex3.Location = new System.Drawing.Point(425, 54);
            this.textHex3.Name = "textHex3";
            this.textHex3.Size = new System.Drawing.Size(72, 20);
            this.textHex3.TabIndex = 5;
            // 
            // textHex4
            // 
            this.textHex4.Location = new System.Drawing.Point(503, 54);
            this.textHex4.Name = "textHex4";
            this.textHex4.Size = new System.Drawing.Size(72, 20);
            this.textHex4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textHex4);
            this.Controls.Add(this.textHexToCnv4);
            this.Controls.Add(this.textHex3);
            this.Controls.Add(this.textHex2);
            this.Controls.Add(this.textHexToCnv3);
            this.Controls.Add(this.textHex1);
            this.Controls.Add(this.textHexToCnv2);
            this.Controls.Add(this.textHexToCnv1);
            this.Controls.Add(this.textFloat);
            this.Controls.Add(this.textFloatToConvert);
            this.Controls.Add(this.textResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преобразование float -> bytes и обратно";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textFloatToConvert;
        private System.Windows.Forms.TextBox textHexToCnv1;
        private System.Windows.Forms.TextBox textFloat;
        private System.Windows.Forms.TextBox textHexToCnv2;
        private System.Windows.Forms.TextBox textHexToCnv3;
        private System.Windows.Forms.TextBox textHexToCnv4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textHex1;
        private System.Windows.Forms.TextBox textHex2;
        private System.Windows.Forms.TextBox textHex3;
        private System.Windows.Forms.TextBox textHex4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

