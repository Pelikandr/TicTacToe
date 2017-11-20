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
        Console.WriteLine("                                 __|__|__");//вывод игрового поля в консоль и вывод знака (Х\О) текущего игрока 
        Console.WriteLine("                                 __|__|__");//в клетки, я так понимаю, надо ссылки повставлять на "пустое значение" "Х" и "0", только я не знаю где эти ссылки брать
        Console.WriteLine("                                   |  |  ");
    }
    public void gameOver(Value value)
    {
        Console.WriteLine("...");   //вывод знака (Х\О) победителя, ссылка на победное значние
        Console.ReadKey();
    }
}
