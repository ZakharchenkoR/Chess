﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChess
{
    class Pawn : Figures
    {
        
        public Pawn(int x,int y,bool a):base(x,y)
        {
            Position_X = x;
            Positiont_Y = y;
            Drow = true;
            is_black = a;
            Position_Figures_On_Picture = 250;
            if (is_black)
            {
                Position_Figyre_On_Picture_Down = 50;
            }
            else
            {
                Position_Figyre_On_Picture_Down = 0;
            }
            Cheking_Road = false;
        }

        
        public override void Move(int x,int y)
        {
            if(!(is_black))
            {
                if (x != Position_X)
                    return;
                else if (y < Positiont_Y)
                    return;
                else if (Positiont_Y == 1 && y == Positiont_Y + 2)
                {
                    Position_X = x;
                    Positiont_Y = y;
                }
                else if (y > Positiont_Y + 1)
                    return;
                else
                {
                    Position_X = x;
                    Positiont_Y = y;
                }
            }
            else
            {
                if (x != Position_X)
                    return;
                else if (y > Positiont_Y)
                    return;
                else if (Positiont_Y == 6 && y == Positiont_Y - 2)
                {
                    Position_X = x;
                    Positiont_Y = y;
                }
                else if (y < Positiont_Y - 1)
                    return;
                else
                {
                    Position_X = x;
                    Positiont_Y = y;
                }
            }
            
        }

        public override void Attack(List<Figures> list,int x,int y)
        {
            if(is_black)
            {
                if(x == Position_X -1 && y == Positiont_Y -1)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if(list[i].is_black != is_black)
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
                else if (x == Position_X + 1 && y == Positiont_Y - 1)
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
            else
            {
                if (x == Position_X - 1 && y == Positiont_Y + 1)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].is_black != is_black)
                        {
                            if (x == list[i].Position_X && y == list[i].Positiont_Y)
                            {
                                list[i].Drow = false;
                                list.Remove(list[i]);

                                Position_X = x;
                                Positiont_Y = y;
                                break;
                            }
                        }
                    }
                }
                else if (x == Position_X + 1 && y == Positiont_Y + 1)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].is_black != is_black)
                        {
                            if (x == list[i].Position_X && y == list[i].Positiont_Y)
                            {
                                list[i].Drow = false;
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
}