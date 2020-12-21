namespace Lab4v2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonEnc = new System.Windows.Forms.Button();
            this.ButtonDec = new System.Windows.Forms.Button();
            this.EncSource = new System.Windows.Forms.TextBox();
            this.EncOutput = new System.Windows.Forms.TextBox();
            this.SourceOutput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DecNText = new System.Windows.Forms.TextBox();
            this.DecKcText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EncNText = new System.Windows.Forms.TextBox();
            this.EncKoText = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pInput = new System.Windows.Forms.TextBox();
            this.qInput = new System.Windows.Forms.TextBox();
            this.nOutput = new System.Windows.Forms.TextBox();
            this.fOutput = new System.Windows.Forms.TextBox();
            this.kcOutput = new System.Windows.Forms.TextBox();
            this.koOutput = new System.Windows.Forms.TextBox();
            this.generateKeysButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SourceInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEnc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDec, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.EncSource, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EncOutput, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SourceOutput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 642);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(432, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зашифрованный";
            // 
            // SourceInput
            // 
            this.SourceInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceInput.Location = new System.Drawing.Point(3, 63);
            this.SourceInput.Multiline = true;
            this.SourceInput.Name = "SourceInput";
            this.SourceInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SourceInput.Size = new System.Drawing.Size(423, 195);
            this.SourceInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зашифрованный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(432, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дешифрованный";
            // 
            // ButtonEnc
            // 
            this.ButtonEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEnc.Location = new System.Drawing.Point(3, 585);
            this.ButtonEnc.Name = "ButtonEnc";
            this.ButtonEnc.Size = new System.Drawing.Size(423, 54);
            this.ButtonEnc.TabIndex = 8;
            this.ButtonEnc.Text = "Зашифровать";
            this.ButtonEnc.UseVisualStyleBackColor = true;
            this.ButtonEnc.Click += new System.EventHandler(this.ButtonEnc_Click);
            // 
            // ButtonDec
            // 
            this.ButtonDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDec.Location = new System.Drawing.Point(432, 585);
            this.ButtonDec.Name = "ButtonDec";
            this.ButtonDec.Size = new System.Drawing.Size(424, 54);
            this.ButtonDec.TabIndex = 9;
            this.ButtonDec.Text = "Дешифровать";
            this.ButtonDec.UseVisualStyleBackColor = true;
            this.ButtonDec.Click += new System.EventHandler(this.ButtonDec_Click);
            // 
            // EncSource
            // 
            this.EncSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncSource.Location = new System.Drawing.Point(432, 63);
            this.EncSource.Multiline = true;
            this.EncSource.Name = "EncSource";
            this.EncSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EncSource.Size = new System.Drawing.Size(424, 195);
            this.EncSource.TabIndex = 10;
            // 
            // EncOutput
            // 
            this.EncOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncOutput.Location = new System.Drawing.Point(3, 384);
            this.EncOutput.Multiline = true;
            this.EncOutput.Name = "EncOutput";
            this.EncOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EncOutput.Size = new System.Drawing.Size(423, 195);
            this.EncOutput.TabIndex = 11;
            // 
            // SourceOutput
            // 
            this.SourceOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceOutput.Location = new System.Drawing.Point(432, 384);
            this.SourceOutput.Multiline = true;
            this.SourceOutput.Name = "SourceOutput";
            this.SourceOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SourceOutput.Size = new System.Drawing.Size(424, 195);
            this.SourceOutput.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.DecNText, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DecKcText, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(432, 264);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(424, 54);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 54);
            this.label7.TabIndex = 0;
            this.label7.Text = "N:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 54);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ko:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DecNText
            // 
            this.DecNText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecNText.Location = new System.Drawing.Point(109, 3);
            this.DecNText.Name = "DecNText";
            this.DecNText.Size = new System.Drawing.Size(100, 62);
            this.DecNText.TabIndex = 2;
            // 
            // DecKcText
            // 
            this.DecKcText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecKcText.Location = new System.Drawing.Point(321, 3);
            this.DecKcText.Name = "DecKcText";
            this.DecKcText.Size = new System.Drawing.Size(100, 62);
            this.DecKcText.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.EncNText, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.EncKoText, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 264);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(423, 54);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 54);
            this.label5.TabIndex = 0;
            this.label5.Text = "N:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 54);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kc:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EncNText
            // 
            this.EncNText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncNText.Location = new System.Drawing.Point(108, 3);
            this.EncNText.Name = "EncNText";
            this.EncNText.Size = new System.Drawing.Size(99, 62);
            this.EncNText.TabIndex = 2;
            // 
            // EncKoText
            // 
            this.EncKoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncKoText.Location = new System.Drawing.Point(318, 3);
            this.EncKoText.Name = "EncKoText";
            this.EncKoText.Size = new System.Drawing.Size(102, 62);
            this.EncKoText.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(3, 384);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(423, 195);
            this.textBox3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.pInput, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.qInput, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.nOutput, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.fOutput, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.kcOutput, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.koOutput, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.generateKeysButton, 1, 6);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(863, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(402, 639);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 65);
            this.label9.TabIndex = 0;
            this.label9.Text = "p:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 65);
            this.label10.TabIndex = 1;
            this.label10.Text = "q:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 65);
            this.label11.TabIndex = 2;
            this.label11.Text = "N:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 65);
            this.label12.TabIndex = 3;
            this.label12.Text = "φ:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 65);
            this.label13.TabIndex = 4;
            this.label13.Text = "Kc:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 65);
            this.label14.TabIndex = 5;
            this.label14.Text = "Ko:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pInput
            // 
            this.pInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInput.Location = new System.Drawing.Point(137, 3);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(262, 62);
            this.pInput.TabIndex = 7;
            // 
            // qInput
            // 
            this.qInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qInput.Location = new System.Drawing.Point(137, 68);
            this.qInput.Name = "qInput";
            this.qInput.Size = new System.Drawing.Size(262, 62);
            this.qInput.TabIndex = 8;
            // 
            // nOutput
            // 
            this.nOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nOutput.Location = new System.Drawing.Point(137, 133);
            this.nOutput.Name = "nOutput";
            this.nOutput.Size = new System.Drawing.Size(262, 62);
            this.nOutput.TabIndex = 9;
            // 
            // fOutput
            // 
            this.fOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fOutput.Location = new System.Drawing.Point(137, 198);
            this.fOutput.Name = "fOutput";
            this.fOutput.Size = new System.Drawing.Size(262, 62);
            this.fOutput.TabIndex = 10;
            // 
            // kcOutput
            // 
            this.kcOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kcOutput.Location = new System.Drawing.Point(137, 263);
            this.kcOutput.Name = "kcOutput";
            this.kcOutput.Size = new System.Drawing.Size(262, 62);
            this.kcOutput.TabIndex = 11;
            // 
            // koOutput
            // 
            this.koOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.koOutput.Location = new System.Drawing.Point(137, 328);
            this.koOutput.Name = "koOutput";
            this.koOutput.Size = new System.Drawing.Size(262, 62);
            this.koOutput.TabIndex = 12;
            // 
            // generateKeysButton
            // 
            this.generateKeysButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateKeysButton.Location = new System.Drawing.Point(137, 393);
            this.generateKeysButton.Name = "generateKeysButton";
            this.generateKeysButton.Size = new System.Drawing.Size(262, 59);
            this.generateKeysButton.TabIndex = 13;
            this.generateKeysButton.Text = "Создать";
            this.generateKeysButton.UseVisualStyleBackColor = true;
            this.generateKeysButton.Click += new System.EventHandler(this.generateKeysButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Name = "Form1";
            this.Text = "Lab4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceInput;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonEnc;
        private System.Windows.Forms.Button ButtonDec;
        private System.Windows.Forms.TextBox EncSource;
        private System.Windows.Forms.TextBox EncOutput;
        private System.Windows.Forms.TextBox SourceOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DecNText;
        private System.Windows.Forms.TextBox DecKcText;
        private System.Windows.Forms.TextBox EncNText;
        private System.Windows.Forms.TextBox EncKoText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pInput;
        private System.Windows.Forms.TextBox qInput;
        private System.Windows.Forms.TextBox nOutput;
        private System.Windows.Forms.TextBox fOutput;
        private System.Windows.Forms.TextBox kcOutput;
        private System.Windows.Forms.TextBox koOutput;
        private System.Windows.Forms.Button generateKeysButton;
    }
}

