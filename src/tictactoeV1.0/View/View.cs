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
        Console.WriteLine("====================================================");
        Console.WriteLine("\t{0}\t||\t{1}\t||\t{2}", gamefield[0, 0], gamefield[0, 1], gamefield[0, 2]);//вывод игрового поля в консоль и вывод знака (Х\О) текущего игрока 
        Console.WriteLine("====================================================");
        Console.WriteLine("\t{0}\t||\t{1}\t||\t{2}", gamefield[1, 0], gamefield[1, 1], gamefield[1, 2]);
        Console.WriteLine("====================================================");
        Console.WriteLine("\t{0}\t||\t{1}\t||\t{2}", gamefield[2, 0], gamefield[2, 1], gamefield[2, 2]);
        Console.WriteLine("====================================================");
        Console.WriteLine("{0} turn", currentValue);
        Point position;
        int x = 0;
        int y = 0;
        
        Console.WriteLine("enter y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Good");
        Console.WriteLine("enter x: ");
        x = Convert.ToInt32(Console.ReadLine());

        position.x = x;
        position.y = y;

        /*string s,sx,sy;
        Console.WriteLine("kek");
        s = Console.ReadLine();
        Console.WriteLine(s);
        sy = s.Substring(0);
        sx = s.Substring(s.IndexOf(" "));
        
        Console.WriteLine("ahahah {0}",s.IndexOf(" "));
        x = Convert.ToInt32(sy);
        Console.WriteLine("aga {0} {1}",x,y);
        */
       // Console.Read();
        
        viewDelegate.set(currentValue, position);

    }

    public void showError(String message)
    {
        Console.WriteLine(message);
    }

    public void gameOver(Value value)
    {   
        Console.WriteLine("{0} won", value);//вывод знака (Х\О) победителя
        Console.ReadKey();
    }
}
