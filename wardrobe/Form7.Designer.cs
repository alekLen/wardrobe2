namespace wardrobe
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            textBoxName = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxStyle = new TextBox();
            textBoxColor = new TextBox();
            textBoxSeason = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxPlace = new TextBox();
            textBoxSize = new TextBox();
            label6 = new Label();
            textBoxDate = new TextBox();
            button2 = new Button();
            button3Photo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(21, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(333, 47);
            textBoxName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(382, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxStyle
            // 
            textBoxStyle.Enabled = false;
            textBoxStyle.Location = new Point(83, 65);
            textBoxStyle.Name = "textBoxStyle";
            textBoxStyle.Size = new Size(271, 27);
            textBoxStyle.TabIndex = 2;
            // 
            // textBoxColor
            // 
            textBoxColor.Enabled = false;
            textBoxColor.Location = new Point(83, 99);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(271, 27);
            textBoxColor.TabIndex = 3;
            // 
            // textBoxSeason
            // 
            textBoxSeason.Enabled = false;
            textBoxSeason.Location = new Point(83, 132);
            textBoxSeason.Name = "textBoxSeason";
            textBoxSeason.Size = new Size(271, 27);
            textBoxSeason.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(139, 292);
            button1.Name = "button1";
            button1.Size = new Size(215, 50);
            button1.TabIndex = 5;
            button1.Text = "добвить в комплект";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 68);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 6;
            label1.Text = "стиль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 102);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "цвет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 139);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "сезон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 168);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 10;
            label4.Text = "дата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 201);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 11;
            label5.Text = "магазин";
            // 
            // textBoxPlace
            // 
            textBoxPlace.Enabled = false;
            textBoxPlace.Location = new Point(83, 198);
            textBoxPlace.Name = "textBoxPlace";
            textBoxPlace.Size = new Size(271, 27);
            textBoxPlace.TabIndex = 12;
            // 
            // textBoxSize
            // 
            textBoxSize.Enabled = false;
            textBoxSize.Location = new Point(229, 231);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(125, 27);
            textBoxSize.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 234);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 14;
            label6.Text = "размер";
            // 
            // textBoxDate
            // 
            textBoxDate.Enabled = false;
            textBoxDate.Location = new Point(187, 165);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(167, 27);
            textBoxDate.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(16, 292);
            button2.Name = "button2";
            button2.Size = new Size(108, 50);
            button2.TabIndex = 18;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Cancel;
            // 
            // button3Photo
            // 
            button3Photo.BackColor = SystemColors.Info;
            button3Photo.Location = new Point(83, 234);
            button3Photo.Name = "button3Photo";
            button3Photo.Size = new Size(140, 52);
            button3Photo.TabIndex = 19;
            button3Photo.Text = "button3";
            button3Photo.UseVisualStyleBackColor = false;
            button3Photo.Visible = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 365);
            Controls.Add(button3Photo);
            Controls.Add(button2);
            Controls.Add(textBoxDate);
            Controls.Add(label6);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxPlace);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxSeason);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxStyle);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form7";
            Text = "Предмет одежды";
            TopMost = true;
            FormClosed += Form7_FormClosed;
            Load += LoadFm7;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private PictureBox pictureBox1;
        private TextBox textBoxStyle;
        private TextBox textBoxColor;
        private TextBox textBoxSeason;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxPlace;
        private TextBox textBoxSize;
        private Label label6;
        private TextBox textBoxDate;
        private Button button2;
        private Button button3Photo;
    }
}