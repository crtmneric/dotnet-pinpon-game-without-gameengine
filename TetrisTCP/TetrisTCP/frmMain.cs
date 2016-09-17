using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisTCP.Properties;

namespace TetrisTCP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {        
            InitializeComponent();
            player2X = pctPlayer2.Location.X;
            player2Y = pctPlayer2.Location.Y;
            player1X = pctPlayer1.Location.X;
            player1Y = pctPlayer1.Location.Y;
            ballX = pctBall.Location.X;
            ballY = pctBall.Location.Y;


        }
        int player2X;
        int player2Y;
        int player1X;
        int player1Y;
        int ballX;
        int ballY;
        
        Boolean player1Right;
        Boolean player1Left;
        Boolean player2Right;
        Boolean player2Left;
        Boolean rightWallHitBoolean;
        Boolean leftWallHitBoolean;
        Boolean scoreDone;
        Random rnd = new Random();
        Point after;
        Point before;
        int rndNew;
        int sayac = 0;
        Boolean player1Hit;
        Boolean player2Hit;
        int player1Score;
        int player2Score;
        SoundPlayer player;
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.A)
            {
                player1Left = true;
              
            }
            if (e.KeyCode == Keys.D)
            {
                player1Right =true;
               
            }
            if (e.KeyCode == Keys.Right)
            {
                player2Right = true;
               
            }
            if (e.KeyCode == Keys.Left)
            {
                player2Left = true;
               
            }

        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                player1Left = false;
               
            }
            if (e.KeyCode == Keys.D)
            {
                player1Right = false;
              
            }
            if (e.KeyCode == Keys.Right)
            {
                player2Right = false;
               
            }
            if (e.KeyCode == Keys.Left)
            {
                player2Left = false;
               
            }

        }

        private void tmrMovements_Tick(object sender, EventArgs e)
        {
            if (player1Right && player2Right)
            {
                if ((!(pctPlayer1.Location.X + 130 >= pctRigtWall.Location.X))&&(!(pctPlayer2.Location.X +130>=pctRigtWall.Location.X)))
                {
                    pctPlayer1.Location = new Point(pctPlayer1.Location.X + 8, pctPlayer1.Location.Y);
                    pctPlayer2.Location = new Point(pctPlayer2.Location.X + 8, pctPlayer2.Location.Y);
                }
            }
            if (player1Right && player2Left)
            {
                if ((!(pctPlayer1.Location.X + 130 >= pctRigtWall.Location.X))&&(  !(pctPlayer2.Location.X -28<= pctLeftWall.Location.X )))
                {
                pctPlayer1.Location = new Point(pctPlayer1.Location.X + 8, pctPlayer1.Location.Y);
                pctPlayer2.Location = new Point(pctPlayer2.Location.X - 8, pctPlayer2.Location.Y);
                }
            }
            if (player1Left && player2Left)
            {
                
                if ((!(pctPlayer1.Location.X - 28 <= pctLeftWall.Location.X))&&(!(pctPlayer2.Location.X -28<= pctLeftWall.Location.X )))
                {
                pctPlayer1.Location = new Point(pctPlayer1.Location.X - 8, pctPlayer1.Location.Y);
                pctPlayer2.Location = new Point(pctPlayer2.Location.X - 8, pctPlayer2.Location.Y);
                }
            }
            if (player1Left && player2Right)
            {
                if ((!(pctPlayer1.Location.X - 28 <= pctLeftWall.Location.X)) && (!(pctPlayer1.Location.X + 130 >= pctRigtWall.Location.X)))
                {
                    pctPlayer1.Location = new Point(pctPlayer1.Location.X - 8, pctPlayer1.Location.Y);
                    pctPlayer2.Location = new Point(pctPlayer2.Location.X + 8, pctPlayer2.Location.Y);
                }
            }
            if (player1Left)
            {

                if (!(pctPlayer1.Location.X - 28 <= pctLeftWall.Location.X))
                {
                    pctPlayer1.Location = new Point(pctPlayer1.Location.X - 16, pctPlayer1.Location.Y);
                }
            }
            if (player1Right)
            {

                if (!(pctPlayer1.Location.X + 130 >= pctRigtWall.Location.X))
                {
                    pctPlayer1.Location = new Point(pctPlayer1.Location.X + 16, pctPlayer1.Location.Y);
                }
            }
            if (player2Right)
            {

                if (!(pctPlayer2.Location.X +130>=pctRigtWall.Location.X))
                {
                    pctPlayer2.Location = new Point(pctPlayer2.Location.X + 16, pctPlayer2.Location.Y);
                }
            }
            if (player2Left)
            {
                if (!(pctPlayer2.Location.X -28<= pctLeftWall.Location.X ))
                {
                    pctPlayer2.Location = new Point(pctPlayer2.Location.X - 16, pctPlayer2.Location.Y);
                }
            }


        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            if (scoreDone)
            {
                pctBall.Location = new Point(ballX, ballY);
                pctPlayer1.Location = new Point(player1X, player1Y);
                pctPlayer2.Location = new Point(player2X, player2Y);
                rightWallHitBoolean = false;
                leftWallHitBoolean = false;
                player1Hit = false;
                player2Hit = false;

                if (sayac == 1)
                {
                    lblInfo.Text = "Scoreeeeee! Player1 :"+player1Score+" Player2 :" +player2Score;
                    lblInfo.Show();

                }
                if (sayac == 2)
                {
                    lblInfo.Show();
                }
                if (sayac == 4)
                {
                    lblInfo.Text = "Game will be start in 3 seconds...";
                 
                }
                if (sayac == 5)
                {
                    lblInfo.Text = "Game will be start in 2 seconds...";
                   
                }
                if (sayac == 6)
                {
                    lblInfo.Text = "Game will be start in 1 seconds...";
                 
                }
                if (sayac == 7)
                {
                    
                    lblInfo.Hide();
                    tmrMovements.Enabled = true;
                    tmrStart.Enabled = false;
                    rndNew = rnd.Next(1, 3);
                    scoreDone = false;
                    sayac = 0;
                    startBall();
                   
                }
                sayac++;
                
            }
            else
            {
                if (sayac == 0)
                {
                    lblInfo.Text = "Game will be start in 3 seconds...";
                }
                if (sayac == 1)
                {
                    lblInfo.Text = "Game will be start in 2 seconds...";
                }
                if (sayac == 2)
                {
                    lblInfo.Text = "Game will be start in 1 seconds...";
                }
                if (sayac == 3)
                {
                    lblInfo.Hide();
                    tmrMovements.Enabled = true;
                    tmrStart.Enabled = false;
                    rndNew = rnd.Next(1, 3);
                    startBall();
                    sayac = 0;
                    lblKeys.Hide();
                }
                sayac++;
               

            }
          
         
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrStart.Enabled = true; 
        }
        private void startBall()
        {
            rndNew = 1;
            if (rndNew == 1)
            {
              before=pctBall.Location;
              pctBall.Location = new Point(pctBall.Location.X, pctBall.Location.Y + 15);
              after = new Point(pctBall.Location.X, pctBall.Location.Y + 15);
            }
            if (rndNew == 2)
            {
                before = pctBall.Location;
                pctBall.Location = new Point(pctBall.Location.X, pctBall.Location.Y - 15);
                after = new Point(pctBall.Location.X, pctBall.Location.Y - 15);
            }
          
            tmrBall.Enabled = true;
        }

        private void tmrBall_Tick(object sender, EventArgs e)
        {
            goalChecks();
            if (after.Y - before.Y > 0)
            {

                if ((pctBall.Location.X < pctPlayer2.Location.X + pctPlayer2.Size.Width && pctBall.Location.X > pctPlayer2.Location.X) && pctBall.Location.Y > pctPlayer2.Location.Y - pctPlayer2.Size.Height)
                {
                    player = new SoundPlayer(Resources.bounce);
                    player.Play();
                    player2Hit = true;
                    player1Hit = false;
                    player2HitRandom();

                }
                else if ( pctBall.Location.X+pctBall.Size.Width>=pctRigtWall.Location.X)
                {
                    player = new SoundPlayer(Resources.laser);
                    player.Play();
                    before = pctBall.Location;
                    after = new Point(pctBall.Location.X-5, pctBall.Location.Y + 15);
                    pctBall.Location = after;
                    rightWallHitBoolean = true;
                    leftWallHitBoolean = false;
                    player2Hit = false;
                    player1Hit = false;
                    
                }
                else if (pctBall.Location.X <= pctLeftWall.Location.X)
                {

                    player = new SoundPlayer(Resources.laser);
                    player.Play();
                    before = pctBall.Location;
                    after = new Point(pctBall.Location.X+5, pctBall.Location.Y +15);
                    pctBall.Location = after;
                    leftWallHitBoolean = true;
                    rightWallHitBoolean = false;
                    player1Hit = false;
                    player2Hit = false;
                }
                else
                {
                    if (player1Hit)
                    {
                        before = pctBall.Location;
                        if (rndNew == 1)
                        {
                            after = new Point(pctBall.Location.X + 5, pctBall.Location.Y + 15);
                        }
                        if (rndNew == 2)
                        {
                            after = new Point(pctBall.Location.X - 5, pctBall.Location.Y + 15);
                        }
                        pctBall.Location = after;
                    }
                    if (!player1Hit && !player2Hit&&!rightWallHitBoolean&&!leftWallHitBoolean)
                    {
                        before = pctBall.Location;
                        after = new Point(pctBall.Location.X, pctBall.Location.Y + 15);
                        pctBall.Location = after;
                    }
                    else if (rightWallHitBoolean)
                    {
                        before = pctBall.Location;
                        after = new Point(pctBall.Location.X - 5, pctBall.Location.Y + 15);
                        pctBall.Location = after;
                    }
                    else if (leftWallHitBoolean)
                    {
                        before = pctBall.Location;
                        after = new Point(pctBall.Location.X + 5, pctBall.Location.Y + 15);
                        pctBall.Location = after;
                    }
                }
            }
            if (after.Y - before.Y < 0)
            {
                if ((pctBall.Location.X < pctPlayer1.Location.X + pctPlayer1.Size.Width && pctBall.Location.X > pctPlayer1.Location.X)  && pctBall.Location.Y < pctPlayer1.Location.Y + pctPlayer1.Size.Height)
                {
                    player = new SoundPlayer(Resources.bounce);
                    player.Play();
                    player1Hit = true;
                    player2Hit = false;
                    player1HitRandom();
                    
                }
                else if (pctBall.Location.X+pctBall.Size.Width >= pctRigtWall.Location.X)
                {

                    player = new SoundPlayer(Resources.laser);
                    player.Play();
                    before = pctBall.Location;
                    after = new Point(pctBall.Location.X-5, pctBall.Location.Y - 15);
                    pctBall.Location = after;
                    rightWallHitBoolean = true;        
                    leftWallHitBoolean = false;
                    player1Hit = false;
                    player2Hit = false;
                }
                else if (pctBall.Location.X <= pctLeftWall.Location.X)
                {

                    player = new SoundPlayer(Resources.laser);
                    player.Play();
                    before = pctBall.Location;
                    after = new Point(-pctBall.Location.X+5, pctBall.Location.Y - 15);
                    pctBall.Location = after;
                    leftWallHitBoolean = true;
                    rightWallHitBoolean = false;
                    player1Hit = false;
                    player2Hit = false;
                }
                else
                {
                    if (player2Hit)
                    {
                        before = pctBall.Location;
                        if (rndNew == 1)
                        {
                            after = new Point(pctBall.Location.X + 5, pctBall.Location.Y - 15);
                        }
                        if (rndNew == 2)
                        {
                            after = new Point(pctBall.Location.X - 5, pctBall.Location.Y - 15);
                        }
                            pctBall.Location = after;
                    }
                    if(!player1Hit && !player2Hit&&!rightWallHitBoolean&&!leftWallHitBoolean)
                    {
                        before = pctBall.Location;
                        after = new Point(pctBall.Location.X, pctBall.Location.Y - 15);
                        pctBall.Location = after;
                    }
                    else if (rightWallHitBoolean)
                    {
                        before = pctBall.Location;
                        after = new Point(pctBall.Location.X - 5, pctBall.Location.Y - 15);
                        pctBall.Location = after;
                    }
                    else if (leftWallHitBoolean)
                    {
                        before = pctBall.Location;
                        after = new Point(pctBall.Location.X + 5, pctBall.Location.Y - 15);
                        pctBall.Location = after;
                    }
                }       
            }
        }
        private void leftWallHit()
        {
           

        }
        private void player1HitRandom()
        {
            rndNew = rnd.Next(1, 3);
            if (rndNew == 1)
            {

                before = pctBall.Location;
                after = new Point(pctBall.Location.X+5, pctBall.Location.Y + 15);
                pctBall.Location = after;
            }
            if (rndNew == 2)
            {
                before = pctBall.Location;
                after = new Point(pctBall.Location.X - 5, pctBall.Location.Y + 15);
                pctBall.Location = after;
            }
        }
        private void player2HitRandom()
        {
            
            rndNew = rnd.Next(1, 3);
            if (rndNew == 1)
            {

                before = pctBall.Location;
                after = new Point(pctBall.Location.X+5, pctBall.Location.Y - 15);
                pctBall.Location = after;
            }
            if (rndNew == 2)
            {
                before = pctBall.Location;
                after = new Point(pctBall.Location.X - 5, pctBall.Location.Y - 15);
                pctBall.Location = after;
            }
        }
        private void goalChecks()
        {
            if (pctBall.Location.Y+pctBall.Size.Height > 825)
            {
                player = new SoundPlayer(Resources.goal);
                player.Play();
                scoreDone = true;
                player2Score++;
                tmrBall.Enabled = false;
                tmrMovements.Enabled = false;
                tmrStart.Enabled = true;
               
                
                
            }

            if (pctBall.Location.Y < -2)
            {
                player = new SoundPlayer(Resources.goal);
                player.Play();
                scoreDone = true;
                player1Score++;
                tmrBall.Enabled = false;
                tmrMovements.Enabled = false;
                tmrStart.Enabled = true;
            }
            
           
           
           
        }
    }
    
}
