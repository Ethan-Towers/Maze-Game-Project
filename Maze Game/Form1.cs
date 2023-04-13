namespace Maze_Game
{
    public partial class Form1 : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 3;
        public Form1()
        {
            InitializeComponent();
            pictureBox238.Location = new Point(284, 8); //sets the movement peice start position
        }

        private void keyDown(object sender, KeyEventArgs e) //moves the peice when a key is pressed down
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
        }

        private void keyUp(object sender, KeyEventArgs e) //stops the movement when the key is released
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
        }

        private void moveTimerEvent(object sender, EventArgs e) //move timer at 20ms gives a velocity to the moving peice
        {
            if(moveLeft == true)
            {
                pictureBox238.Left -= speed;
            }
            if (moveRight == true)
            {
                pictureBox238.Left += speed;
            }
            if (moveUp == true)
            {
                pictureBox238.Top -= speed;
            }
            if (moveDown == true)
            {
                pictureBox238.Top += speed;
            }

            if (pictureBox238.Bounds.IntersectsWith(pictureBox237.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);

                if (moveLeft == true)
                {
                    moveLeft = false;
                }
                if (moveRight == true)
                {
                    moveRight = false;
                }
                if (moveUp == true)
                {
                    moveUp = false;
                }
                if (moveDown == true)
                {
                    moveDown = false;
                }
                MessageBox.Show("You have completed the maze. Congratulations!");
            }

            //All code below is setting the boundaries for the maze. If the moving peice hits one of the boundaries, it gets reset to the start.
            if (pictureBox238.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox17.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox19.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox21.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox22.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox23.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox24.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox25.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox26.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox27.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox28.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox29.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox30.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox31.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox32.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox33.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox34.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox35.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox36.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox37.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox38.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox39.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox40.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox41.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox42.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox43.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox44.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox45.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox46.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox47.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox48.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox49.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox50.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox51.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox52.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox53.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox54.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox55.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox56.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox57.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox58.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox59.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox60.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox61.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox62.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox63.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox64.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox65.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox66.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox67.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox68.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox69.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox70.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox71.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox72.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox73.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox74.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox75.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox76.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox77.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox78.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox79.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox80.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox81.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox82.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox83.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox84.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox85.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox86.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox87.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox88.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox89.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox90.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox91.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox92.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox93.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox94.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox95.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox96.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox97.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox98.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox99.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox100.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox101.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox102.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox103.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox104.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox105.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox106.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox107.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox108.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox109.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox110.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox111.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox112.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox113.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox114.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox115.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox116.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox117.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox118.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox119.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox120.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox121.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox122.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox123.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox124.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox125.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox126.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox127.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox128.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox129.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox130.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox131.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox132.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox133.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox134.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox135.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox136.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox137.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox138.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox139.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox140.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox141.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox142.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox143.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox144.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox145.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox146.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox147.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox148.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox149.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox150.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox151.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox152.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox153.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox154.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox155.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox156.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox157.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox158.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox159.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox160.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox161.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox162.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox163.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox164.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox165.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox166.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox167.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox168.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox169.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox170.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox171.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox172.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox173.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox174.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox175.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox176.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox177.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox178.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox179.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox180.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox181.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox182.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox183.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox184.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox185.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox186.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox187.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox188.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox189.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox190.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox191.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox192.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox193.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox194.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox195.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox196.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox197.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox198.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox199.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox200.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox201.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox202.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox203.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox204.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox205.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox206.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox207.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox208.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox209.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox210.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox211.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox212.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox213.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox215.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox216.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox217.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox218.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox219.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox220.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox221.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox222.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox223.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox224.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox225.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox226.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox227.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox228.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox229.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox230.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox231.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox232.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox233.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox234.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
            if (pictureBox238.Bounds.IntersectsWith(pictureBox235.Bounds))
            {
                pictureBox238.Location = new Point(284, 8);
            }
        }


    }
}