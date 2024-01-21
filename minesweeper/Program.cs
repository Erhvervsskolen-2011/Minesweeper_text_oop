using minesweeper;

const int lines = 10;
const int columns = 20;

// Her bruger jeg "bare" et to-dim array af simple chars (et bogstav)

Minecell[,] pad = new Minecell[columns, lines];

for (int column = 0; column < pad.GetLength(0); column++) 
{ 
  for (int line = 0; line < pad.GetLength(1); line++) 
  { 
    // pad[column,line] = '▓';
    // Console.WriteLine(pad[i, j]);
    pad[column,line] = new Minecell(column, line, pad);
  } 
}  

const int top = 1;
const int left = 2; 

void drawRedCursor(int x, int y)
{
    Console.SetCursorPosition(top + x, left + y);
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Write(pad[x, y].symbol);
}

void removeRedCursor(int x, int y)
{
    Console.SetCursorPosition(top + x, left + y);
    Console.ResetColor();
    Console.Write(pad[x, y].symbol);
}

// udskriv pladen

Console.Clear();

for (int column = 0; column < pad.GetLength(0); column++) 
{ 
  for (int line = 0; line < pad.GetLength(1); line++) 
  { 
    Console.SetCursorPosition(top+column, left+line);
    Console.Write(pad[column, line].symbol); 
  } 
}  

// PLAY

// try fordi jeg gerne vil sætte cursor til igen
try
{
    // sluk cursor, fordi det ikke ser fedt ud
    Console.CursorVisible = false;

    bool gameover = false;

    // set cursoren ind øverst til venstre

    int currentLine = 0;
    int currentColumn = 0; 
    Console.SetCursorPosition(top, left);
    drawRedCursor(currentColumn, currentLine);

    while (!gameover) 
    {
        System.ConsoleKey pressedKey = Console.ReadKey().Key;

        switch (pressedKey) 
        {
            case ConsoleKey.Escape:
                gameover = true;
                break;
            case ConsoleKey.Backspace:
                pad[currentColumn, currentLine].setFlag();
                break;

            case ConsoleKey.Enter:
                pad[currentColumn, currentLine].clear();
                break;

            case ConsoleKey.UpArrow:
                if (currentLine > 0)
                {
                    removeRedCursor(currentColumn, currentLine);
                    currentLine--;
                }
                break;   
            case ConsoleKey.DownArrow:
                if (currentLine < lines-1)
                {
                    removeRedCursor(currentColumn, currentLine);
                    currentLine++;
                }
                break;   
            case ConsoleKey.LeftArrow:
                if (currentColumn > 0)
                {
                    removeRedCursor(currentColumn, currentLine);
                    currentColumn--;
                }
                break;   
            case ConsoleKey.RightArrow:
                if (currentColumn < columns-1)
                {
                    // Console.SetCursorPosition( top+currentColumn, left+currentLine);
                    // Console.ResetColor();
                    // Console.Write(pad[currentColumn, currentLine]);
                    removeRedCursor(currentColumn, currentLine);
                    currentColumn++;
                }
                break;   


        }
        // Console.SetCursorPosition( top+currentColumn, left+currentLine);
        // Console.BackgroundColor = ConsoleColor.DarkRed;
        // Console.Write(pad[currentColumn, currentLine]);
        drawRedCursor(currentColumn, currentLine);

    }

}
finally {
    Console.CursorVisible = true;
    Console.ResetColor();
}