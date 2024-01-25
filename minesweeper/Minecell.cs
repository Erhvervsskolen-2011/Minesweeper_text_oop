using System.Runtime.InteropServices;

namespace minesweeper
{
    public class Minecell
    {
        public bool hasMine = false;
        int x;
        int y;

        Minecell[] nabours;

        public char symbol = '▓';

        public int nearbymines = 0;

        Minecell[] findNabours(Minecell[,] pad)
        {
            if (x == 0 && y == 0)
            {
                return new Minecell[] {                 pad[x+1, y],
                                        pad[x, y+1],    pad[x+1, y+1]
                };
            }
            else if (x == 0 && y == pad.GetLength(1)-1)
            {
                return new Minecell[] { pad[x, y-1],    pad[x+1, y-1],
                                                        pad[x+1, y],    
                };
            }
            else if (x == 0)
            {
                return new Minecell[] { pad[x, y-1],    pad[x+1, y-1],
                                                        pad[x+1, y],
                                        pad[x, y+1],    pad[x+1, y+1]
                };
            }
            
            if (x == pad.GetLength(0)-1 && y == 0)
            {
                return new Minecell[] { pad[x-1, y],    
                                        pad[x-1, y+1],  pad[x, y+1],
                };
            }
            else if (x == pad.GetLength(0)-1 && y == pad.GetLength(1)-1)
            {
                return new Minecell[] { pad[x-1, y-1],  pad[x, y-1],
                                        pad[x-1, y],
                };
            }
            else if (x == pad.GetLength(0)-1 ) 
            {
                return new Minecell[] { pad[x-1, y-1],  pad[x, y-1], 
                                        pad[x-1, y],
                                        pad[x-1, y+1],  pad[x, y+1],
                };
            }
            if (y == 0)
            {
                return new Minecell[] { pad[x-1, y],                    pad[x+1, y],
                                        pad[x-1, y+1],  pad[x, y+1],    pad[x+1, y+1]
                };
            }
            else if (y == pad.GetLength(1)-1)
            {
                return new Minecell[] { pad[x-1, y-1],  pad[x, y-1],    pad[x+1, y-1],
                                        pad[x-1, y],                    pad[x+1, y],
                };
            }
            
            else
            {
                return new Minecell[] { pad[x-1, y-1],  pad[x, y-1],    pad[x+1, y-1],
                                        pad[x-1, y],                    pad[x+1, y],
                                        pad[x-1, y+1],  pad[x, y+1],    pad[x+1, y+1]
                };
            }    
        }

        int countNearbymines(Minecell[] nabours)
        {
            System.Console.Write("n Nabours: " + nabours.Length);
            int mines = 0;
            foreach (Minecell cell in nabours)
            {
                if (cell.hasMine)
                    mines += 1;
            }
            //fake 
            return mines;
        }

        public bool clear()
        {
            this.nearbymines = this.countNearbymines(this.nabours);

            if (this.hasMine)
            {
                this.symbol = '*';
                return false;
            }
            else if (this.nearbymines > 0)
            {
                this.symbol = (char)this.nearbymines;
                return true;
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
            this.x = x;
            this.y = y;
            this.nabours = findNabours(pad);
        }
    }
}
