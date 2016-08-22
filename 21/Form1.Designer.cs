namespace _21
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
            this.components = new System.ComponentModel.Container();
            this.takecart = new System.Windows.Forms.Button();
            this.stop_takecart = new System.Windows.Forms.Button();
            this.new_game = new System.Windows.Forms.Button();
            this.cartPlayer1 = new System.Windows.Forms.Label();
            this.cartPlayer2 = new System.Windows.Forms.Label();
            this.cartPlayer3 = new System.Windows.Forms.Label();
            this.cartPlayer4 = new System.Windows.Forms.Label();
            this.cartPlayer5 = new System.Windows.Forms.Label();
            this.cartPlayer6 = new System.Windows.Forms.Label();
            this.moneyPlayer = new System.Windows.Forms.TextBox();
            this.moneyBank = new System.Windows.Forms.TextBox();
            this.cartBank1 = new System.Windows.Forms.Label();
            this.cartBank2 = new System.Windows.Forms.Label();
            this.cartBank3 = new System.Windows.Forms.Label();
            this.cartBank4 = new System.Windows.Forms.Label();
            this.cartBank5 = new System.Windows.Forms.Label();
            this.cartBank6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Pot = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pointPlayer = new System.Windows.Forms.TextBox();
            this.pointBank = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.confirm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // takecart
            // 
            this.takecart.Enabled = false;
            this.takecart.Location = new System.Drawing.Point(233, 115);
            this.takecart.Name = "takecart";
            this.takecart.Size = new System.Drawing.Size(75, 23);
            this.takecart.TabIndex = 0;
            this.takecart.Text = "Взять еще";
            this.takecart.UseVisualStyleBackColor = true;
            this.takecart.Click += new System.EventHandler(this.takecart_Click);
            // 
            // stop_takecart
            // 
            this.stop_takecart.Enabled = false;
            this.stop_takecart.Location = new System.Drawing.Point(212, 144);
            this.stop_takecart.Name = "stop_takecart";
            this.stop_takecart.Size = new System.Drawing.Size(114, 23);
            this.stop_takecart.TabIndex = 1;
            this.stop_takecart.Text = "Передать ход";
            this.stop_takecart.UseVisualStyleBackColor = true;
            this.stop_takecart.Click += new System.EventHandler(this.stop_takecart_Click);
            // 
            // new_game
            // 
            this.new_game.Location = new System.Drawing.Point(449, 76);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(75, 23);
            this.new_game.TabIndex = 2;
            this.new_game.Text = "Новая игра";
            this.new_game.UseVisualStyleBackColor = true;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // cartPlayer1
            // 
            this.cartPlayer1.AutoSize = true;
            this.cartPlayer1.Location = new System.Drawing.Point(42, 244);
            this.cartPlayer1.Name = "cartPlayer1";
            this.cartPlayer1.Size = new System.Drawing.Size(35, 13);
            this.cartPlayer1.TabIndex = 3;
            this.cartPlayer1.Text = "label1";
            // 
            // cartPlayer2
            // 
            this.cartPlayer2.AutoSize = true;
            this.cartPlayer2.Location = new System.Drawing.Point(103, 244);
            this.cartPlayer2.Name = "cartPlayer2";
            this.cartPlayer2.Size = new System.Drawing.Size(35, 13);
            this.cartPlayer2.TabIndex = 4;
            this.cartPlayer2.Text = "label2";
            // 
            // cartPlayer3
            // 
            this.cartPlayer3.AutoSize = true;
            this.cartPlayer3.Location = new System.Drawing.Point(179, 244);
            this.cartPlayer3.Name = "cartPlayer3";
            this.cartPlayer3.Size = new System.Drawing.Size(35, 13);
            this.cartPlayer3.TabIndex = 5;
            this.cartPlayer3.Text = "label3";
            // 
            // cartPlayer4
            // 
            this.cartPlayer4.AutoSize = true;
            this.cartPlayer4.Location = new System.Drawing.Point(252, 244);
            this.cartPlayer4.Name = "cartPlayer4";
            this.cartPlayer4.Size = new System.Drawing.Size(35, 13);
            this.cartPlayer4.TabIndex = 6;
            this.cartPlayer4.Text = "label4";
            // 
            // cartPlayer5
            // 
            this.cartPlayer5.AutoSize = true;
            this.cartPlayer5.Location = new System.Drawing.Point(319, 244);
            this.cartPlayer5.Name = "cartPlayer5";
            this.cartPlayer5.Size = new System.Drawing.Size(35, 13);
            this.cartPlayer5.TabIndex = 7;
            this.cartPlayer5.Text = "label5";
            // 
            // cartPlayer6
            // 
            this.cartPlayer6.AutoSize = true;
            this.cartPlayer6.Location = new System.Drawing.Point(386, 244);
            this.cartPlayer6.Name = "cartPlayer6";
            this.cartPlayer6.Size = new System.Drawing.Size(35, 13);
            this.cartPlayer6.TabIndex = 8;
            this.cartPlayer6.Text = "label6";
            // 
            // moneyPlayer
            // 
            this.moneyPlayer.Location = new System.Drawing.Point(45, 284);
            this.moneyPlayer.Name = "moneyPlayer";
            this.moneyPlayer.ReadOnly = true;
            this.moneyPlayer.Size = new System.Drawing.Size(100, 20);
            this.moneyPlayer.TabIndex = 9;
            this.moneyPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // moneyBank
            // 
            this.moneyBank.Location = new System.Drawing.Point(63, 34);
            this.moneyBank.Name = "moneyBank";
            this.moneyBank.ReadOnly = true;
            this.moneyBank.Size = new System.Drawing.Size(100, 20);
            this.moneyBank.TabIndex = 10;
            this.moneyBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cartBank1
            // 
            this.cartBank1.AutoSize = true;
            this.cartBank1.Location = new System.Drawing.Point(42, 76);
            this.cartBank1.Name = "cartBank1";
            this.cartBank1.Size = new System.Drawing.Size(35, 13);
            this.cartBank1.TabIndex = 16;
            this.cartBank1.Text = "label7";
            // 
            // cartBank2
            // 
            this.cartBank2.AutoSize = true;
            this.cartBank2.Location = new System.Drawing.Point(103, 76);
            this.cartBank2.Name = "cartBank2";
            this.cartBank2.Size = new System.Drawing.Size(35, 13);
            this.cartBank2.TabIndex = 15;
            this.cartBank2.Text = "label8";
            // 
            // cartBank3
            // 
            this.cartBank3.AutoSize = true;
            this.cartBank3.Location = new System.Drawing.Point(179, 76);
            this.cartBank3.Name = "cartBank3";
            this.cartBank3.Size = new System.Drawing.Size(35, 13);
            this.cartBank3.TabIndex = 14;
            this.cartBank3.Text = "label9";
            // 
            // cartBank4
            // 
            this.cartBank4.AutoSize = true;
            this.cartBank4.Location = new System.Drawing.Point(252, 76);
            this.cartBank4.Name = "cartBank4";
            this.cartBank4.Size = new System.Drawing.Size(41, 13);
            this.cartBank4.TabIndex = 13;
            this.cartBank4.Text = "label10";
            // 
            // cartBank5
            // 
            this.cartBank5.AutoSize = true;
            this.cartBank5.Location = new System.Drawing.Point(313, 76);
            this.cartBank5.Name = "cartBank5";
            this.cartBank5.Size = new System.Drawing.Size(41, 13);
            this.cartBank5.TabIndex = 12;
            this.cartBank5.Text = "label11";
            // 
            // cartBank6
            // 
            this.cartBank6.AutoSize = true;
            this.cartBank6.Location = new System.Drawing.Point(386, 76);
            this.cartBank6.Name = "cartBank6";
            this.cartBank6.Size = new System.Drawing.Size(41, 13);
            this.cartBank6.TabIndex = 11;
            this.cartBank6.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Баланс Игрока";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Баланс Банкира";
            // 
            // Pot
            // 
            this.Pot.Location = new System.Drawing.Point(45, 183);
            this.Pot.Name = "Pot";
            this.Pot.ReadOnly = true;
            this.Pot.Size = new System.Drawing.Size(71, 20);
            this.Pot.TabIndex = 19;
            this.Pot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Ставка";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(351, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Количество очков у Банкира";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(332, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Количество очков у Игрока";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // pointPlayer
            // 
            this.pointPlayer.Location = new System.Drawing.Point(285, 281);
            this.pointPlayer.Name = "pointPlayer";
            this.pointPlayer.ReadOnly = true;
            this.pointPlayer.Size = new System.Drawing.Size(41, 20);
            this.pointPlayer.TabIndex = 25;
            this.pointPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointBank
            // 
            this.pointBank.Location = new System.Drawing.Point(304, 37);
            this.pointBank.Name = "pointBank";
            this.pointBank.ReadOnly = true;
            this.pointBank.Size = new System.Drawing.Size(41, 20);
            this.pointBank.TabIndex = 26;
            this.pointBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Банк";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // confirm
            // 
            this.confirm.Enabled = false;
            this.confirm.Location = new System.Drawing.Point(122, 180);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(92, 23);
            this.confirm.TabIndex = 30;
            this.confirm.Text = "Подтвердить";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 362);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pointBank);
            this.Controls.Add(this.pointPlayer);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Pot);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cartBank1);
            this.Controls.Add(this.cartBank2);
            this.Controls.Add(this.cartBank3);
            this.Controls.Add(this.cartBank4);
            this.Controls.Add(this.cartBank5);
            this.Controls.Add(this.cartBank6);
            this.Controls.Add(this.moneyBank);
            this.Controls.Add(this.moneyPlayer);
            this.Controls.Add(this.cartPlayer6);
            this.Controls.Add(this.cartPlayer5);
            this.Controls.Add(this.cartPlayer4);
            this.Controls.Add(this.cartPlayer3);
            this.Controls.Add(this.cartPlayer2);
            this.Controls.Add(this.cartPlayer1);
            this.Controls.Add(this.new_game);
            this.Controls.Add(this.stop_takecart);
            this.Controls.Add(this.takecart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Очко";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button takecart;
        private System.Windows.Forms.Button stop_takecart;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Label cartPlayer1;
        private System.Windows.Forms.Label cartPlayer2;
        private System.Windows.Forms.Label cartPlayer3;
        private System.Windows.Forms.Label cartPlayer4;
        private System.Windows.Forms.Label cartPlayer5;
        private System.Windows.Forms.Label cartPlayer6;
        private System.Windows.Forms.TextBox moneyPlayer;
        private System.Windows.Forms.TextBox moneyBank;
        private System.Windows.Forms.Label cartBank1;
        private System.Windows.Forms.Label cartBank2;
        private System.Windows.Forms.Label cartBank3;
        private System.Windows.Forms.Label cartBank4;
        private System.Windows.Forms.Label cartBank5;
        private System.Windows.Forms.Label cartBank6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Pot;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pointPlayer;
        private System.Windows.Forms.TextBox pointBank;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button confirm;
    }
}

