using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        
class View
{
    public ViewDelegate viewDelegate { get; set; }
    public void print(Value[,] gamefield, Value currentValue)

    {
        Console.WriteLine("is turn:{0}", currentValue);//вывод знака который сделал ход
        Console.WriteLine("                                  __________________");
        Console.WriteLine("                                 |_{1}_|_{2}_|_{3}_|",gamefield[0][0],gamefield[0][1],gamefield[0][2]);//вывод игрового поля в консоль и вывод знака (Х\О) текущего игрока 
        Console.WriteLine("                                 |_{4}_|_{5}_|_{6}_|",gamefield[1][0],gamefield[1][1],gamefield[1][2]);
        Console.WriteLine("                                 |_{7}_|_{8}_|_{9}_|",gamefield[2][0],gamefield[2][1],gamefield[2][2]);
        
    }
    public void gameOver(Value value)
    {   
        Console.WriteLine("won:{0}", value);//вывод знака (Х\О) победителя
        Console.ReadKey();
    }
}
