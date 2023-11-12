namespace wardrobe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 26);
            label1.TabIndex = 0;
            label1.Text = "*Тип одежды";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 179);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 26);
            label2.TabIndex = 1;
            label2.Text = "*Стиль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 250);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 26);
            label3.TabIndex = 2;
            label3.Text = "*Цвет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 328);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 26);
            label4.TabIndex = 3;
            label4.Text = "*Сезон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 36);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(193, 26);
            label5.TabIndex = 4;
            label5.Text = "*Наименование одежды";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(474, 36);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 434);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 70);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 34);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textCanged;
            // 
            // button1
            // 
            button1.Location = new Point(324, 38);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 126);
            button1.TabIndex = 11;
            button1.Text = "*Загрузить фото";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addPhoto;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 168);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 26);
            label6.TabIndex = 13;
            label6.Text = "Дата покупки";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 359);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 34);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(252, 280);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 34);
            textBox3.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 328);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 26);
            label7.TabIndex = 16;
            label7.Text = "Место покупки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(265, 250);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 26);
            label8.TabIndex = 17;
            label8.Text = "Размер";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(252, 211);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 34);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.ValueChanged += dateChange;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(252, 433);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(189, 38);
            button2.TabIndex = 19;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += saveClothe;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(42, 139);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 34);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += selectedType;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(42, 209);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 34);
            comboBox2.TabIndex = 21;
            comboBox2.SelectedIndexChanged += selectedStyle;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(42, 283);
            comboBox3.Margin = new Padding(4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(188, 34);
            comboBox3.TabIndex = 22;
            comboBox3.SelectedIndexChanged += selecteColor;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(42, 358);
            comboBox4.Margin = new Padding(4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(188, 34);
            comboBox4.TabIndex = 23;
            comboBox4.SelectedIndexChanged += selecteSeason;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(42, 433);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(189, 38);
            button3.TabIndex = 25;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(860, 433);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(36, 38);
            button4.TabIndex = 26;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(932, 511);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление одежды";
            FormClosed += Form2_FormClosed;
            Load += LoadForm2;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button3;
        private Button button4;
    }
}