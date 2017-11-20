using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Model
    {
        private Value[,] gamefieldArray;  // этот массив будет являтся предтсавлением игрового поля

        public bool isFree(Point position) //проверка ячейки на пустоту(Value.none)
       {
        
        if (gamefieldArray[position.x, position.y] == Value.none)
            return true;
            else return false;
        }

        public void set(Value value, Point position) //установка нового значения на заданную позицию
        {
        gamefieldArray[position.x, position.y] = value;
        }

        public Value[,] gamefield(Value[,] gamefield) //вернуть текущее состояние игрового поля
        {
        for(int i=0; i<3; i++)
            for(int j=0;j<3;j++)
            {
                gamefield[i, j] = gamefieldArray[i, j];
            }
            return gamefield;
        }
    }


