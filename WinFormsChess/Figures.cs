using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChess
{
    abstract class Figures
    {
        public bool Cheking_Road { get; set; }//нада ли проверять для фигури стоит ли на ее пути другая фигура
        public bool is_king { get; set; }// король или не король
        public int Position_X {get; set; }
        public int Positiont_Y { get; set; }
        public bool is_black { get; set; }// цвет фигури

        public int Position_Figures_On_Picture { get; set; }//координати для
        public int Position_Figyre_On_Picture_Down { get; set; }//вирезания фигури с картинки

        public Figures(int x, int y)
        {
            Position_X = x;
            Positiont_Y = y;
        }
        public abstract void Move(int x,int y);
        public abstract void Attack(List<Figures> list, int x, int y);
    }
}
