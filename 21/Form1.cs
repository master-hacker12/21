using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string[] cart = new string[36];
        public static string [] number = new string[12];
       
       public static int bank = 0;
        public static int player = 0;
        public static int banker = 0;
        public static int colpointplayer = 0;
        public static int colpointbank = 0;
        public static int colcart = 0;
        public static int randombank = 0;

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs ee)
        {

            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pointBank.Text = Convert.ToString(0);
            pointPlayer.Text = Convert.ToString(0);
            moneyBank.Text = Convert.ToString( 5000);
            moneyPlayer.Text = Convert.ToString(5000);
            cart[0] = "6";
            cart[1] = "7";
            cart[2] = "8";
            cart[3] = "9";
            cart[4] = "10";
            cart[5] = "J";
            cart[6] = "Q";
            cart[7] = "K";
            cart[8] = "A";
            for (int i=9;i<36;i++)
            {
                cart[i] = cart[i - 9];
            }
            cartBank1.Text = "";
            cartBank2.Text = "";
            cartBank3.Text = "";
            cartBank4.Text = "";
            cartBank5.Text = "";
            cartBank6.Text = "";
            cartPlayer1.Text = "";
            cartPlayer2.Text = "";
            cartPlayer3.Text = "";
            cartPlayer4.Text = "";
            cartPlayer5.Text = "";
            cartPlayer6.Text = "";
            timer1.Enabled = true;
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            pointBank.Text = "0";
            pointPlayer.Text = "0";
           
            for (int i=0;i<number.Length;i++)
            {
                number[i] = "" ;
            }
            cartPlayer1.Text = null;
            cartPlayer2.Text = null;
            cartPlayer3.Text = null;
            cartPlayer4.Text = null;
            cartPlayer5.Text = null;
            cartPlayer6.Text = null;
            cartBank1.Text = "";
            cartBank2.Text = "";
            cartBank3.Text = "";
            cartBank4.Text = "";
            cartBank5.Text = "";
            cartBank6.Text = "";
            Pot.ReadOnly = false;
            new_game.Enabled = false;
            confirm.Enabled = true;
            colpointplayer = 0;
            pointPlayer.Text = colpointplayer.ToString();
            colpointbank = 0;
            pointBank.Text = colpointbank.ToString();
            colcart = 0;
        }

        private void takecart_Click(object sender, EventArgs e)
        {
            switch (colcart)
            {
                case 0: { cartPlayer1.Text = take_cart(); colcart++; break; }
                case 1: { cartPlayer2.Text = take_cart(); colcart++; break; }
                case 2: { cartPlayer3.Text = take_cart(); colcart++; break; }
                case 3: { cartPlayer4.Text = take_cart(); colcart++; break; }
                case 4: { cartPlayer5.Text = take_cart(); colcart++; break; }
                case 5: { cartPlayer6.Text = take_cart(); colcart++; takecart.Enabled = false; break; }
                case 6: {  break; }
            }
            proverka(colpointplayer);
        }

        public string take_cart ()
        {
            Random rand = new Random();
            int k = rand.Next(0, 35);
            for (int i = 0; i<number.Length;i++)
            {
                if (k.ToString() == number[i])
                {
                    k = rand.Next(0, 35);
                    i = -1;
                    continue;
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]=="")
                {
                    number[i] = k.ToString();
                    break;
                }
            }
            ;
            switch (cart[k])
            {
                case "6": { colpointplayer += 6; pointPlayer.Text = colpointplayer.ToString(); break; }
                case "7": { colpointplayer += 7; pointPlayer.Text = colpointplayer.ToString(); break; }
                case "8": { colpointplayer += 8; pointPlayer.Text = colpointplayer.ToString(); break; }
                case "9": { colpointplayer += 9; pointPlayer.Text = colpointplayer.ToString(); break; }
                case "10": { colpointplayer +=10; pointPlayer.Text = colpointplayer.ToString(); break; }
                case "J": { colpointplayer += 2; pointPlayer.Text = colpointplayer.ToString(); break; }
                case "Q": { colpointplayer += 3; pointPlayer.Text = colpointplayer.ToString(); break; }
                case "K": { colpointplayer += 4; pointPlayer.Text = colpointplayer.ToString(); break; }
                case "A": { colpointplayer += 11; pointPlayer.Text = colpointplayer.ToString(); break; }
            }
            return cart[k];

        }

        private void proverka (int playerpoint)
        {
            if (playerpoint == 20)
                takecart.Enabled = false;
            if (playerpoint == 15)
                stop_takecart.Enabled = false;
            else
                stop_takecart.Enabled = true;
            if ((playerpoint > 21) && ((cartPlayer1.Text!="A") || (cartPlayer2.Text!="A")))
            {
                MessageBox.Show("Перебор!!! Вы проиграли", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new_game.Enabled = true;
                takecart.Enabled = false;
                stop_takecart.Enabled = false;
                banker += bank;
                bank = 0;
                textBox1.Text = bank.ToString();
                moneyBank.Text = banker.ToString();

                return;
            }
            if ((playerpoint == 21) || ( (cartPlayer1.Text == "A") && (cartPlayer2.Text == "A")))
            {
                MessageBox.Show("Очко!!! Вы выиграли", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new_game.Enabled = true;
                takecart.Enabled = false;
                stop_takecart.Enabled = false;
                player += bank;
                bank = 0;
                textBox1.Text = bank.ToString();
                moneyPlayer.Text = player.ToString();
                pointPlayer.Text = colpointplayer.ToString();
                return;
            }
           
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pointBank.Text) > 21)
                pointBank.BackColor = Color.Red;
            if (Convert.ToInt32(pointPlayer.Text) > 21)
                pointPlayer.BackColor = Color.Red;
           if (Convert.ToInt32(pointBank.Text) == 21)
                pointBank.BackColor = Color.Lime;
            if (Convert.ToInt32(pointPlayer.Text) == 21)
                pointPlayer.BackColor = Color.Lime;
           if (Convert.ToInt32(pointBank.Text) < 21)
                pointBank.BackColor = Color.Orange;
            if (Convert.ToInt32(pointPlayer.Text) < 21)
                pointPlayer.BackColor = Color.Orange;
        }

        private void stop_takecart_Click(object sender, EventArgs e)
        {
            pointBank.Text = "0";
            colpointbank = 0;
            colcart = 0;
            takecart.Enabled = false;
            stop_takecart.Enabled = false;
            switch (colcart)
            {
                case 0: { cartBank1.Text = take_cart_bank(); colcart++; break; }
                case 1: { cartBank2.Text = take_cart_bank(); colcart++; break; }
                case 2: { cartBank3.Text = take_cart_bank(); colcart++; break; }
                case 3: { cartBank4.Text = take_cart_bank(); colcart++; break; }
                case 4: { cartBank5.Text = take_cart_bank(); colcart++; break; }
                case 5: { cartBank6.Text = take_cart_bank(); colcart++; break; }
                case 6: { break; }
            }

            while (true)
            {
                proverka(colpointplayer, colpointbank);
                if (colcart == 1)
                    randombank = 1;
                if ((colpointbank >= 16) && (colpointbank <= 19) && (colpointbank != 17)&& (colcart!=0))
                {
                    Random r = new Random();
                    randombank = r.Next(0, 1);
                }
                if (randombank < 0)
                    break;
                if (randombank == 0)
                {
                    if ( is_win(colpointplayer, colpointbank))
                    {
                        MessageBox.Show(" Вы выиграли", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_game.Enabled = true;
                        takecart.Enabled = false;
                        stop_takecart.Enabled = false;
                        player += bank;
                        bank = 0;
                        textBox1.Text = bank.ToString();
                        moneyPlayer.Text = player.ToString();
                        pointPlayer.Text = colpointplayer.ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show(" Вы проиграли", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_game.Enabled = true;
                        takecart.Enabled = false;
                        stop_takecart.Enabled = false;
                        banker += bank;
                        bank = 0;
                        textBox1.Text = bank.ToString();
                        moneyBank.Text = banker.ToString();
                        break;
                    }
                }
                else
                {
                    switch (colcart)
                    {
                        case 0: { cartBank1.Text = take_cart_bank(); colcart++; break; }
                        case 1: { cartBank2.Text = take_cart_bank(); colcart++; break; }
                        case 2: { cartBank3.Text = take_cart_bank(); colcart++; break; }
                        case 3: { cartBank4.Text = take_cart_bank(); colcart++; break; }
                        case 4: { cartBank5.Text = take_cart_bank(); colcart++; break; }
                        case 5: { cartBank6.Text = take_cart_bank(); colcart++;  break; }
                        case 6: {randombank=0; break; }
                    }
                }
            }
        }

        private bool is_win (int playerpoint, int bankpoint)
        {
            if (bankpoint >= playerpoint)
                return false;
            else
                return true;
        }

        private void proverka(int playerpoint, int bankpoint)
        {
            if ((bankpoint == 20) || (bankpoint == 21) || ((cartBank1.Text == "A") && (cartBank2.Text == "A")))
            {
                MessageBox.Show("Очко у банка!!! Вы проиграли", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new_game.Enabled = true;
                takecart.Enabled = false;
                stop_takecart.Enabled = false;
                banker += bank;
                bank = 0;
                textBox1.Text = bank.ToString();
                moneyBank.Text = banker.ToString();
                randombank = -1;
                return;
            }

            if ((bankpoint > 21) && ((cartBank1.Text != "A") || (cartBank2.Text != "A")))
            {
                MessageBox.Show("У банка перебор!!!! Вы выиграли", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new_game.Enabled = true;
                takecart.Enabled = false;
                stop_takecart.Enabled = false;
                player += bank;
                bank = 0;
                textBox1.Text = bank.ToString();
                moneyPlayer.Text = player.ToString();
                pointPlayer.Text = colpointplayer.ToString();
                randombank = -1;
                return;
            }

            if (bankpoint == 17)
            {
                if (is_win(colpointplayer, colpointbank))
                {
                    MessageBox.Show(" Вы выиграли", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new_game.Enabled = true;
                    takecart.Enabled = false;
                    stop_takecart.Enabled = false;
                    player += bank;
                    bank = 0;
                    textBox1.Text = bank.ToString();
                    moneyPlayer.Text = player.ToString();
                    pointPlayer.Text = colpointplayer.ToString();
                    
                }
                else
                {
                    MessageBox.Show(" Вы проиграли", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new_game.Enabled = true;
                    takecart.Enabled = false;
                    stop_takecart.Enabled = false;
                    banker += bank;
                    bank = 0;
                    textBox1.Text = bank.ToString();
                    moneyBank.Text = banker.ToString();
                    
                }

                randombank = -1;
            }
            if (bankpoint == 15)
                randombank = 1;
        }

        public string take_cart_bank()
        {
            Random rand = new Random();
            int k = rand.Next(0, 35);
            for (int i = 0; i < number.Length; i++)
            {
                if (k.ToString() == number[i])
                {
                    k = rand.Next(0, 35);
                    i = -1;
                    continue;
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == "")
                {
                    number[i] = k.ToString();
                    break;
                }
            }
            ;
            switch (cart[k])
            {
                case "6": { colpointbank += 6; pointBank.Text = colpointbank.ToString(); break; }
                case "7": { colpointbank += 7; pointBank.Text = colpointbank.ToString(); break; }
                case "8": { colpointbank += 8; pointBank.Text = colpointbank.ToString(); break; }
                case "9": { colpointbank += 9; pointBank.Text = colpointbank.ToString(); break; }
                case "10": { colpointbank += 10; pointBank.Text = colpointbank.ToString(); break; }
                case "J": { colpointbank += 2; pointBank.Text = colpointbank.ToString(); break; }
                case "Q": { colpointbank += 3; pointBank.Text = colpointbank.ToString(); break; }
                case "K": { colpointbank += 4; pointBank.Text = colpointbank.ToString(); break; }
                case "A": { colpointbank += 11; pointBank.Text = colpointbank.ToString(); break; }
            }
            return cart[k];

        }


        private void confirm_Click(object sender, EventArgs e)
        {
            if (Pot.Text=="")
            {
                MessageBox.Show("Сделайте ставку", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bank = Convert.ToInt32(Pot.Text)*2;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            banker = Convert.ToInt32(moneyBank.Text);
            player = Convert.ToInt32(moneyPlayer.Text);
            player = player - bank/2;
            banker = banker - bank/2;
            moneyPlayer.Text = player.ToString();
            moneyBank.Text = banker.ToString();
            takecart_Click(sender, e);
            takecart.Enabled = true;
            stop_takecart.Enabled = true;
            textBox1.Text = bank.ToString();
            Pot.ReadOnly = true;
            Pot.Text = "";
            confirm.Enabled = false;
            timer1.Enabled = true;
        }
    }
}
