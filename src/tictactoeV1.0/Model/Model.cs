using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface Model
    {
        bool isFree(Point position);
        void set(Value value, Point position);
        int[,] gamefield();
    }


