using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsChess
{
    class Game
    {
        public static  bool SuccessfulMove { get; set; }//ход удачний или нет
        public bool Empty_Cage(List<Figures> list,int x,int y)//проверка пустое ли поле
        {
            

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Position_X == x && list[i].Positiont_Y == y)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Black_Or_Whiite(List<Figures> list,int position_x,int position_y)// проверка фигур(чорна или белая) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Position_X == position_x && list[i].Positiont_Y == position_y)
                {
                    return list[i].is_black;
                }
            }
            return false;
        }

        //проверка на свободний путь для хода фигури
        public bool Free_Road(List<Figures> list,
                                int position_on_fild_now_X,
                                int position_on_fild_now_Y,
                                int where_to_go_X,
                                int where_to_go_Y)
        {
            int count = 0;
            if(position_on_fild_now_X == where_to_go_X && position_on_fild_now_Y < where_to_go_Y)
            {
                count = 0;
                for (int i = position_on_fild_now_Y+1; i < where_to_go_Y; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if(position_on_fild_now_X == list[j].Position_X && i == list[j].Positiont_Y)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        break;
                }
            }
           else  if(position_on_fild_now_X == where_to_go_X && position_on_fild_now_Y > where_to_go_Y)
            {
                count=0;
               for(int i = position_on_fild_now_Y-1; i > where_to_go_Y;i--)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (position_on_fild_now_X == list[j].Position_X && i == list[j].Positiont_Y)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        break;
                }
            }
            else if (position_on_fild_now_X < where_to_go_X && position_on_fild_now_Y == where_to_go_Y)
            {
                count=0;
                for (int i = position_on_fild_now_X+1; i < where_to_go_X; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (i == list[j].Position_X && position_on_fild_now_Y == list[j].Positiont_Y)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        break;
                }
            }
            else if (position_on_fild_now_X > where_to_go_X && position_on_fild_now_Y == where_to_go_Y)
            {
                count=0; 
                for(int i = position_on_fild_now_X-1; i > where_to_go_X; i--)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (i == list[j].Position_X && position_on_fild_now_Y == list[j].Positiont_Y)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        break;
                }
            }
            else if(position_on_fild_now_X < where_to_go_X && position_on_fild_now_Y < where_to_go_Y)
            { 
                count = 0;
                int y = position_on_fild_now_Y + 1;
                for(int i = position_on_fild_now_X + 1;i < where_to_go_X;i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if(i == list[j].Position_X && y == list[j].Positiont_Y)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        break;
                    else
                         y++;
                }
            }
            else if(position_on_fild_now_X > where_to_go_X && position_on_fild_now_Y < where_to_go_Y)
            {
                count = 0;
                int y = position_on_fild_now_Y + 1;
                for(int i = position_on_fild_now_X -1; i > where_to_go_X; i--)
                {
                    for(int j = 0; j < list.Count; j++)
                    {
                        if (i == list[j].Position_X && y == list[j].Positiont_Y)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        break;
                    else
                        y++;
                }
            }
            else if(position_on_fild_now_X < where_to_go_X && position_on_fild_now_Y > where_to_go_Y)
            {
                count = 0;
                int y = position_on_fild_now_Y - 1;
                for(int  i = position_on_fild_now_X+1; i < where_to_go_X; i++)
                {
                    for(int j= 0; j < list.Count;j++)
                    {
                        if (i == list[j].Position_X && y == list[j].Positiont_Y)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        break;
                    else
                        y--;
                }
            }
            else if(position_on_fild_now_X > where_to_go_X && position_on_fild_now_Y > where_to_go_Y)
            {
                count = 0;
                int y = position_on_fild_now_Y - 1;
                for(int i = position_on_fild_now_X -1; i > where_to_go_X; i--)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (i == list[j].Position_X && y == list[j].Positiont_Y)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        break;
                    else
                        y--;
                }
            }
            if (count > 0)
                return false;
            return true;
        }

        //получение координат клетки поля
        public int Retutn_Coordinats(int coordinates)
        {
            
            
            if (coordinates < 50)
            {
                return 0;
            }
            else if (coordinates > 50 && coordinates < 100)
            {
                return 1;
            }
            else if (coordinates > 100 && coordinates < 150)
            {
                return 2;
            }
            else if (coordinates > 150 && coordinates < 200)
            {
                return 3;
            }
            else if (coordinates > 200 && coordinates < 250)
            {
                return 4;
            }
            else if (coordinates > 250 && coordinates < 300)
            {
                return 5;
            }
            else if (coordinates > 300 && coordinates < 350)
            {
                return 6;
            }
            else if(coordinates > 350 && coordinates < 400)
            {
                return 7;
            }
            else
                return 0;
        }
      
    }
}
