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
        Console.WriteLine("                                 __|__|__"); //вывод игрового поля в консоль и вывод знака (Х\О) текущего игрока
        Console.WriteLine("                                 __|__|__");
        Console.WriteLine("                                   |  |  "); //надо повставлять ссылки в каждую из клеток на знак "пустое" "Х" "0" значения(я так понял), только я не знаю как 


        Console.ReadKey();
    }
    public void gameOver(Value value)
    {
        Console.WriteLine("");//вывод знака (Х\О) победителя, здесь ссылка на того кто выиграл


        Console.ReadKey();

    }
}
