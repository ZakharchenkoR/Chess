using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsChess
{
    class Officer : Figures
    {
        public Officer(int x,int y,bool a):base(x,y)
        {
            Position_X = x;
            Positiont_Y = y;
            Drow = true;
            is_black = a;
            Cheking_Road = true;
            if (is_black)
                Position_Figyre_On_Picture_Down = 50;
            else
                 Position_Figyre_On_Picture_Down = 0;
            Position_Figures_On_Picture = 100;
        }
        public override void Attack(List<Figures> list, int x, int y)
        {
            if (x > Position_X && y > Positiont_Y)
            {

                for (int j = 1; j < 8; j++)
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
                                    break;
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
                                    break;
                                }
                            }
                        }
                    }
                    
                }
            }
            else if (x > Position_X && y < Positiont_Y)
            {
                for (int j = 1; j < 8; j++)
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
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else if (x < Position_X && y > Positiont_Y)
            {
                for (int j = 1; j < 8; j++)
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
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public override void Move(int x, int y)
        {
            if (x > Position_X && y > Positiont_Y)
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
            else if(x > Position_X && y < Positiont_Y)
            {
                for (int i = 1; i < 8; i++)
                {
                    if(Position_X + i == x && Positiont_Y - i == y)
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
            else if(x < Position_X && y > Positiont_Y)
            {
                for(int i =1;i < 8; i++)
                {
                    if(Position_X - i == x && Positiont_Y + i == y)
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
