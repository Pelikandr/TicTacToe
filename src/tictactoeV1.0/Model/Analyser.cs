using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Analyser
    {
        public Value winner(Value[,] gameField)
        {
            //проверка игрового поля (массива) на наличие победителя
            //метод должен вернуть победивший знак или Value.none
            return Value.none;
        }
        
        public bool isGamefieldFull(Value[,] gameField)
        {
            //проверка массива на заполненность Х\О знаками 
            return false;
        }
    }

