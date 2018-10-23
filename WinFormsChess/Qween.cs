using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsChess
{
    class Qween : Figures
    {
        public Qween(int x,int y,bool a):base(x,y)
        {
            Position_X = x;
            Positiont_Y = y;
            is_king = false;
            is_black = a;
            Cheking_Road = true;
            if (is_black)
                Position_Figyre_On_Picture_Down = 50;
            else
                Position_Figyre_On_Picture_Down = 0;
            Position_Figures_On_Picture = 0;
        }

        public override void Attack(List<Figures> list, int x, int y)
        {
            if (Position_X > x && y == Positiont_Y)
            {
                for(int j = Position_X;j >= 0;j--)
                {

                    if (x == j && y == Positiont_Y)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].is_black != is_black)
                            {
                                if (x == list[i].Position_X && y == list[i].Positiont_Y)
                                {
                                    list.Remove(list[i]);

                                    Position_X = x;
                                    Positiont_Y = y;
                                    Game.SuccessfulMove = true;
                                    break;
                                }
                                else
                                {
                                    Game.SuccessfulMove = false;
                                }
                            }
                        }
                    }
                }
            }
            else if (Position_X < x && y == Positiont_Y)
            {
                for (int j = Position_X; j <= x; j++)
                {
                    if (x == j && y == Positiont_Y)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].is_black != is_black)
                            {
                                if (x == list[i].Position_X && y == list[i].Positiont_Y)
                                {
                                    list.Remove(list[i]);

                                    Position_X = x;
                                    Positiont_Y = y;
                                    Game.SuccessfulMove = true;
                                    break;
                                }
                                else
                                {
                                    Game.SuccessfulMove = false;
                                }
                            }
                        }
                    }
                }
            }
            else if (Position_X == x && Positiont_Y > y)
            {
                    for(int j = Positiont_Y;j >= 0;j--)
                {
                    if (x == Position_X && y == j)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].is_black != is_black)
                            {
                                if (x == list[i].Position_X && y == list[i].Positiont_Y)
                                {
                                    list.Remove(list[i]);

                                    Position_X = x;
                                    Positiont_Y = y;
                                    Game.SuccessfulMove = true;
                                    break;
                                }
                                else
                                {
                                    Game.SuccessfulMove = false;
                                }
                            }
                        }
                    }
                }
            }
            else if (Position_X == x && Positiont_Y < y)
            {
                for (int j = Positiont_Y; j <= y; j++)
                {
                    if (x == Position_X && y == j)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].is_black != is_black)
                            {
                                if (x == list[i].Position_X && y == list[i].Positiont_Y)
                                {
                                    list.Remove(list[i]);

                                    Position_X = x;
                                    Positiont_Y = y;
                                    Game.SuccessfulMove = true;
                                    break;
                                }
                                else
                                {
                                    Game.SuccessfulMove = false;
                                }
                            }
                        }
                    }
                }
            }
            else if (x > Position_X && y > Positiont_Y)
            {

                for (int j = 0; j < 8; j++)
                {
                    if (Position_X + j == x && Positiont_Y + j == y)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].is_black != is_black)
                            {
                                if (x == list[i].Position_X && y == list[i].Positiont_Y)
                                {
                                    list.Remove(list[i]);

                                    Position_X = x;
                                    Positiont_Y = y;
                                    Game.SuccessfulMove = true;
                                    break;
                                }
                                else
                                {
                                    Game.SuccessfulMove = false;
                                }
                            }
                        }
                    }

                }
            }
            else if (x < Position_X && y < Positiont_Y)
            {
                for (int j = 7; j >= 0; j--)
                {
                    if (Position_X - j == x && Positiont_Y - j == y)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].is_black != is_black)
                            {
                                if (x == list[i].Position_X && y == list[i].Positiont_Y)
                                {
                                    list.Remove(list[i]);

                                    Position_X = x;
                                    Positiont_Y = y;
                                    Game.SuccessfulMove = true;
                                    break;
                                }
                                else
                                {
                                    Game.SuccessfulMove = false;
                                }
                            }
                        }
                    }
                }
            }
            else if (x > Position_X && y < Positiont_Y)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Position_X + j == x && Positiont_Y - j == y)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].is_black != is_black)
                            {
                                if (x == list[i].Position_X && y == list[i].Positiont_Y)
                                {
                                    list.Remove(list[i]);

                                    Position_X = x;
                                    Positiont_Y = y;
                                    Game.SuccessfulMove = true;
                                    break;
                                }
                                else
                                {
                                    Game.SuccessfulMove = false;
                                }
                            }
                        }
                    }
                }
            }
            else if (x < Position_X && y > Positiont_Y)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Position_X - j == x && Positiont_Y + j == y)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].is_black != is_black)
                            {
                                if (x == list[i].Position_X && y == list[i].Positiont_Y)
                                {
                                    list.Remove(list[i]);

                                    Position_X = x;
                                    Positiont_Y = y;
                                    Game.SuccessfulMove = true;
                                    break;
                                }
                                else
                                {
                                    Game.SuccessfulMove = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        public override void Move(int x, int y)
        {
            if (Position_X > x && y == Positiont_Y)
            {
                while (Position_X-- > 0)
                {

                    if (x == Position_X && y == Positiont_Y)
                    {
                        Position_X = x;
                        Positiont_Y = y;
                        Game.SuccessfulMove = true;
                        break;
                    }
                    else
                    {
                        Game.SuccessfulMove = false;
                    }
                }
            }
            else if (Position_X < x && y == Positiont_Y)
            {
                for (int i = Position_X; i <= x; i++)
                {
                    if (x == i && y == Positiont_Y)
                    {
                        Position_X = x;
                        Positiont_Y = y;
                        Game.SuccessfulMove = true;
                        break;
                    }
                    else
                    {
                        Game.SuccessfulMove = false;
                    }
                }
            }
            else if (Position_X == x && Positiont_Y > y)
            {
                while (Positiont_Y-- > 0)
                {
                    if (x == Position_X && y == Positiont_Y)
                    {
                        Position_X = x;
                        Positiont_Y = y;
                        Game.SuccessfulMove = true;
                        break;
                    }
                    else
                    {
                        Game.SuccessfulMove = false;
                    }
                }
            }
            else if (Position_X == x && Positiont_Y < y)
            {
                for (int i = Positiont_Y; i <= y; i++)
                {
                    if (x == Position_X && y == i)
                    {
                        Position_X = x;
                        Positiont_Y = y;
                        Game.SuccessfulMove = true;
                        break;
                    }
                    else
                    {
                        Game.SuccessfulMove = false;
                    }
                }
            }
            else if (x > Position_X && y > Positiont_Y)
            {

                for (int i = 1; i < 8; i++)
                {
                    if (Position_X + i == x && Positiont_Y + i == y)
                    {
                        Position_X = x;
                        Positiont_Y = y;
                        Game.SuccessfulMove = true;
                        break;
                    }
                    else
                    {
                        Game.SuccessfulMove = false;
                    }

                }
            }
            else if (x < Position_X && y < Positiont_Y)
            {
                for (int i = 7; i != 0; i--)
                {
                    if (Position_X - i == x && Positiont_Y - i == y)
                    {
                        Position_X = x;
                        Positiont_Y = y;
                        Game.SuccessfulMove = true;
                        break;
                    }
                    else
                    {
                        Game.SuccessfulMove = false;
                    }
                }
            }
            else if (x > Position_X && y < Positiont_Y)
            {
                for (int i = 1; i < 8; i++)
                {
                    if (Position_X + i == x && Positiont_Y - i == y)
                    {
                        Position_X = x;
                        Positiont_Y = y;
                        Game.SuccessfulMove = true;
                        break;
                    }
                    else
                    {
                        Game.SuccessfulMove = false;
                    }
                }
            }
            else if (x < Position_X && y > Positiont_Y)
            {
                for (int i = 1; i < 8; i++)
                {
                    if (Position_X - i == x && Positiont_Y + i == y)
                    {
                        Position_X = x;
                        Positiont_Y = y;
                        Game.SuccessfulMove = true;
                        break;
                    }
                    else
                    {
                        Game.SuccessfulMove = false;
                    }
                }
            }
        }
    }
}
