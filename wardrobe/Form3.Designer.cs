namespace wardrobe
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
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
            buttonDelete = new Button();
            buttonEdit = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(21, 34);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(333, 47);
            textBoxName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(382, 12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxStyle
            // 
            textBoxStyle.Enabled = false;
            textBoxStyle.Location = new Point(83, 85);
            textBoxStyle.Margin = new Padding(3, 2, 3, 2);
            textBoxStyle.Name = "textBoxStyle";
            textBoxStyle.Size = new Size(271, 27);
            textBoxStyle.TabIndex = 2;
            // 
            // textBoxColor
            // 
            textBoxColor.Enabled = false;
            textBoxColor.Location = new Point(83, 118);
            textBoxColor.Margin = new Padding(3, 2, 3, 2);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(271, 27);
            textBoxColor.TabIndex = 3;
            // 
            // textBoxSeason
            // 
            textBoxSeason.Enabled = false;
            textBoxSeason.Location = new Point(83, 149);
            textBoxSeason.Margin = new Padding(3, 2, 3, 2);
            textBoxSeason.Name = "textBoxSeason";
            textBoxSeason.Size = new Size(271, 27);
            textBoxSeason.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(141, 299);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(213, 54);
            button1.TabIndex = 5;
            button1.Text = "Добвить в комплект";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddToComplectBox;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 87);
            label1.Name = "label1";
            label1.Size = new Size(63, 26);
            label1.TabIndex = 6;
            label1.Text = "Стиль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 120);
            label2.Name = "label2";
            label2.Size = new Size(56, 26);
            label2.TabIndex = 7;
            label2.Text = "Цвет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 153);
            label3.Name = "label3";
            label3.Size = new Size(54, 26);
            label3.TabIndex = 8;
            label3.Text = "Сезон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 186);
            label4.Name = "label4";
            label4.Size = new Size(59, 26);
            label4.TabIndex = 10;
            label4.Text = "Дата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 219);
            label5.Name = "label5";
            label5.Size = new Size(77, 26);
            label5.TabIndex = 11;
            label5.Text = "Магазин";
            // 
            // textBoxPlace
            // 
            textBoxPlace.Enabled = false;
            textBoxPlace.Location = new Point(99, 215);
            textBoxPlace.Margin = new Padding(3, 2, 3, 2);
            textBoxPlace.Name = "textBoxPlace";
            textBoxPlace.Size = new Size(255, 27);
            textBoxPlace.TabIndex = 12;
            // 
            // textBoxSize
            // 
            textBoxSize.Enabled = false;
            textBoxSize.Location = new Point(187, 248);
            textBoxSize.Margin = new Padding(3, 2, 3, 2);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(167, 27);
            textBoxSize.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 248);
            label6.Name = "label6";
            label6.Size = new Size(70, 26);
            label6.TabIndex = 14;
            label6.Text = "Размер";
            // 
            // textBoxDate
            // 
            textBoxDate.Enabled = false;
            textBoxDate.Location = new Point(187, 182);
            textBoxDate.Margin = new Padding(3, 2, 3, 2);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(167, 27);
            textBoxDate.TabIndex = 15;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Info;
            buttonDelete.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(16, 373);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(103, 39);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += delete;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.Info;
            buttonEdit.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Location = new Point(141, 373);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(213, 42);
            buttonEdit.TabIndex = 17;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += edit_item;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(16, 299);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(103, 54);
            button2.TabIndex = 18;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Cancel;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources._100;
            button3.Location = new Point(760, 387);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(27, 28);
            button3.TabIndex = 19;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 8);
            label7.Name = "label7";
            label7.Size = new Size(123, 26);
            label7.TabIndex = 20;
            label7.Text = "Наименование";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(811, 446);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
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
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form3";
            Text = "Предмет одежды";
            FormClosed += Form3_FormClosed;
            Load += LoadFm3;
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
        private Button buttonDelete;
        private Button buttonEdit;
        private Button button2;
        private Button button3;
        private Label label7;
    }
}