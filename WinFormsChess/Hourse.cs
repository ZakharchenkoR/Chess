using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChess
{
    class Hourse : Figures
    {
        public Hourse(int x,int y,bool a):base(x,y)
        {
            Position_X = x;
            Positiont_Y = y;
            is_black = a;
            Drow = true;
            Cheking_Road = false;
            if (is_black)
                Position_Figyre_On_Picture_Down = 50;
            else
                 Position_Figyre_On_Picture_Down = 0;
            Position_Figures_On_Picture = 150;
        }
        public override void Attack(List<Figures> list, int x, int y)
        {

            if (x == Position_X + 2 && y == Positiont_Y + 1)
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

            if (x == Position_X - 2 && y == Positiont_Y - 1)
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

            if (x == Position_X - 2 && y == Positiont_Y + 1)
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
            if (x == Position_X + 2 && y == Positiont_Y - 1)
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

            if (x == Position_X + 1 && y == Positiont_Y + 2)
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

            if (x == Position_X - 1 && y == Positiont_Y - 2)
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

            if (x == Position_X - 1 && y == Positiont_Y + 2)
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

            if (x == Position_X + 1 && y == Positiont_Y - 2)
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

        public override void Move(int x, int y)
        {
            if (x == Position_X + 2 && y == Positiont_Y + 1)
            {
                Position_X = x;
                Positiont_Y = y;
                return;
            }

            if (x == Position_X - 2 && y == Positiont_Y - 1)
            {
                Position_X = x;
                Positiont_Y = y;
                return;
            }

            if (x == Position_X - 2 && y == Positiont_Y + 1)
            {
                Position_X = x;
                Positiont_Y = y;
                return;
            }
            if (x == Position_X + 2 && y == Positiont_Y - 1)
            {
                Position_X = x;
                Positiont_Y = y;
                return;
            }

            if (x == Position_X + 1 && y == Positiont_Y + 2)
            {
                Position_X = x;
                Positiont_Y = y;
                return;
            }

            if (x == Position_X - 1 && y == Positiont_Y - 2)
            {
                Position_X = x;
                Positiont_Y = y;
                return;
            }

            if (x == Position_X - 1 && y == Positiont_Y + 2)
            {
                Position_X = x;
                Positiont_Y = y;
                return;
            }

            if (x == Position_X + 1 && y == Positiont_Y - 2)
            {
                Position_X = x;
                Positiont_Y = y;
                return;
            }

        }
    }
}
