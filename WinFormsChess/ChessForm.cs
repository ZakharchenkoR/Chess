using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsChess
{
    public partial class Chess : Form
    {

        Game game;
        PictureBox box;
        List<Figures> figures;
        public int Position { get; set; }
        public bool Take_Paste { get; set; }
        public bool Black_or_White;
        public int a;
        public int b;
        public Chess()
        {
            InitializeComponent();
            Take_Paste = true;
            game = new Game();
            box = new PictureBox();
            Black_or_White = true;
            figures = new List<Figures>()
            {
                new Pawn(0,1,false),
                new Pawn(1,1,false),
                new Pawn(2,1,false),
                new Pawn(3,1,false),
                new Pawn(4,1,false),
                new Pawn(5,1,false),
                new Pawn(6,1,false),
                new Pawn(7,1,false),
                new Pawn(0,6,true),
                new Pawn(1,6,true),
                new Pawn(2,6,true),
                new Pawn(3,6,true),
                new Pawn(4,6,true),
                new Pawn(5,6,true),
                new Pawn(6,6,true),
                new Pawn(7,6,true),
                new Hourse(1,0,false),
                new Hourse(6,0,false),
                new Hourse(1,7,true),
                new Hourse(6,7,true),
                new Castle(0,0,false),
                new Castle(7,0,false),
                new Castle(0,7,true),
                new Castle(7,7,true),
                new Officer(2,0,false),
                new Officer (5,0,false),
                new Officer(2,7,true),
                new Officer(5,7,true),
                new Qween (4,0,false),
                new Qween (4,7,true),
                new King (3,0,false),
                new King (3,7,true),
            };
        }

        private void Restart()
        {
            Take_Paste = true;
            Black_or_White = true;
            figures.Clear();
            figures = new List<Figures>()
            {
                new Pawn(0,1,false),
                new Pawn(1,1,false),
                new Pawn(2,1,false),
                new Pawn(3,1,false),
                new Pawn(4,1,false),
                new Pawn(5,1,false),
                new Pawn(6,1,false),
                new Pawn(7,1,false),
                new Pawn(0,6,true),
                new Pawn(1,6,true),
                new Pawn(2,6,true),
                new Pawn(3,6,true),
                new Pawn(4,6,true),
                new Pawn(5,6,true),
                new Pawn(6,6,true),
                new Pawn(7,6,true),
                new Hourse(1,0,false),
                new Hourse(6,0,false),
                new Hourse(1,7,true),
                new Hourse(6,7,true),
                new Castle(0,0,false),
                new Castle(7,0,false),
                new Castle(0,7,true),
                new Castle(7,7,true),
                new Officer(2,0,false),
                new Officer (5,0,false),
                new Officer(2,7,true),
                new Officer(5,7,true),
                new Qween (4,0,false),
                new Qween (4,7,true),
                new King (3,0,false),
                new King (3,7,true),
            };
            Drow_ALL();
        }

        //выход ис игры
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // функция отрисовки
        private void Drow_ALL()
        {
                Graphics g = PanelChess.CreateGraphics();
                int square = 50;
                int size_cage = 8;
                Bitmap b = new Bitmap(@"figures2.png");
                b.MakeTransparent(Color.FromArgb(100, 100, 100));
                Size size = new Size(square, square);
                //рісуєм доску

                for (int i = 0; i < size_cage; i++)
                {
                    for (int j = 0; j < size_cage; j++)
                    {
                        Point point = new Point(j * square, i * square);
                        Rectangle r = new Rectangle(point, size);
                        if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                        {
                            g.FillRectangle(Brushes.Chocolate, r);

                        }
                        else
                        {
                            g.FillRectangle(Brushes.White, r);

                        }
                    }
                }

                //рісуєм фігуру
                for (int i = 0; i < figures.Count; i++)
                {
                        Rectangle sorce = new Rectangle(figures[i].Position_Figures_On_Picture, figures[i].Position_Figyre_On_Picture_Down, 50, 50);
                        Rectangle dest = new Rectangle(figures[i].Position_X * 50, figures[i].Positiont_Y * 50, 50, 50);
                        g.DrawImage(b, dest, sorce, GraphicsUnit.Pixel);
                }
            g.Dispose();
        }

        // отрисовка при запуске
        public void PaintTable(object sender, PaintEventArgs e)
        {

            Graphics g = PanelChess.CreateGraphics();
            int square = 50;
            int size_cage = 8;
            Bitmap b = new Bitmap(@"figures2.png");
            b.MakeTransparent(Color.FromArgb(100, 100, 100));
            Size size = new Size(square, square);
            //рісуєм доску

            for (int i = 0; i < size_cage; i++)
            {
                for (int j = 0; j < size_cage; j++)
                {
                    Point point = new Point(j * square, i * square);
                    Rectangle r = new Rectangle(point, size);
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                    {
                        g.FillRectangle(Brushes.Chocolate, r);

                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, r);

                    }
                }
            }
            
            for (int i = 0; i < figures.Count; i++)
            {
                    Rectangle sorce = new Rectangle(figures[i].Position_Figures_On_Picture, figures[i].Position_Figyre_On_Picture_Down, 50, 50);
                    Rectangle dest = new Rectangle(figures[i].Position_X * 50, figures[i].Positiont_Y * 50, 50, 50);
                    g.DrawImage(b, dest, sorce, GraphicsUnit.Pixel);
            }
            
            g.Dispose();
        }

        //отрисовка при ходе
        private void  Drow(int x,int y,int x1,int y1)
        {
            
            Graphics g = PanelChess.CreateGraphics();
            int square = 50;
            Bitmap b = new Bitmap(@"figures2.png");
            b.MakeTransparent(Color.FromArgb(100, 100, 100));
            Size size = new Size(square, square);
            Point point = new Point(x * square, y * square);
            Point point1 = new Point(x1 * square, y1 * square);
            Rectangle r = new Rectangle(point, size);
            Rectangle r2 = new Rectangle(point1, size);
            if ((x % 2 == 0 && y % 2 == 0) || (x % 2 != 0 && y % 2 != 0))
            {
                g.FillRectangle(Brushes.Chocolate, r);

            }
            else
            {
                g.FillRectangle(Brushes.White, r);

            }
            if ((x1 % 2 == 0 && y1 % 2 == 0) || (x1 % 2 != 0 && y1 % 2 != 0))
            {
                g.FillRectangle(Brushes.Chocolate, r2);

            }
            else
            {
                g.FillRectangle(Brushes.White, r2);

            }

            for (int i = 0; i < figures.Count; i++)
            {
                    Rectangle sorce = new Rectangle(figures[i].Position_Figures_On_Picture, figures[i].Position_Figyre_On_Picture_Down, 50, 50);
                    Rectangle dest = new Rectangle(figures[i].Position_X * 50, figures[i].Positiont_Y * 50, 50, 50);
                    g.DrawImage(b, dest, sorce, GraphicsUnit.Pixel);

            }

            g.Dispose();

        }

  
        //Рестарт игры
        private void StartGame_Click(object sender, EventArgs e)
        {
            Restart();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            box.Paint += new PaintEventHandler(this.PaintTable);
            this.Controls.Add(box);
        }

        private void Chess_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Pressed on play firld!");
        }


        // собитие клика(взять-установить фигуру)
        private void PanelChess_MouseClick(object sender, MouseEventArgs e)
        {

            int x;
            int y;
            if (Take_Paste)//взять фигуру
            {
                x = game.Retutn_Coordinats(e.X);
                y = game.Retutn_Coordinats(e.Y);
                if (Black_or_White)//ход белих
                {
                    if (!game.Black_Or_Whiite(figures, x, y))
                    {
                        for (int i = 0; i < figures.Count; i++)
                        {
                            if (y == figures[i].Positiont_Y && x == figures[i].Position_X)
                            {
                                Position = i;
                                Take_Paste = false;
                                a = game.Retutn_Coordinats(e.X);
                                b = game.Retutn_Coordinats(e.Y);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Now white move!");
                    }

                }
                else
                {
                    if (game.Black_Or_Whiite(figures, x, y))//хoд чорних
                    {
                        for (int i = 0; i < figures.Count; i++)
                        {
                            if (y == figures[i].Positiont_Y && x == figures[i].Position_X)
                            {
                                Position = i;
                                Take_Paste = false;
                                 a = x;
                                 b = y;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Now black move!");
                    }
                }
            }
            else//установить фигуру
            {
                //ход фигур
                if (game.Empty_Cage(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)))
                {
                    if (figures[Position].Cheking_Road)
                    {
                        if (game.Free_Road(figures,
                                           figures[Position].Position_X,
                                           figures[Position].Positiont_Y,
                                           game.Retutn_Coordinats(e.X),
                                           game.Retutn_Coordinats(e.Y)))
                        {
                            figures[Position].Move(game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                            Drow(a, b, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                            Take_Paste = true;
                            if(!game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)) && Game.SuccessfulMove)
                            {
                                Black_or_White = false;
                            }
                            else if(game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)) && Game.SuccessfulMove)
                            {
                                Black_or_White = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("The move is not possible!");
                            Take_Paste = true;
                        }
                    }
                    else
                    {
                        figures[Position].Move(game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                        Drow(a, b, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                        Take_Paste = true;
                        if (!game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)) && Game.SuccessfulMove)
                        {
                            Black_or_White = false;
                        }
                        else if (game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)) && Game.SuccessfulMove)
                        {
                            Black_or_White = true;
                        }
                    }
                }
                //атака фигур
                else if (figures[Position].is_black != game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)))
                {
                    if (figures[Position].Cheking_Road)
                    {
                        if (game.Free_Road(figures,
                                               figures[Position].Position_X,
                                               figures[Position].Positiont_Y,
                                               game.Retutn_Coordinats(e.X),
                                               game.Retutn_Coordinats(e.Y)))
                        {
                            figures[Position].Attack(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                            Drow(a, b, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                            Take_Paste = true;
                                if (!game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)) && Game.SuccessfulMove)
                                {
                                    Black_or_White = false;
                                }
                                else if (game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)) && Game.SuccessfulMove)
                                {
                                    Black_or_White = true;
                                }
                            }
                        else
                        {
                            MessageBox.Show("The move is not possible!");
                            Take_Paste = true;
                        }
                    }
                    else
                    {
                        figures[Position].Attack(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                        Drow(a, b, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                        Take_Paste = true;
                            if (!game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)) && Game.SuccessfulMove)
                            {
                                Black_or_White = false;
                            }
                            else if (game.Black_Or_Whiite(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)) && Game.SuccessfulMove)
                            {
                                Black_or_White = true;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("The move is not possible!");
                    Drow(a, b, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                    Take_Paste = true;

                }
                if(!game.Black_King_On_Fild(figures))
                {
                    MessageBox.Show("Black is loose!");
                    Restart();
                }
                else if(!game.White_King_On_Fild(figures))
                {
                    MessageBox.Show("White is loose!");
                    Restart();
                }

            }
        }

        private void information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To win you need to kill the enemy king");
        }
    }
}
