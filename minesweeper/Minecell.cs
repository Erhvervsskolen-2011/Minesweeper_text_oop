using System.Runtime.InteropServices;

namespace minesweeper
{
    public class Minecell
    {
        private bool hasMine = false;
        int x;
        int y;

        Minecell[] nabours;

        public char symbol = '▓';

        public int nearbymines = 0;

        Minecell[] findNabours(Minecell[,] pad)
        {
            //fake
            return new Minecell[] {this};
        }

        int countNearbymines(Minecell[] nabours)
        {
            //fake 
            return 0;
        }

        public bool clear()
        {
            if (this.hasMine)
            {
                this.symbol = '*';
                return false;
            }
            else
            {
                this.symbol = '░';
                return true;
            }
            //clear nabours
        }

        public void setFlag()
        {
            this.symbol = '⚑';
        }

        public Minecell(int x, int y, Minecell[,] pad)
        {
            nabours = findNabours(pad);
        }
    }
}
