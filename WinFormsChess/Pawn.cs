using System;
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
            is_king = false;
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
            Cheking_Road = true;
        }

        
        public override void Move(int x,int y)
        {
            if(!(is_black))
            {
                if (x != Position_X)
                {
                    Game.SuccessfulMove = false;
                    return;
                }
                else if (y < Positiont_Y)
                {
                    Game.SuccessfulMove = false;
                    return;
                }
                else if (Positiont_Y == 1 && y == Positiont_Y + 2)
                {
                    Position_X = x;
                    Positiont_Y = y;
                    Game.SuccessfulMove = true;
                    Cheking_Road = false;
                }
                else if (y > Positiont_Y + 1)
                {
                    Game.SuccessfulMove = false;
                    return;
                }
                else
                {
                    Position_X = x;
                    Positiont_Y = y;
                    Game.SuccessfulMove = true;
                }
            }
            else
            {
                if (x != Position_X)
                {
                    Game.SuccessfulMove = false;
                    return;
                }
                else if (y > Positiont_Y)
                {
                    Game.SuccessfulMove = false;
                    return;
                }
                else if (Positiont_Y == 6 && y == Positiont_Y - 2)
                {
                    Position_X = x;
                    Positiont_Y = y;
                    Game.SuccessfulMove = true;
                    Cheking_Road = false;
                }
                else if (y < Positiont_Y - 1)
                {
                    Game.SuccessfulMove = false;
                    return;
                }
                else
                {
                    Position_X = x;
                    Positiont_Y = y;
                    Game.SuccessfulMove = true;
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
                else if (x == Position_X + 1 && y == Positiont_Y + 1)
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
}
