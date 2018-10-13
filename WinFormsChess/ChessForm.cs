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
        public Chess()
        {
            InitializeComponent();
            Take_Paste = true;
            game = new Game();
            box = new PictureBox();
            figures =  new List<Figures>()
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
                new Qween (3,0,false),
                new Qween (3,7,true),
                new King (4,0,false),
                new King (4,7,true),
             };
        }


        //выход ис игры
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // отрисовка по собитию
    public void Drow_ALL()
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
                if (figures[i].Drow)
                {
                    Rectangle sorce = new Rectangle(figures[i].Position_Figures_On_Picture, figures[i].Position_Figyre_On_Picture_Down, 50, 50);
                    Rectangle dest = new Rectangle(figures[i].Position_X * 50, figures[i].Positiont_Y * 50, 50, 50);
                    g.DrawImage(b, dest, sorce, GraphicsUnit.Pixel);
                }
            }
            g.Dispose();
        }

        // отрисовка при запуске
        public void PaintTable(object sender, PaintEventArgs e)
        {
            Graphics g = PanelChess.CreateGraphics();
            Bitmap b = new Bitmap(@"figures2.png");
            b.MakeTransparent(Color.FromArgb(100, 100, 100));
            int square = 50;
            int size_cage = 8;
            Size size = new Size(square, square);
            //рісуєм доску
            for (int i = 0; i < size_cage; i++)
            {
                for (int j = 0;j < size_cage; j++)
                {
                    Point point = new Point(j * square, i * square);
                    Rectangle r = new Rectangle(point, size);
                    if ((i % 2==0 && j %2 == 0) || (i % 2!=0 && j % 2 != 0)) 
                    {
                        g.FillRectangle(Brushes.Chocolate,r);

                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, r);
   
                    }
                }
            }
            //рисуєм фігуру
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i].Drow)
                {
                    Rectangle sorce = new Rectangle(figures[i].Position_Figures_On_Picture, figures[i].Position_Figyre_On_Picture_Down, 50, 50);//фигура на рисунке
                    Rectangle dest = new Rectangle(figures[i].Position_X * 50, figures[i].Positiont_Y * 50, 50, 50);//фигура на доске
                    g.DrawImage(b, dest, sorce, GraphicsUnit.Pixel);
                }
            }
            g.Dispose();
            g.Dispose();
        }

  
        //Реализовать старт игры
        private void StartGame_Click(object sender, EventArgs e)
        {
            
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
            if(Take_Paste)//взять фигуру
            {
                x = game.Retutn_Coordinats(e.X);
                y = game.Retutn_Coordinats(e.Y);
                for (int i = 0; i < figures.Count; i++)
                {
                    if(y == figures[i].Positiont_Y && x == figures[i].Position_X)
                    {
                        Position = i;
                        Take_Paste = false;
                        break;
                    }
                }
            }
            else//установить фигуру
            {
                //ход фигур
                    if (game.Empty_Cage(figures, game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y)))
                    {
                       if(figures[Position].Cheking_Road)
                         {
                            if(game.Free_Road(figures,
                                               figures[Position].Position_X,
                                               figures[Position].Positiont_Y,
                                               game.Retutn_Coordinats(e.X),
                                               game.Retutn_Coordinats(e.Y)))
                                 {
                                     figures[Position].Move(game.Retutn_Coordinats(e.X), game.Retutn_Coordinats(e.Y));
                                     Drow_ALL();
                                     Take_Paste = true;
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
                                Drow_ALL();
                                Take_Paste = true;
                            }
                    }
                    //атака фигур
                    else if(figures[Position].is_black != game.Black_Or_Whiite(figures,game.Retutn_Coordinats(e.X),game.Retutn_Coordinats(e.Y)))
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
                            Drow_ALL();
                            Take_Paste = true;
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
                        Drow_ALL();
                        Take_Paste = true;
                    }
                    }
                    else
                    {
                        MessageBox.Show("The move is not possible!");
                        Drow_ALL();
                        Take_Paste = true;

                    }
                
               
            }
        }
    }
}
