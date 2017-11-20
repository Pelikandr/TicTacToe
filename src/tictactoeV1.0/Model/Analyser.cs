using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Analyser
    {
        public Value winner(Value[,] gameField)
        {
            if ((gameField[0,0] == Value.x && gameField[0,1] == Value.x && gameField[0,2] == Value.x) ||
                (gameField[1,0] == Value.x && gameField[1,1] == Value.x && gameField[1,2] == Value.x) ||
                (gameField[2,0] == Value.x && gameField[2,1] == Value.x && gameField[2,2] == Value.x) ||
                (gameField[0,0] == Value.x && gameField[1,0] == Value.x && gameField[2,0] == Value.x) ||
                (gameField[0,1] == Value.x && gameField[1,1] == Value.x && gameField[2,1] == Value.x) ||
                (gameField[0,2] == Value.x && gameField[1,2] == Value.x && gameField[2,2] == Value.x) ||
                (gameField[0,0] == Value.x && gameField[1,1] == Value.x && gameField[2,2] == Value.x) ||
                (gameField[2,0] == Value.x && gameField[1,1] == Value.x && gameField[0,2] == Value.x))
            {
                return Value.x;
            }

            if ((gameField[0,0] == Value.o && gameField[0,1] == Value.o && gameField[0,2] == Value.o) ||
                (gameField[1,0] == Value.o && gameField[1,1] == Value.o && gameField[1,2] == Value.o) ||
                (gameField[2,0] == Value.o && gameField[2,1] == Value.o && gameField[2,2] == Value.o) ||
                (gameField[0,0] == Value.o && gameField[1,0] == Value.o && gameField[2,0] == Value.o) ||
                (gameField[0,1] == Value.o && gameField[1,1] == Value.o && gameField[2,1] == Value.o) ||
                (gameField[0,2] == Value.o && gameField[1,2] == Value.o && gameField[2,2] == Value.o) ||
                (gameField[0,0] == Value.o && gameField[1,1] == Value.o && gameField[2,2] == Value.o) ||
                (gameField[2,0] == Value.o && gameField[1,1] == Value.o && gameField[0,2] == Value.o))
            {
                return Value.o;
            }
            //проверка игрового поля (массива) на наличие победителя
            //метод должен вернуть победивший знак или Value.none
            return Value.none;
        }
        
        public bool isGamefieldFull(Value[,] gameField)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameField[i,j] == Value.none)
                    {
                        return false;
                    }
                    else {
                        continue;
                    }
                }
            }
                //проверка массива на заполненность Х\О знаками 
            return true;
        }
    }

