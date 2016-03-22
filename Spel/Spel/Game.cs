using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Spel
{
    class Game
    {
        // timer
        private DispatcherTimer timer;
        // canvas
        private Canvas canvas;
        // ball
        private Ball ball;
        // paddle
        public Paddle paddle;
        // blocks
        private List<Block> blocks;

        // constructor
        public Game(Canvas canvas)
        {
            this.canvas = canvas;
            CreateBall();
            CreatePaddle();
            CreateBlocks();
        }
        // create blocks
        private void CreateBlocks()
        {
            
            blocks = new List<Block>();
            int blocksCount = 120;
            int cols = 12;
            int xStartPos = 70;
            int yStartPos = 30;
            int step = 5;
            int row = 0;
            int col = 0;

            for (int i = 0; i < blocksCount; i++)
            {
                if (i % cols == 0 && i > 0)
                {
                    row++;
                    col = 0;

                }
                else if (i > 0)
                {
                    int x = (50 + step) * col + xStartPos;
                    int y = (20 + step) * row + yStartPos;

                    Block block = new Block
                    {
                        LocationX = x,
                        LocationY = y
                    };
                    blocks.Add(block);
                    canvas.Children.Add(block);
                    block.SetLocation();
                    col++;
                }
            }

          /*  int x = (50 + step) * col + xStartPos;
            int y = (20 + step) * row + yStartPos;

            Block block = new Block
            {
                LocationX = x, LocationY = y
            };
            //blocks.Add(block);
            canvas.Children.Add(block);
            block.SetLocation();*/
            
        }
        
        // create paddle
        private void CreatePaddle()
        {
            paddle = new Paddle
            {
                LocationX = 350, LocationY = 550
            };
            canvas.Children.Add(paddle);
        }

        // add ball to game
        private void CreateBall()
        {
            ball = new Ball
            {
                LocationX = 390, LocationY = 500
            };
            canvas.Children.Add(ball);
        }

        // start game
        public void StartGame()
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000/60); // 60 fps
            timer.Start();
        }

        //game loop
        private void Timer_Tick(object sender, object e)
        {
            ball.Move();
            checkCollision();
            IsGameOver();

        }

        private void IsGameOver()
        {
            // all blocks removed
            if(blocks.Count == 0)
            {
                Debug.WriteLine("Game ovah - wp");
                timer.Stop();
            }
            if(ball.LocationY > paddle.LocationY)
            {
                Debug.WriteLine("game ovah - bg");
                timer.Stop();
            }
        }

        private void checkCollision()
        {
            // ball and paddle
            Rect rect = ball.getRect();
            rect.Intersect(paddle.GetRect());
            if (!rect.IsEmpty)
            {
                // paddle 100 px
                // ball position 0-100
                double ballPosition = ball.LocationX - paddle.LocationX;
                // -0.5 <-> 0.5
                double hitPercent = (ballPosition / paddle.Width) - 0.5;
                // set ball speed
                ball.SetSpeed(hitPercent);
            }
            // ball and blocks
            foreach(Block block in blocks)
            {
                Rect ballRect = ball.getRect();
                ballRect.Intersect(block.GetRect());
                if (!ballRect.IsEmpty)
                {
                    blocks.Remove(block);
                    // remove from canvas
                    canvas.Children.Remove(block);
                    double ballCenter = ball.LocationX + (ball.Width) / 2;
                    if(ballCenter < block.LocationX || ballCenter > (block.LocationX + block.Width))
                    {
                        ball.SpeedX *= -1;
                    }
                    else
                    {
                        ball.SpeedY *= -1;
                    }
                    break;

                }
            }
           
        }
    }
}
