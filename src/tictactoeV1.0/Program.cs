using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
  
    class Program
    {
       
        static void Main(string[] args)
        {
            View view = new View();
            Model model = new Model();
            Analyser analyser = new Analyser();
            Presenter presenter = new Presenter();
            presenter.view = view;
            presenter.model = model;
            presenter.analyser = analyser;
            view.viewDelegate = presenter;
            presenter.gameTurn(Value.x);
        }
    }
}
