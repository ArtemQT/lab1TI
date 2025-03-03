namespace lab1TI
{
    partial class CipherForm
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
            this.ColumnButton = new System.Windows.Forms.Button();
            this.VigenerButton = new System.Windows.Forms.Button();
            this.MethodChoiceLabel = new System.Windows.Forms.Label();
            this.CurrentCipherLabel = new System.Windows.Forms.Label();
            this.EnterKeylabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EntrytextBox = new System.Windows.Forms.TextBox();
            this.ReadFromFilebutton = new System.Windows.Forms.Button();
            this.KeytextBox = new System.Windows.Forms.TextBox();
            this.CipheredtextBox = new System.Windows.Forms.TextBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.Encryptionbutton = new System.Windows.Forms.Button();
            this.WriteToFilebutton = new System.Windows.Forms.Button();
            this.Decryptionbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColumnButton
            // 
            this.ColumnButton.BackColor = System.Drawing.SystemColors.Control;
            this.ColumnButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnButton.Location = new System.Drawing.Point(25, 76);
            this.ColumnButton.Name = "ColumnButton";
            this.ColumnButton.Size = new System.Drawing.Size(339, 60);
            this.ColumnButton.TabIndex = 0;
            this.ColumnButton.Text = "Столбцовый улучшенный метод";
            this.ColumnButton.UseVisualStyleBackColor = false;
            this.ColumnButton.Click += new System.EventHandler(this.ColumnButton_Click);
            // 
            // VigenerButton
            // 
            this.VigenerButton.BackColor = System.Drawing.SystemColors.Control;
            this.VigenerButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VigenerButton.Location = new System.Drawing.Point(25, 155);
            this.VigenerButton.Name = "VigenerButton";
            this.VigenerButton.Size = new System.Drawing.Size(339, 60);
            this.VigenerButton.TabIndex = 1;
            this.VigenerButton.Text = "Виженер,самогенерирующийся ключ";
            this.VigenerButton.UseVisualStyleBackColor = false;
            this.VigenerButton.Click += new System.EventHandler(this.VigenerButton_Click);
            // 
            // MethodChoiceLabel
            // 
            this.MethodChoiceLabel.AutoSize = true;
            this.MethodChoiceLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodChoiceLabel.Location = new System.Drawing.Point(82, 30);
            this.MethodChoiceLabel.Name = "MethodChoiceLabel";
            this.MethodChoiceLabel.Size = new System.Drawing.Size(218, 31);
            this.MethodChoiceLabel.TabIndex = 2;
            this.MethodChoiceLabel.Text = "Выбор метода";
            // 
            // CurrentCipherLabel
            // 
            this.CurrentCipherLabel.AutoSize = true;
            this.CurrentCipherLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentCipherLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentCipherLabel.Location = new System.Drawing.Point(435, 181);
            this.CurrentCipherLabel.Name = "CurrentCipherLabel";
            this.CurrentCipherLabel.Size = new System.Drawing.Size(501, 34);
            this.CurrentCipherLabel.TabIndex = 3;
            this.CurrentCipherLabel.Text = "Столбцовый улучшенный метод";
            // 
            // EnterKeylabel
            // 
            this.EnterKeylabel.AutoSize = true;
            this.EnterKeylabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EnterKeylabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterKeylabel.Location = new System.Drawing.Point(110, 384);
            this.EnterKeylabel.Name = "EnterKeylabel";
            this.EnterKeylabel.Size = new System.Drawing.Size(135, 22);
            this.EnterKeylabel.TabIndex = 4;
            this.EnterKeylabel.Text = "Введите ключ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите исходный текст:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Конечный текст:";
            // 
            // EntrytextBox
            // 
            this.EntrytextBox.Location = new System.Drawing.Point(251, 327);
            this.EntrytextBox.Multiline = true;
            this.EntrytextBox.Name = "EntrytextBox";
            this.EntrytextBox.Size = new System.Drawing.Size(685, 35);
            this.EntrytextBox.TabIndex = 7;
            // 
            // ReadFromFilebutton
            // 
            this.ReadFromFilebutton.BackColor = System.Drawing.SystemColors.Window;
            this.ReadFromFilebutton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFromFilebutton.Location = new System.Drawing.Point(947, 327);
            this.ReadFromFilebutton.Name = "ReadFromFilebutton";
            this.ReadFromFilebutton.Size = new System.Drawing.Size(105, 35);
            this.ReadFromFilebutton.TabIndex = 8;
            this.ReadFromFilebutton.Text = "из файла";
            this.ReadFromFilebutton.UseVisualStyleBackColor = false;
            this.ReadFromFilebutton.Click += new System.EventHandler(this.ReadFromFilebutton_Click);
            // 
            // KeytextBox
            // 
            this.KeytextBox.Location = new System.Drawing.Point(251, 384);
            this.KeytextBox.Multiline = true;
            this.KeytextBox.Name = "KeytextBox";
            this.KeytextBox.Size = new System.Drawing.Size(685, 35);
            this.KeytextBox.TabIndex = 9;
            // 
            // CipheredtextBox
            // 
            this.CipheredtextBox.Enabled = false;
            this.CipheredtextBox.Location = new System.Drawing.Point(251, 432);
            this.CipheredtextBox.Multiline = true;
            this.CipheredtextBox.Name = "CipheredtextBox";
            this.CipheredtextBox.Size = new System.Drawing.Size(685, 35);
            this.CipheredtextBox.TabIndex = 10;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LanguageLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LanguageLabel.Location = new System.Drawing.Point(613, 225);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(88, 19);
            this.LanguageLabel.TabIndex = 11;
            this.LanguageLabel.Text = "Язык: Англ";
            // 
            // Encryptionbutton
            // 
            this.Encryptionbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Encryptionbutton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encryptionbutton.Location = new System.Drawing.Point(41, 530);
            this.Encryptionbutton.Name = "Encryptionbutton";
            this.Encryptionbutton.Size = new System.Drawing.Size(449, 41);
            this.Encryptionbutton.TabIndex = 12;
            this.Encryptionbutton.Text = "Шифрование";
            this.Encryptionbutton.UseVisualStyleBackColor = false;
            this.Encryptionbutton.Click += new System.EventHandler(this.Encryptionbutton_Click);
            // 
            // WriteToFilebutton
            // 
            this.WriteToFilebutton.BackColor = System.Drawing.SystemColors.Window;
            this.WriteToFilebutton.Enabled = false;
            this.WriteToFilebutton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteToFilebutton.Location = new System.Drawing.Point(947, 432);
            this.WriteToFilebutton.Name = "WriteToFilebutton";
            this.WriteToFilebutton.Size = new System.Drawing.Size(105, 35);
            this.WriteToFilebutton.TabIndex = 13;
            this.WriteToFilebutton.Text = "в файл";
            this.WriteToFilebutton.UseVisualStyleBackColor = false;
            this.WriteToFilebutton.Click += new System.EventHandler(this.WriteToFilebutton_Click);
            // 
            // Decryptionbutton
            // 
            this.Decryptionbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Decryptionbutton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decryptionbutton.Location = new System.Drawing.Point(582, 530);
            this.Decryptionbutton.Name = "Decryptionbutton";
            this.Decryptionbutton.Size = new System.Drawing.Size(449, 41);
            this.Decryptionbutton.TabIndex = 14;
            this.Decryptionbutton.Text = "Дешифрование";
            this.Decryptionbutton.UseVisualStyleBackColor = false;
            this.Decryptionbutton.Click += new System.EventHandler(this.Decryptionbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(415, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Очистить поля ввода";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Decryptionbutton);
            this.Controls.Add(this.WriteToFilebutton);
            this.Controls.Add(this.Encryptionbutton);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.CipheredtextBox);
            this.Controls.Add(this.KeytextBox);
            this.Controls.Add(this.ReadFromFilebutton);
            this.Controls.Add(this.EntrytextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterKeylabel);
            this.Controls.Add(this.CurrentCipherLabel);
            this.Controls.Add(this.MethodChoiceLabel);
            this.Controls.Add(this.VigenerButton);
            this.Controls.Add(this.ColumnButton);
            this.Name = "CipherForm";
            this.Text = "Шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ColumnButton;
        private System.Windows.Forms.Button VigenerButton;
        private System.Windows.Forms.Label MethodChoiceLabel;
        private System.Windows.Forms.Label CurrentCipherLabel;
        private System.Windows.Forms.Label EnterKeylabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EntrytextBox;
        private System.Windows.Forms.Button ReadFromFilebutton;
        private System.Windows.Forms.TextBox KeytextBox;
        private System.Windows.Forms.TextBox CipheredtextBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Button Encryptionbutton;
        private System.Windows.Forms.Button WriteToFilebutton;
        private System.Windows.Forms.Button Decryptionbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

