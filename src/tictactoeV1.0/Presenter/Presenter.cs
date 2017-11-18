using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    interface Presenter : ViewDelegate
    {
        View view { get; set; }
        Model model { get; set; }
        Analyzer analyser { get; set; }
    }