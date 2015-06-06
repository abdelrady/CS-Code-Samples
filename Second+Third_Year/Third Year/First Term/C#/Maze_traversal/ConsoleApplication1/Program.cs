using System;
using System.Collections.Generic;
//using System.Test;

namespace ConsoleApplication1
{
    class Program
    {
       /* static char[,] arr ={{'#','#','#','#','#','#','#','#','#','#','#','#'},
                             {'#','.','.','.','#','.','.','.','.','.','.','#'},
                             {'.','.','#','.','#','.','#','#','#','#','.','#'},
                             {'#','#','#','.','#','.','.','.','.','#','.','#'},
                             {'#','.','.','.','.','#','#','#','.','#','.','.'},
                             {'#','#','#','#','.','#','.','#','.','#','.','#'},
                             {'#','.','.','#','.','#','.','#','.','#','.','#'},
                             {'#','#','.','#','.','#','.','#','.','#','.','#'},
                             {'#','.','.','.','.','.','.','.','.','#','.','#'},
                             {'#','#','#','#','#','#','.','#','#','#','.','#'},
                             {'#','.','.','.','.','.','.','#','.','.','.','#'},
                             {'#','#','#','#','#','#','#','#','#','#','#','#'}};
        */
        static char[,] arr ={{'#','#','#','#','#','#','#','#','#','#','#','#'},
                             {'#','.','.','.','#','.','.','.','.','.','.','#'},
                             {'.','.','#','.','#','.','#','#','#','#','.','.'},
                             {'#','#','#','.','#','.','.','.','.','#','.','F'},
                             {'#','.','.','.','.','#','#','#','.','#','.','.'},
                             {'#','#','#','#','.','#','.','#','.','#','.','#'},
                             {'#','.','.','#','.','#','.','#','.','#','.','#'},
                             {'#','#','.','#','.','#','.','#','.','#','.','#'},
                             {'#','.','.','.','.','.','.','.','.','#','.','#'},
                             {'#','#','#','#','#','#','.','#','#','#','.','#'},
                             {'#','.','.','.','.','.','.','#','.','.','.','#'},
                             {'#','#','#','#','#','#','#','#','#','#','#','#'}};

        void display(char [,]a)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                    Console.Write(a[i, j].ToString());
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
 /**************************(MAZE)*****************************************/
        /*public int Maze(char[,] array, int r, int c)
        {
            if (r == 4 && c == 11)
            {
                array[r, c] = 'X';
                display(array);
                Console.WriteLine("the end ");
                return 0;
             }
            if (array[r, c] == '#')
            {
                Console.WriteLine("Invalid start");
                display(array);
                return 0 ;
            }
            if (array [r,c+1]!='#'&&array [r,c+1]!='X')
            {
                array [r,c]='X';
                display(array);
                return Maze (array ,r,c+1);
            }
             if (array[r - 1, c] != '#' && array[r - 1, c] != 'X')
            {
                array[r, c] = 'X';
                display(array);
                return Maze(array, r-1, c);
            }
             if (array[r + 1, c] != '#' && array[r + 1, c] != 'X')
            {
                array[r, c] = 'X';
                display(array);
                return Maze(array, r+1, c);
            }
            if (array[r , c-1] != '#' && array[r , c-1] != 'X')
            {
                array[r, c] = 'X';
                display(array);
                return Maze(array, r, c-1);
            }*/
       static int i = 0;
            public bool Maze(char[,] array, int r, int c)
        {
            if (array[r, c] == 'F')
            {
                //array[r, c] = 'X';
                display(array);
                Console.WriteLine("the end ");
                i++;
                return true;
            }
            else
            {
                
                    
                    if (array[r, c] == '#')
                    {
                        Console.WriteLine("Invalid start");
                        display(array);
                        return false;
                    }
                    
                    array[r, c] = 'X';
                    try
                    {
                        if (array[r, c + 1] != '#' && array[r, c + 1] != 'X')
                    {
                        
                        display(array);
                        Maze(array, r, c + 1);
                    }
                    }
                    catch (IndexOutOfRangeException ra)
                    {
                        Console.WriteLine(ra.Message);
                    }
                    try
                    {if (array[r - 1, c] != '#' && array[r - 1, c] != 'X')
                    {
                    //    array[r, c] = 'X';
                        display(array);
                        Maze(array, r - 1, c);
                    }
                    }
                    catch (IndexOutOfRangeException ra)
                    {
                        Console.WriteLine(ra.Message);
                    }
                    try
                    {if (array[r + 1, c] != '#' && array[r + 1, c] != 'X')
                    {
                      //  array[r, c] = 'X';
                        display(array);
                        Maze(array, r + 1, c);
                    }
                    }
                    catch (IndexOutOfRangeException ra)
                    {
                        Console.WriteLine(ra.Message);
                    }
                    try
                    {
                        if (array[r, c - 1] != '#' && array[r, c - 1] != 'X')
                    {
                        //array[r, c] = 'X';
                        display(array);
                        Maze(array, r, c - 1);
                    }
                    }
                    catch (IndexOutOfRangeException ra)
                    {
                        Console.WriteLine(ra.Message);
                    }
                
                
            }
            return false; 
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            bool a=p.Maze(arr, 2, 0);
          // Console.WriteLine(arr[2,0].ToString());
            Console.WriteLine(i.ToString());
        }
    }
}
