namespace TI1
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
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxSK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEnc = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDec = new System.Windows.Forms.TextBox();
            this.textBoxDK = new System.Windows.Forms.TextBox();
            this.textBoxDM = new System.Windows.Forms.TextBox();
            this.textBoxEncSource = new System.Windows.Forms.TextBox();
            this.textBoxEnc = new System.Windows.Forms.TextBox();
            this.textBoxSM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSource.Location = new System.Drawing.Point(19, 51);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSource.Size = new System.Drawing.Size(735, 355);
            this.textBoxSource.TabIndex = 0;
            // 
            // textBoxSK
            // 
            this.textBoxSK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSK.Location = new System.Drawing.Point(373, 412);
            this.textBoxSK.Name = "textBoxSK";
            this.textBoxSK.Size = new System.Drawing.Size(231, 45);
            this.textBoxSK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Исходный текст:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "M:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Зашифрованный текст:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(309, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "K: ";
            // 
            // buttonEnc
            // 
            this.buttonEnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnc.Location = new System.Drawing.Point(19, 882);
            this.buttonEnc.Name = "buttonEnc";
            this.buttonEnc.Size = new System.Drawing.Size(735, 46);
            this.buttonEnc.TabIndex = 12;
            this.buttonEnc.Text = "Зашифровать";
            this.buttonEnc.UseVisualStyleBackColor = true;
            this.buttonEnc.Click += new System.EventHandler(this.buttonEnc_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDec.Location = new System.Drawing.Point(760, 882);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(767, 46);
            this.buttonDec.TabIndex = 21;
            this.buttonDec.Text = "Расшифровать";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(753, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "Расшифрованный текст:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1057, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 39);
            this.label6.TabIndex = 19;
            this.label6.Text = "K: ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(760, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "M:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(760, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(391, 39);
            this.label8.TabIndex = 17;
            this.label8.Text = "Зашифрованный текст:";
            // 
            // textBoxDec
            // 
            this.textBoxDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDec.Location = new System.Drawing.Point(760, 502);
            this.textBoxDec.Multiline = true;
            this.textBoxDec.Name = "textBoxDec";
            this.textBoxDec.ReadOnly = true;
            this.textBoxDec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDec.Size = new System.Drawing.Size(767, 374);
            this.textBoxDec.TabIndex = 16;
            // 
            // textBoxDK
            // 
            this.textBoxDK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDK.Location = new System.Drawing.Point(1121, 412);
            this.textBoxDK.Name = "textBoxDK";
            this.textBoxDK.Size = new System.Drawing.Size(231, 45);
            this.textBoxDK.TabIndex = 15;
            // 
            // textBoxDM
            // 
            this.textBoxDM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDM.Location = new System.Drawing.Point(820, 412);
            this.textBoxDM.Name = "textBoxDM";
            this.textBoxDM.Size = new System.Drawing.Size(231, 45);
            this.textBoxDM.TabIndex = 14;
            // 
            // textBoxEncSource
            // 
            this.textBoxEncSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEncSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEncSource.Location = new System.Drawing.Point(760, 51);
            this.textBoxEncSource.Multiline = true;
            this.textBoxEncSource.Name = "textBoxEncSource";
            this.textBoxEncSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEncSource.Size = new System.Drawing.Size(767, 355);
            this.textBoxEncSource.TabIndex = 13;
            // 
            // textBoxEnc
            // 
            this.textBoxEnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnc.Location = new System.Drawing.Point(19, 502);
            this.textBoxEnc.Multiline = true;
            this.textBoxEnc.Name = "textBoxEnc";
            this.textBoxEnc.ReadOnly = true;
            this.textBoxEnc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEnc.Size = new System.Drawing.Size(735, 374);
            this.textBoxEnc.TabIndex = 22;
            // 
            // textBoxSM
            // 
            this.textBoxSM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSM.Location = new System.Drawing.Point(72, 412);
            this.textBoxSM.Name = "textBoxSM";
            this.textBoxSM.Size = new System.Drawing.Size(231, 45);
            this.textBoxSM.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 941);
            this.Controls.Add(this.textBoxSM);
            this.Controls.Add(this.textBoxEnc);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDec);
            this.Controls.Add(this.textBoxDK);
            this.Controls.Add(this.textBoxDM);
            this.Controls.Add(this.textBoxEncSource);
            this.Controls.Add(this.buttonEnc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSK);
            this.Controls.Add(this.textBoxSource);
            this.MinimumSize = new System.Drawing.Size(1560, 980);
            this.Name = "Form1";
            this.Text = "Lab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxSK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEnc;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDec;
        private System.Windows.Forms.TextBox textBoxDK;
        private System.Windows.Forms.TextBox textBoxDM;
        private System.Windows.Forms.TextBox textBoxEncSource;
        private System.Windows.Forms.TextBox textBoxEnc;
        private System.Windows.Forms.TextBox textBoxSM;
    }
}

