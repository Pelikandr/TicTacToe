using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Presenter : ViewDelegate
    {
        public View view;
        public Model model;
        public Analyser analyser;

        void ViewDelegate.set(Value value, Point point)
        {
            if (model.isFree(point))
            {
                model.set(value, point);
                Value winner = analyser.winner(model.gamefield());
                if (winner != Value.none)
                    view.gameOver(winner);
                else if (analyser.isGamefieldFull(model.gamefield()))
                    view.gameOver(Value.none);
                else
                    gameTurn(value == Value.x ? Value.o : Value.x);
            }
            else
            {
                view.showError("Error! This field is occupied!");
                gameTurn(value);
            }
        }

        public void gameTurn(Value value) 
        {
            view.print(model.gamefield(), value);
        }
    }
