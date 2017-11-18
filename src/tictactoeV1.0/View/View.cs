using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        
interface View
{
    ViewDelegate viewDelegate { get; set; }
    void print(int[,] array);
    void gameOver(Point point); 
}
