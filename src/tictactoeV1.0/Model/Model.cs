using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Model
    {
        // этот массив будет являтся предтсавлением игрового поля
        private Value[,] gamefieldArray;

        public bool isFree(Point position)
        {
            //проверка ячейки на пустоту(Value.none)
            return false;
        }

        public void set(Value value, Point position)
        {
            //установка нового значения на заданную позицию
        }

        public Value[,] gamefield()
        {
            //вернуть текущее состояние игрового поля
            return new Value[,]{};
        }
    }


