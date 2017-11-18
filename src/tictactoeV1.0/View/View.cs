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
        //вывод игрового поля в консоль и вывод знака (Х\О) текущего игрока
    }
    
    public void gameOver(Value value)
    {
        //вывод знака (Х\О) победителя
    }
}
