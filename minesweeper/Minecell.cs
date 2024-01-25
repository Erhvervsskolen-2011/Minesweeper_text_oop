using System.Runtime.InteropServices;

namespace minesweeper
{
    public class Minecell
    {
        public bool hasMine = false;
        int x;
        int y;

        Minecell[,] pad;
        Minecell[] nabours;
        public char symbol = '▓';
        public int nearbymines = 0;
        bool isCleared = false;

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
            // System.Console.Write("n Nabours: " + nabours.Length);
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
            this.nabours = this.findNabours(pad);
            this.nearbymines = this.countNearbymines(this.nabours);

            Console.ResetColor();
            if (this.hasMine)
            {
                this.symbol = '*';
                return false;
            }
            else if (this.nearbymines > 0)
            {
                this.symbol = Convert.ToString(this.nearbymines)[0];
                Console.SetCursorPosition(this.x, this.y);
                Console.Write(this.symbol);
                // Console.WriteLine(this.nearbymines);
            }
            else
            {
                this.isCleared = true;
                this.symbol = '░';
                Console.SetCursorPosition(this.x, this.y);
                Console.Write(this.symbol);
                foreach (Minecell cell in this.nabours)
                {
                    if (!cell.isCleared && !cell.hasMine)
                    {
                        cell.clear();
                    }
                }
                Console.SetCursorPosition(this.x, this.y);
            }
            return true;
        }

        public void setFlag()
        {
            this.symbol = '⚑';
        }

        public Minecell(int x, int y, Minecell[,] pad)
        {
            this.x = x;
            this.y = y;
            // this.nabours = findNabours(pad);
            this.pad = pad;
        }
    }
}
