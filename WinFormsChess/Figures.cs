using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChess
{
    abstract class Figures
    {
        public bool Cheking_Road { get; set; }
        public int Position_X {get; set; }
        public int Positiont_Y { get; set; }
        public bool is_black { get; set; }

        public int Position_Figures_On_Picture { get; set; }
        public int Position_Figyre_On_Picture_Down { get; set; }
        public bool Drow { get; set; }

        public Figures(int x, int y)
        {
            Position_X = x;
            Positiont_Y = y;
        }
        public abstract void Move(int x,int y);
        public abstract void Attack(List<Figures> list, int x, int y);
    }
}
