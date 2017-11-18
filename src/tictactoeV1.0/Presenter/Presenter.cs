using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Presenter : ViewDelegate
    {
        public View view { get; set; }
        public Model model { get; set; }
        public Analyser analyser { get; set; }

        void ViewDelegate.set(Value value, Point point)
        {

        }

        public void startGame()
        {

        }
    }
