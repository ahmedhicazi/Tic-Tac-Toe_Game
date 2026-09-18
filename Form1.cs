using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {

        byte Counter = 0;
        bool GameOver = false;

        void Disable()
        {
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
            pb9.Enabled = false;
        }

        void Restart()
        {
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;

            pb1.Tag = null;
            pb2.Tag = null;
            pb3.Tag = null;
            pb4.Tag = null;
            pb5.Tag = null;
            pb6.Tag = null;
            pb7.Tag = null;
            pb8.Tag = null;
            pb9.Tag = null;

            pb1.BackColor = Color.Transparent;
            pb2.BackColor = Color.Transparent;
            pb3.BackColor = Color.Transparent;
            pb4.BackColor = Color.Transparent;
            pb5.BackColor = Color.Transparent;
            pb6.BackColor = Color.Transparent;
            pb7.BackColor = Color.Transparent;
            pb8.BackColor = Color.Transparent;
            pb9.BackColor = Color.Transparent;

            pb1.Image = Resources.question_mark_96;
            pb2.Image = Resources.question_mark_96;
            pb3.Image = Resources.question_mark_96;
            pb4.Image = Resources.question_mark_96;
            pb5.Image = Resources.question_mark_96;
            pb6.Image = Resources.question_mark_96;
            pb7.Image = Resources.question_mark_96;
            pb8.Image = Resources.question_mark_96;
            pb9.Image = Resources.question_mark_96;

            lblPlayer.Text = "Player1";
            lblWinner.Text = "In Progress";
            Counter = 0;
        }

        void CheckValue(PictureBox a, PictureBox b, PictureBox c)
        {
            if(a.Tag ==null || b.Tag ==null || c.Tag ==null) return;

            if (a.Tag.ToString() == "X" && b.Tag.ToString() == "X" && c.Tag.ToString() == "X")
            {
                lblWinner.Text = "Player1";
                a.BackColor = Color.GreenYellow;
                b.BackColor = Color.GreenYellow;
                c.BackColor = Color.GreenYellow;
                MessageBox.Show("Player1 Wins","Game Over",MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                Disable();
                return;
            }

            if(a.Tag.ToString() == "O" &&  b.Tag.ToString() == "O" && c.Tag.ToString() == "O")
            {
                lblWinner.Text = "Player2";
                a.BackColor = Color.GreenYellow; 
                b.BackColor = Color.GreenYellow;
                c.BackColor = Color.GreenYellow;
                MessageBox.Show("Player2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                Disable();
                return;
            }
        }

        void CheckWinner()
        {

            CheckValue(pb1, pb2, pb3);
            CheckValue(pb4, pb5, pb6);
            CheckValue(pb7, pb8, pb9);

            CheckValue(pb1, pb4, pb7);
            CheckValue(pb2, pb5, pb8);
            CheckValue(pb3, pb6, pb9);

            CheckValue(pb1, pb5, pb9);
            CheckValue(pb3, pb5, pb7);
        }

        bool IsDraw()
        {
            if(Counter == 9)
            {
                MessageBox.Show("is Draw", "Game Over");

                Disable();
                return true;
            }
            return false;
        }

        void ChangeImage(object sender)
        {
            if (((PictureBox)sender).Tag != null)
            {
                MessageBox.Show("Already used", "Message");
                return;
            }

            if (lblPlayer.Text == "Player1")
            {
                ((PictureBox)sender).Tag = "X";
                ((PictureBox)sender).Image = Resources.X;
                lblPlayer.Text = "Player2";
            }
            else
            {
                ((PictureBox)sender).Tag = "O";
                ((PictureBox)sender).Image = Resources.O;
                lblPlayer.Text = "Player1";
            }
            Counter++;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X} , Y = {e.Y}";
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics(); 

            Pen pen=new Pen(Color.White);
            pen.Width = 10;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            g.DrawLine(pen, 310, 200, 770, 200);
            g.DrawLine(pen, 310, 350, 770, 350);
            g.DrawLine(pen, 450, 90, 450, 480);
            g.DrawLine(pen, 630, 90, 630, 480);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
            CheckWinner();
            IsDraw();
        }

        private void lblWinner_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
