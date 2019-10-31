using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPPER_SMAH_BORS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean p1Moveup;
        Boolean p1Movedown;
        Boolean p1Moveleft;
        Boolean p1Moveright;

        Boolean p2Moveup;
        Boolean p2Movedown;
        Boolean p2Moveleft;
        Boolean p2Moveright;

        Boolean p1upbut;
        Boolean p1downbut;
        Boolean p1leftbut;
        Boolean p1rightbut;

        Boolean p2upbut;
        Boolean p2downbut;
        Boolean p2leftbut;
        Boolean p2rightbut;

        Boolean p1Punchup;
        Boolean p1Punchdown;
        Boolean p1Punchleft;
        Boolean p1Punchright;

        Boolean p2Punchup;
        Boolean p2Punchdown;
        Boolean p2Punchleft;
        Boolean p2Punchright;

        Boolean p1Punchbut;
        Boolean p2Punchbut;

        int bruhptate = 0;
        int g1 = 0;
        int g2 = 0;

        int stonks1 = 3;
        int stonks2 = 3;

        int up3 = 0;
        int up69 = 0;

        int p1punchupdis = 0;
        int p2punchupdis = 0;

        int p1punchdowndis = 0;
        int p2punchdowndis = 0;

        int p1punchrightdis = 0;
        int p2punchrightdis = 0;

        int p1punchleftdis = 0;
        int p2punchleftdis = 0;

        int p1percent = 0;
        int p2percent = 0;

        int p1launchup = 0;
        int p1launchdown = 0;
        int p1launchleft = 0;
        int p1launchright = 0;

        int p2launchup = 0;
        int p2launchdown = 0;
        int p2launchleft = 0;
        int p2launchright = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//keydwon
        {
            if (e.KeyCode == Keys.Up)
            {
                p1Moveup = true;
                update();
            }

            if (e.KeyCode == Keys.Up)
            {
                p1upbut = true;
            }



            if (e.KeyCode == Keys.Down)
            {
                p1Movedown = true;
                update();
            }

            if (e.KeyCode == Keys.Down)
            {
                p1downbut = true;
            }



            if (e.KeyCode == Keys.Left)
            {
                p1Moveleft = true;
                update();
            }

            if (e.KeyCode == Keys.Left)
            {
                p1leftbut = true;
            }



            if (e.KeyCode == Keys.Right)
            {
                p1Moveright = true;
                update();
            }

            if (e.KeyCode == Keys.Right)
            {
                p1rightbut = true;
            }



            if (e.KeyCode == Keys.M)
            {
                p1Punchbut = true;
            }


            if (e.KeyCode == Keys.M)//p1 puncher
            {
                if(p1Moveup == true)
                {
                    p1Punchup = true;
                }

            }



            if (e.KeyCode == Keys.W)
            {
                p2Moveup = true;
                update();
            }

            if (e.KeyCode == Keys.W)
            {
                p2upbut = true;
            }

            if (e.KeyCode == Keys.S)
            {
                p2Movedown = true;
                update();
            }

            if (e.KeyCode == Keys.A)
            {
                p2Moveleft = true;
                update();
            }

            if (e.KeyCode == Keys.D)
            {
                p2Moveright = true;
                update();
            }



            

            if (e.KeyCode == Keys.G)//p1 puncher
            {
                p2Punchbut = true;
            }

        }

        private void update()
        {
            
            bruhptate++;

            label8.Text = bruhptate.ToString();

            if(bruhptate >= 100)
            {
                p1Moveup = false;
                p1Movedown = false;
                p1Moveleft = false;
                p1Moveright = false;

                p2Moveup = false;
                p2Movedown = false;
                p2Moveleft = false;
                p2Moveright = false;

                 p1upbut = false;
                 p1downbut = false;
                 p1leftbut = false;
                 p1rightbut = false;

                 p1Punchup = false;
                 p1Punchdown = false;
                 p1Punchleft = false;
                 p1Punchright = false;

                 p2Punchup = false;
                 p2Punchdown = false;
                 p2Punchleft = false;
                 p2Punchright = false;

                 p1Punchbut = false;
                 p2Punchbut = false;

                bruhptate = 0;
            }



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)//keyup
        {
            if (e.KeyCode == Keys.Up)
            {
                p1Moveup = false;
                update();
            }


            if (e.KeyCode == Keys.Up)
            {
                p1upbut = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                p1Movedown = false;
                update();
            }

            if (e.KeyCode == Keys.Down)
            {
                p1downbut = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                p1Moveleft = false;
                update();
            }

            if (e.KeyCode == Keys.Left)
            {
                p1leftbut = false;
            }


            if (e.KeyCode == Keys.Down)
            {
                p1leftbut = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                p1Moveright = false;
                update();
            }

            if (e.KeyCode == Keys.Right)
            {
                p1rightbut = false;
            }


            if (e.KeyCode == Keys.M)
            {
                p1Punchbut = false;
            }


            if (e.KeyCode == Keys.M)
            {
                p1Punchup = false;
                p1Punchdown = false;
                p1Punchleft = false;
                p1Punchright = false;
                
            }

         





            if (e.KeyCode == Keys.W)
            {
                p2Moveup = false;
                update();
            }

            if (e.KeyCode == Keys.W)
            {
                p2upbut = false;
            }

            if (e.KeyCode == Keys.S)
            {
                p2Movedown = false;
                update();
            }

            if (e.KeyCode == Keys.A)
            {
                p2Moveleft = false;
                update();
            }

            if (e.KeyCode == Keys.D)
            {
                p2Moveright = false;
                update();
            }

            if (e.KeyCode == Keys.G)//p2puncherup
            {
                p2Punchup = false;
                p2Punchdown = false;
                p2Punchleft = false;
                p2Punchright = false;
            }

            if (e.KeyCode == Keys.G)//p1 puncher
            {
                p2Punchbut = false;
            }

        }
        
        private void timer1_Tick(object sender, EventArgs e) //cheker timer
        {
            Point P1oing = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);

            if (p1Moveup == true)
            {
                
                if (up3 == 0)
                {
                    up3++;
                    timer4.Enabled = true;
                    p1Moveup = false;
                }
 
                else if (up3 == 1)
                {
                    up3 = 2;
                    timer4.Enabled = true;

                }
            }

            if (p1Movedown == true)
            {
                P1oing.Y += 10;
                pictureBox1.Location = P1oing;
            }

            if (p1Moveleft == true)
            {
                P1oing.X -= 7;
                pictureBox1.Location = P1oing;
            }

            if (p1Moveright == true)
            {
                P1oing.X += 7;
                pictureBox1.Location = P1oing;
            }




            Point P2oing = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);

            if (p2Moveup == true)
            {
                if (up69 == 0)
                {
                    up69++;
                    timer5.Enabled = true;
                    p2Moveup = false;
                }

                else if (up69 == 1)
                {
                    up69 = 2;
                    timer5.Enabled = true;

                }
            }

            if (p2Movedown == true)
            {
                P2oing.Y += 10;
                pictureBox2.Location = P2oing;
            }

            if (p2Moveleft == true)
            {
                P2oing.X -= 7;
                pictureBox2.Location = P2oing;
            }

            if (p2Moveright == true)
            { 
                P2oing.X += 7;
                pictureBox2.Location = P2oing;
            }


            if (p2Punchup == true)
            {
                timer11.Enabled = true;
                pictureBox2.Size = new Size(80, 140);
                Point p2oingpunchup = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 30);
            }

            if (p2Punchdown == true)
            {

            }

            if (p2Punchleft == true)
            {
                
            }

            if (p2Punchright == true)
            {

            }




            if (p1Punchup == true)
            {
                timer7.Enabled = true;
                pictureBox1.Size = new Size(80, 140);
                Point p1oingpunchup = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 30);
            }

            if (p1Punchdown == true)
            {
                p1DownDisplayTimer.Enabled = true;
                pictureBox1.Size = new Size(120, 80);
                Point p1oingpunchup = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 30);
            }

            if (p1Punchleft == true)
            {
                p1LeftDisplayTimer.Enabled = true;
                pictureBox1.Size = new Size(140, 80);
                Point p1oingpunchup = new Point(pictureBox1.Location.X - 60, pictureBox1.Location.Y);
            }

            if (p1Punchright == true)
            {
                p1RightDisplayTimer.Enabled = true;
                pictureBox1.Size = new Size(140, 80);
                Point p1oingpunchup = new Point(pictureBox1.Location.X - 30, pictureBox1.Location.Y);
            }



        }

        private void respawn1()
        {
            Point rPoing = new Point(550, 400);

            pictureBox1.Location = rPoing;

            p1percent = 0;

            label4.Text = p1percent.ToString();
        }

        private void respawn2()
        {
            Point rPoing = new Point(1000, 400);
            
            pictureBox2.Location = rPoing;

            p2percent = 0;

            label5.Text = p2percent.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)//collisions
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                Point downcol = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                pictureBox1.Location = downcol;
                up3 = 0;

                p1Movedown = false;

                p1Punchdown = false;

            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                Point leftcol = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                
                pictureBox1.Location = leftcol;

            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                Point rightcol = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
              
                pictureBox1.Location = rightcol;

            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                Point botcol = new Point(pictureBox1.Location.X , pictureBox1.Location.Y + 10);

                pictureBox1.Location = botcol;

            }






            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                Point downcol = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);

                pictureBox2.Location = downcol;
                up69 = 0;
                p2Movedown = false;
                
            }

            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                Point leftcol = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);

                pictureBox2.Location = leftcol;

            }

            if (pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                Point rightcol = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);

                pictureBox2.Location = rightcol;

            }

            if (pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                Point botcol = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 10);

                pictureBox2.Location = botcol;

            }

            //punchi
            
            if(p1Punchup == true)
            {
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    p2percent += 5;
                    timer9.Enabled = true;
                    label5.Text = p2percent.ToString();

                    Point uppunch = new Point(pictureBox2.Location.X + 20, pictureBox2.Location.Y - 40);

                    pictureBox2.Location = uppunch;
                }
            
            }

            if (p1Punchdown == true)
            {
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    p2percent += 2;
                    p1DownLaunchTimer.Enabled = true;
                    label5.Text = p2percent.ToString();

                    Point downpunch = new Point(pictureBox2.Location.X - 20, pictureBox2.Location.Y + 40);

                    pictureBox2.Location = downpunch;
                }

            }

            if (p1Punchright == true)
            {
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    p2percent += 10;
                     p1RightLaunchTimer.Enabled = true;
                    label5.Text = p2percent.ToString();

                    Point rightpunch = new Point(pictureBox2.Location.X + 20, pictureBox2.Location.Y - 40);

                    pictureBox2.Location = rightpunch;
                }

            }

            if (p1Punchleft == true)
            {
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    p2percent += 10;
                    timer13.Enabled = true;
                    label5.Text = p2percent.ToString();

                    Point leftpunch = new Point(pictureBox2.Location.X - 20, pictureBox2.Location.Y - 40);

                    pictureBox2.Location = leftpunch;
                }

            }


            if (p2Punchup == true)
            {
                if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    p1percent += 5;
                    timer10.Enabled = true;
                    label4.Text = p1percent.ToString();

                    Point uppunch = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y - 40);

                    pictureBox1.Location = uppunch;
                }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dont click that");
        }//secret

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("B R U H");
        }//secret

        private void timer3_Tick(object sender, EventArgs e)//gravity
        {
            Point P1oing = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
            P1oing.Y += 8;
            pictureBox1.Location = P1oing;

            Point P2oing = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);
            P2oing.Y += 8;
            pictureBox2.Location = P2oing;
            label1.Text = up3.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)//jaumping 1
        {
            g1++;

            Point P1oing = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
            P1oing.Y -= 20 ;
            pictureBox1.Location = P1oing;

            if (g1 >= 17)
            {
                g1 = 0;
                timer4.Enabled = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)//jumping2
        {
            g2++;
            Point P2oing = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);
            P2oing.Y -= 20;
            pictureBox2.Location = P2oing;
            if (g2 >= 17)
            {
                g2 = 0;
                timer5.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)//secret
        {
            int w = 69;

            w++;
        }

        private void timer6_Tick(object sender, EventArgs e)//respawner
        {
            

            Point P1oing = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);

            if (P1oing.X <= 0)
            {
                respawn1();
                stonks1--;
                label6.Text = stonks1.ToString();
            }

            if (P1oing.Y <= 0)
            {
                respawn1();
                stonks1--;
                label6.Text = stonks1.ToString();
            }
            if (P1oing.X >= 1600)
            {
                respawn1();
                stonks1--;
                label6.Text = stonks1.ToString();
            }

            if (P1oing.Y >= 1000)
            {
                respawn1();
                stonks1--;
                label6.Text = stonks1.ToString();
            }


            Point P2oing = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);


            if (P2oing.X <= 0)
            {
                respawn2();
                stonks2--;
                label7.Text = stonks2.ToString();
            }

            if (P2oing.Y <= 0)
            {
                respawn2();
                stonks2--;
                label7.Text = stonks2.ToString();
            }
            if (P2oing.X >= 1600)
            {
                respawn2();
                stonks2--;
                label7.Text = stonks2.ToString();
            }

            if (P2oing.Y >= 1000)
            {
                respawn2();
                stonks2--;
                label7.Text = stonks2.ToString();
            }
            if (stonks1 <= 0 ) {
                
                stonks1 = 3;
                stonks2 = 3;

                p1Moveup = false;
                p1Movedown = false;
                p1Moveleft = false;
                p1Moveright = false;

                p2Moveup = false;
                p2Movedown = false;
                p2Moveleft = false;
                p2Moveright = false;

                p1upbut = false;
                p1downbut = false;
                p1leftbut = false;
                p1rightbut = false;

                p2upbut = false;
                p2downbut = false;
                p2leftbut = false;
                p2rightbut = false;

                p1Punchup = false;
                p1Punchdown = false;
                p1Punchleft = false;
                p1Punchright = false;

                p2Punchup = false;
                p2Punchdown = false;
                p2Punchleft = false;
                p2Punchright = false;

                p1Punchbut = false;
                p2Punchbut = false;

                MessageBox.Show("P2 weiner");
                label7.Text = stonks2.ToString();
                label6.Text = stonks1.ToString();

            }
            if (stonks2 <= 0)
            {
                stonks2 = 3;
                stonks1 = 3;

                 p1Moveup = false;
                 p1Movedown = false;
                 p1Moveleft = false;
                 p1Moveright = false;

                 p2Moveup = false;
                 p2Movedown = false;
                 p2Moveleft = false;
                 p2Moveright = false;

                 p1upbut = false;
                 p1downbut = false;
                 p1leftbut = false;
                 p1rightbut = false;

                 p2upbut = false;
                 p2downbut = false;
                 p2leftbut = false;
                 p2rightbut = false;

                 p1Punchup = false;
                 p1Punchdown = false;
                 p1Punchleft = false;
                 p1Punchright = false;

                 p2Punchup = false;
                 p2Punchdown = false;
                 p2Punchleft = false;
                 p2Punchright = false;

                 p1Punchbut = false;
                 p2Punchbut = false;

                /*timer5.Enabled = false;
                timer6.Enabled = false;
                timer7.Enabled = false;
                timer8.Enabled = false;
                timer9.Enabled = false;
                timer10.Enabled = false;
                timer11.Enabled = false;
                timer12.Enabled = false;
                p1DownDisplayTimer.Enabled = false;
                p1DownLaunchTimer.Enabled = false;
                p1RightDisplayTimer.Enabled = false;
                p1RightLaunchTimer.Enabled = false;
                */
                MessageBox.Show("P1 weiner");
                label7.Text = stonks2.ToString();
                label6.Text = stonks1.ToString();

            }


        }//respanw

        private void timer7_Tick(object sender, EventArgs e)//p1punchupdisplay
        {
            p1punchupdis++;

            pictureBox1.Image = Properties.Resources.hatt;

            if (p1punchupdis >= 7)
            {
                p1punchupdis = 0;
                timer7.Enabled = false;
                p1Punchup = false;
                pictureBox1.Size = new Size(86, 94);
                pictureBox1.Image = Properties.Resources.mayo;
            }



        }

        private void timer8_Tick(object sender, EventArgs e)//buttonpress1
        {
            if(p1upbut == true && p1Punchbut == true)
            {
                p1Punchup = true;
                
            }

            if (p1rightbut == true && p1Punchbut == true)
            {
                p1Punchright = true;
               
            }

            if (p1downbut == true && p1Punchbut == true)
            {
                p1Punchdown = true;
                
            }

            if (p1leftbut == true && p1Punchbut == true)
            {
                p1Punchleft = true;
                
            }
        }

        private void timer9_Tick(object sender, EventArgs e)//p1launchup
        {
            p1launchup++;

            Point uppunch = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - p2percent);

            pictureBox2.Location = uppunch;

            

            if (p1launchup >= p2percent)
            {
                p2launchup = 0;
                timer9.Enabled = false; 
            }
        }

        private void timer10_Tick(object sender, EventArgs e)//p2launchup
        {
            p2launchup++;

            Point uppunch = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - p1percent);

            pictureBox1.Location = uppunch;



            if (p2launchup >= p1percent)
            {
                p2launchup = 0;
                timer10.Enabled = false;
            }
        }

        private void timer11_Tick(object sender, EventArgs e)//p2punchupdisplay
        {
            p2punchupdis++;

            pictureBox2.Image = Properties.Resources.WAAAH_Mostache_jpg;

            if (p2punchupdis >= 7)
            {
                p2punchupdis = 0;
                timer11.Enabled = false;
                p2Punchup = false;
                pictureBox2.Size = new Size(86, 94);
                pictureBox2.Image = Properties.Resources.WAAAH;
            }


        }

        private void timer12_Tick(object sender, EventArgs e)//buttonpress2
        {
            if (p2upbut == true && p2Punchbut == true)
            {
                p2Punchup = true;
            }

            if (p2rightbut == true && p2Punchbut == true)
            {
                p2Punchright = true;
            }
        }

        private void p1RightLaunchTimer_Tick(object sender, EventArgs e)
        {
            p1launchright++;

            Point rightpunch = new Point(pictureBox2.Location.X + p2percent, pictureBox2.Location.Y );

            pictureBox2.Location = rightpunch;

            if (p1launchright >= p2percent)
            {
                p1launchright = 0;
                p1RightLaunchTimer.Enabled = false;
            }
        }

        private void timer14_Tick(object sender, EventArgs e)//leftdisplaytimer
        {
            p1punchleftdis++;


            pictureBox1.Image = Properties.Resources.magic_mayo;

            if (p1punchleftdis >= 7)
            {
                p1punchleftdis = 0;
                p1LeftDisplayTimer.Enabled = false;
                p1Punchleft = false;
                pictureBox1.Size = new Size(86, 94);
                pictureBox1.Image = Properties.Resources.mayo;
            }
        }

        private void timer15_Tick(object sender, EventArgs e)//p1punchdown
        {
            p1punchdowndis++;

            pictureBox1.Image = Properties.Resources.BOOTS;

            if (p1punchdowndis >= 7)
            {
                p1punchdowndis = 0;
                p1DownDisplayTimer.Enabled = false;
                p1Punchdown = false;
                pictureBox1.Size = new Size(86, 94);
                pictureBox1.Image = Properties.Resources.mayo;
            }
        }

        private void p1RightDisplayTimer_Tick(object sender, EventArgs e)
        {
             p1punchrightdis++;

            label9.Text = p1punchrightdis.ToString();

            pictureBox1.Image = Properties.Resources.mayoPR;

            if (p1punchrightdis >= 7)
            {
                p1punchrightdis = 0;
                p1RightDisplayTimer.Enabled = false;
                p1Punchright = false;
                pictureBox1.Size = new Size(86, 94);
                pictureBox1.Image = Properties.Resources.mayo;
            }
        }

        private void p1DownLaunchTimer_Tick(object sender, EventArgs e)
        {
            p1launchdown++;

            Point rightpunch = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + p2percent);

            pictureBox2.Location = rightpunch;

            if (p1launchdown >= p2percent)
            {
                p1launchdown = 0;
                p1DownLaunchTimer.Enabled = false;
            }

        }

        private void label5_Click(object sender, EventArgs e)//secret
        {

        }

        private void timer13_Tick(object sender, EventArgs e)//leftlaunchtimer
        {
            p1launchleft++;

            label10.Text = p1launchleft.ToString();

            Point leftpunch = new Point(pictureBox2.Location.X - p2percent, pictureBox2.Location.Y );

            pictureBox2.Location = leftpunch;

            if (p1launchleft >= p2percent)
            {
                p1launchleft = 0;
                timer13.Enabled = false;
            }
        }
    }
}
