﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsChess
{
    class Hourse : Figures
    {
        public Hourse(int x,int y,bool a):base(x,y)
        {
            Position_X = x;
            Positiont_Y = y;
            is_black = a;
            is_king = false;
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

        public override void Move(int x, int y)
        {
            if (x == Position_X + 2 && y == Positiont_Y + 1)
            {
                Position_X = x;
                Positiont_Y = y;
                Game.SuccessfulMove = true;
                return;
            }

            if (x == Position_X - 2 && y == Positiont_Y - 1)
            {
                Position_X = x;
                Positiont_Y = y;
                Game.SuccessfulMove = true;
                return;
            }
            else
            if (x == Position_X - 2 && y == Positiont_Y + 1)
            {
                Position_X = x;
                Positiont_Y = y;
                Game.SuccessfulMove = true;
                return;
            }
            else
            if (x == Position_X + 2 && y == Positiont_Y - 1)
            {
                Position_X = x;
                Positiont_Y = y;
                Game.SuccessfulMove = true;
                return;
            }
            else
            if (x == Position_X + 1 && y == Positiont_Y + 2)
            {
                Position_X = x;
                Positiont_Y = y;
                Game.SuccessfulMove = true;
                return;
            }
            else
            if (x == Position_X - 1 && y == Positiont_Y - 2)
            {
                Position_X = x;
                Positiont_Y = y;
                Game.SuccessfulMove = true;
                return;
            }
            else
            if (x == Position_X - 1 && y == Positiont_Y + 2)
            {
                Position_X = x;
                Positiont_Y = y;
                Game.SuccessfulMove = true;
                return;
            }
            else
            if (x == Position_X + 1 && y == Positiont_Y - 2)
            {
                Position_X = x;
                Positiont_Y = y;
                Game.SuccessfulMove = true;
                return;
            }
            else
            {
                Game.SuccessfulMove = false;
                MessageBox.Show("This mowe is not try!");
            }

        }
    }
}
