namespace wardrobe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem2 = new ToolStripMenuItem();
            editStyleToolStripMenuItem = new ToolStripMenuItem();
            delStyleToolStripMenuItem4 = new ToolStripMenuItem();
            edStyleToolStripMenuItem3 = new ToolStripMenuItem();
            addStyleToolStripMenuItem4 = new ToolStripMenuItem();
            editColorToolStripMenuItem = new ToolStripMenuItem();
            deColorToolStripMenuItem5 = new ToolStripMenuItem();
            edColorToolStripMenuItem4 = new ToolStripMenuItem();
            addColorToolStripMenuItem5 = new ToolStripMenuItem();
            editSeasonoolStripMenuItem = new ToolStripMenuItem();
            delSeasonToolStripMenuItem6 = new ToolStripMenuItem();
            edSeasonToolStripMenuItem5 = new ToolStripMenuItem();
            addSeasonToolStripMenuItem6 = new ToolStripMenuItem();
            wardrobeToolStripMenuItem = new ToolStripMenuItem();
            addClotheToolStripMenuItem1 = new ToolStripMenuItem();
            complectsToolStripMenuItem = new ToolStripMenuItem();
            statisticToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            styleToolStripMenuItem = new ToolStripMenuItem();
            seasonToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            button6 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label4 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            listBox2 = new ListBox();
            FilterSeasonBox = new CheckedListBox();
            FilterColorBox = new CheckedListBox();
            FilterStyleBox = new CheckedListBox();
            listView5 = new ListView();
            listView6 = new ListView();
            listView7 = new ListView();
            listView8 = new ListView();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(227, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem2, wardrobeToolStripMenuItem, statisticToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1615, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem2
            // 
            editToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { editStyleToolStripMenuItem, editColorToolStripMenuItem, editSeasonoolStripMenuItem });
            editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            editToolStripMenuItem2.Size = new Size(125, 24);
            editToolStripMenuItem2.Text = "Редактировать";
            // 
            // editStyleToolStripMenuItem
            // 
            editStyleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { delStyleToolStripMenuItem4, edStyleToolStripMenuItem3, addStyleToolStripMenuItem4 });
            editStyleToolStripMenuItem.Name = "editStyleToolStripMenuItem";
            editStyleToolStripMenuItem.Size = new Size(134, 26);
            editStyleToolStripMenuItem.Text = "Стиль";
            // 
            // delStyleToolStripMenuItem4
            // 
            delStyleToolStripMenuItem4.Name = "delStyleToolStripMenuItem4";
            delStyleToolStripMenuItem4.Size = new Size(161, 26);
            delStyleToolStripMenuItem4.Text = "Удалить";
            delStyleToolStripMenuItem4.Click += delStyle;
            // 
            // edStyleToolStripMenuItem3
            // 
            edStyleToolStripMenuItem3.Name = "edStyleToolStripMenuItem3";
            edStyleToolStripMenuItem3.Size = new Size(161, 26);
            edStyleToolStripMenuItem3.Text = "Изменить";
            edStyleToolStripMenuItem3.Click += editStyle;
            // 
            // addStyleToolStripMenuItem4
            // 
            addStyleToolStripMenuItem4.Name = "addStyleToolStripMenuItem4";
            addStyleToolStripMenuItem4.Size = new Size(161, 26);
            addStyleToolStripMenuItem4.Text = "Добавить";
            addStyleToolStripMenuItem4.Click += addStyle;
            // 
            // editColorToolStripMenuItem
            // 
            editColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deColorToolStripMenuItem5, edColorToolStripMenuItem4, addColorToolStripMenuItem5 });
            editColorToolStripMenuItem.Name = "editColorToolStripMenuItem";
            editColorToolStripMenuItem.Size = new Size(134, 26);
            editColorToolStripMenuItem.Text = "Цвет";
            // 
            // deColorToolStripMenuItem5
            // 
            deColorToolStripMenuItem5.Name = "deColorToolStripMenuItem5";
            deColorToolStripMenuItem5.Size = new Size(161, 26);
            deColorToolStripMenuItem5.Text = "Удалить";
            deColorToolStripMenuItem5.Click += delColor;
            // 
            // edColorToolStripMenuItem4
            // 
            edColorToolStripMenuItem4.Name = "edColorToolStripMenuItem4";
            edColorToolStripMenuItem4.Size = new Size(161, 26);
            edColorToolStripMenuItem4.Text = "Изменить";
            edColorToolStripMenuItem4.Click += editColor;
            // 
            // addColorToolStripMenuItem5
            // 
            addColorToolStripMenuItem5.Name = "addColorToolStripMenuItem5";
            addColorToolStripMenuItem5.Size = new Size(161, 26);
            addColorToolStripMenuItem5.Text = "Добавить";
            addColorToolStripMenuItem5.Click += addColor;
            // 
            // editSeasonoolStripMenuItem
            // 
            editSeasonoolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { delSeasonToolStripMenuItem6, edSeasonToolStripMenuItem5, addSeasonToolStripMenuItem6 });
            editSeasonoolStripMenuItem.Name = "editSeasonoolStripMenuItem";
            editSeasonoolStripMenuItem.Size = new Size(134, 26);
            editSeasonoolStripMenuItem.Text = "Сезон";
            // 
            // delSeasonToolStripMenuItem6
            // 
            delSeasonToolStripMenuItem6.Name = "delSeasonToolStripMenuItem6";
            delSeasonToolStripMenuItem6.Size = new Size(161, 26);
            delSeasonToolStripMenuItem6.Text = "Удалить";
            delSeasonToolStripMenuItem6.Click += delSeason;
            // 
            // edSeasonToolStripMenuItem5
            // 
            edSeasonToolStripMenuItem5.Name = "edSeasonToolStripMenuItem5";
            edSeasonToolStripMenuItem5.Size = new Size(161, 26);
            edSeasonToolStripMenuItem5.Text = "Изменить";
            edSeasonToolStripMenuItem5.Click += editSeason;
            // 
            // addSeasonToolStripMenuItem6
            // 
            addSeasonToolStripMenuItem6.Name = "addSeasonToolStripMenuItem6";
            addSeasonToolStripMenuItem6.Size = new Size(161, 26);
            addSeasonToolStripMenuItem6.Text = "Добавить";
            addSeasonToolStripMenuItem6.Click += addSeason;
            // 
            // wardrobeToolStripMenuItem
            // 
            wardrobeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addClotheToolStripMenuItem1, complectsToolStripMenuItem });
            wardrobeToolStripMenuItem.Name = "wardrobeToolStripMenuItem";
            wardrobeToolStripMenuItem.Size = new Size(90, 24);
            wardrobeToolStripMenuItem.Text = "Гардероб";
            // 
            // addClotheToolStripMenuItem1
            // 
            addClotheToolStripMenuItem1.Name = "addClotheToolStripMenuItem1";
            addClotheToolStripMenuItem1.Size = new Size(214, 26);
            addClotheToolStripMenuItem1.Text = "Добавить одежду";
            addClotheToolStripMenuItem1.Click += Add_Form;
            // 
            // complectsToolStripMenuItem
            // 
            complectsToolStripMenuItem.Name = "complectsToolStripMenuItem";
            complectsToolStripMenuItem.Size = new Size(214, 26);
            complectsToolStripMenuItem.Text = "Комплекты";
            complectsToolStripMenuItem.Click += See_Complects;
            // 
            // statisticToolStripMenuItem
            // 
            statisticToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, styleToolStripMenuItem, seasonToolStripMenuItem });
            statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            statisticToolStripMenuItem.Size = new Size(98, 24);
            statisticToolStripMenuItem.Text = "Статистика";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(195, 26);
            colorToolStripMenuItem.Text = "Цвет одежды";
            colorToolStripMenuItem.Click += color_statistic;
            // 
            // styleToolStripMenuItem
            // 
            styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            styleToolStripMenuItem.Size = new Size(195, 26);
            styleToolStripMenuItem.Text = "Стиль одежды";
            styleToolStripMenuItem.Click += style_statistic;
            // 
            // seasonToolStripMenuItem
            // 
            seasonToolStripMenuItem.Name = "seasonToolStripMenuItem";
            seasonToolStripMenuItem.Size = new Size(195, 26);
            seasonToolStripMenuItem.Text = "Сезон Одежды";
            seasonToolStripMenuItem.Click += season_statistic;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(342, 353);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(176, 64);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += selectUp;
            listBox1.DoubleClick += del_Choosen_Up;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(573, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(314, 272);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(922, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(314, 272);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(1270, 38);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(314, 272);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(1033, 351);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(180, 64);
            listBox3.TabIndex = 11;
            listBox3.SelectedIndexChanged += selectSuit;
            listBox3.DoubleClick += del_chosen_suit;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Location = new Point(1379, 348);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(182, 64);
            listBox4.TabIndex = 12;
            listBox4.SelectedIndexChanged += selectShoe;
            listBox4.DoubleClick += del_chosen_shoe;
            // 
            // button4
            // 
            button4.Location = new Point(31, 682);
            button4.Name = "button4";
            button4.Size = new Size(158, 51);
            button4.TabIndex = 20;
            button4.Text = "Добавить комплект";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Add_Complect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 84);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 22;
            label1.Text = "цвету";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 290);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 25;
            label2.Text = "Сезону";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 430);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 26;
            label3.Text = "стилю";
            // 
            // button5
            // 
            button5.Location = new Point(31, 631);
            button5.Name = "button5";
            button5.Size = new Size(158, 29);
            button5.TabIndex = 29;
            button5.Text = "Сбросить фильтр";
            button5.UseVisualStyleBackColor = true;
            button5.Click += clear_filter;
            // 
            // button6
            // 
            button6.Location = new Point(31, 596);
            button6.Name = "button6";
            button6.Size = new Size(158, 29);
            button6.TabIndex = 30;
            button6.Text = "Фильтровать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += filter_Start;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 313);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 34;
            label5.Text = "Верх";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(708, 313);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 35;
            label6.Text = "Низ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(999, 313);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 36;
            label7.Text = "Платье/Костюм";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1366, 313);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 37;
            label8.Text = "Обувь";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(461, 353);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(825, 351);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 39;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1174, 352);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1513, 351);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 64);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 42;
            label4.Text = "Фильтровать по:";
            label4.Click += label4_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(524, 355);
            label13.Name = "label13";
            label13.Size = new Size(17, 20);
            label13.TabIndex = 43;
            label13.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(870, 353);
            label14.Name = "label14";
            label14.Size = new Size(17, 20);
            label14.TabIndex = 44;
            label14.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1219, 348);
            label15.Name = "label15";
            label15.Size = new Size(17, 20);
            label15.TabIndex = 45;
            label15.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1567, 349);
            label16.Name = "label16";
            label16.Size = new Size(17, 20);
            label16.TabIndex = 46;
            label16.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(256, 348);
            label17.Name = "label17";
            label17.Size = new Size(80, 19);
            label17.TabIndex = 47;
            label17.Text = "в комплект";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(592, 348);
            label18.Name = "label18";
            label18.Size = new Size(80, 19);
            label18.TabIndex = 48;
            label18.Text = "в комплект";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(947, 348);
            label19.Name = "label19";
            label19.Size = new Size(80, 19);
            label19.TabIndex = 49;
            label19.Text = "в комплект";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(1293, 348);
            label20.Name = "label20";
            label20.Size = new Size(80, 19);
            label20.TabIndex = 50;
            label20.Text = "в комплект";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(678, 352);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(186, 64);
            listBox2.TabIndex = 51;
            listBox2.SelectedIndexChanged += selectBottom;
            listBox2.DoubleClick += del_chosen_bottom;
            // 
            // FilterSeasonBox
            // 
            FilterSeasonBox.FormattingEnabled = true;
            FilterSeasonBox.Location = new Point(32, 313);
            FilterSeasonBox.Name = "FilterSeasonBox";
            FilterSeasonBox.Size = new Size(158, 114);
            FilterSeasonBox.TabIndex = 52;
            FilterSeasonBox.ItemCheck += FilterSeasonBox_ItemCheck;
            // 
            // FilterColorBox
            // 
            FilterColorBox.CheckOnClick = true;
            FilterColorBox.FormattingEnabled = true;
            FilterColorBox.Location = new Point(32, 107);
            FilterColorBox.Name = "FilterColorBox";
            FilterColorBox.Size = new Size(159, 180);
            FilterColorBox.TabIndex = 53;
            FilterColorBox.ItemCheck += FilterColorBox_ItemCheck;
            // 
            // FilterStyleBox
            // 
            FilterStyleBox.FormattingEnabled = true;
            FilterStyleBox.Location = new Point(32, 453);
            FilterStyleBox.Name = "FilterStyleBox";
            FilterStyleBox.Size = new Size(159, 114);
            FilterStyleBox.TabIndex = 54;
            FilterStyleBox.ItemCheck += FilterStyleBox_ItemCheck;
            // 
            // listView5
            // 
            listView5.Location = new Point(228, 423);
            listView5.Name = "listView5";
            listView5.Size = new Size(313, 310);
            listView5.TabIndex = 55;
            listView5.UseCompatibleStateImageBehavior = false;
            listView5.SelectedIndexChanged += Load_see_formUp;
            // 
            // listView6
            // 
            listView6.Location = new Point(573, 424);
            listView6.Name = "listView6";
            listView6.Size = new Size(312, 309);
            listView6.TabIndex = 56;
            listView6.UseCompatibleStateImageBehavior = false;
            listView6.SelectedIndexChanged += Load_see_formBottom;
            // 
            // listView7
            // 
            listView7.Location = new Point(923, 423);
            listView7.Name = "listView7";
            listView7.Size = new Size(313, 309);
            listView7.TabIndex = 57;
            listView7.UseCompatibleStateImageBehavior = false;
            listView7.SelectedIndexChanged += Load_see_formSuit;
            // 
            // listView8
            // 
            listView8.Location = new Point(1270, 423);
            listView8.Name = "listView8";
            listView8.Size = new Size(314, 310);
            listView8.TabIndex = 58;
            listView8.UseCompatibleStateImageBehavior = false;
            listView8.SelectedIndexChanged += Load_see_formShoe;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(239, 387);
            label21.Name = "label21";
            label21.Size = new Size(54, 28);
            label21.TabIndex = 59;
            label21.Text = "Верх";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(592, 387);
            label22.Name = "label22";
            label22.Size = new Size(47, 28);
            label22.TabIndex = 60;
            label22.Text = "Низ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(923, 369);
            label23.Name = "label23";
            label23.Size = new Size(83, 28);
            label23.TabIndex = 61;
            label23.Text = "Платье/";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(1282, 387);
            label24.Name = "label24";
            label24.Size = new Size(70, 28);
            label24.TabIndex = 62;
            label24.Text = "Обувь";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(931, 392);
            label25.Name = "label25";
            label25.Size = new Size(83, 28);
            label25.TabIndex = 63;
            label25.Text = "Костюм";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 755);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(listView8);
            Controls.Add(listView7);
            Controls.Add(listView6);
            Controls.Add(listView5);
            Controls.Add(FilterStyleBox);
            Controls.Add(FilterColorBox);
            Controls.Add(FilterSeasonBox);
            Controls.Add(listBox2);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Гардероб";
            Load += LoadForm;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button5;
        private Button button6;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label4;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private ListBox listBox2;
        private ToolStripMenuItem editToolStripMenuItem2;
        private ToolStripMenuItem editStyleToolStripMenuItem;
        private ToolStripMenuItem delStyleToolStripMenuItem4;
        private ToolStripMenuItem edStyleToolStripMenuItem3;
        private ToolStripMenuItem addStyleToolStripMenuItem4;
        private ToolStripMenuItem editColorToolStripMenuItem;
        private ToolStripMenuItem deColorToolStripMenuItem5;
        private ToolStripMenuItem edColorToolStripMenuItem4;
        private ToolStripMenuItem addColorToolStripMenuItem5;
        private ToolStripMenuItem editSeasonoolStripMenuItem;
        private ToolStripMenuItem delSeasonToolStripMenuItem6;
        private ToolStripMenuItem edSeasonToolStripMenuItem5;
        private ToolStripMenuItem addSeasonToolStripMenuItem6;
        private ToolStripMenuItem wardrobeToolStripMenuItem;
        private ToolStripMenuItem addClotheToolStripMenuItem1;
        private ToolStripMenuItem complectsToolStripMenuItem;
        private ToolStripMenuItem statisticToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem styleToolStripMenuItem;
        private ToolStripMenuItem seasonToolStripMenuItem;
        private CheckedListBox FilterSeasonBox;
        private CheckedListBox FilterColorBox;
        private CheckedListBox FilterStyleBox;
        private ListView listView5;
        private ListView listView6;
        private ListView listView7;
        private ListView listView8;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
    }
}