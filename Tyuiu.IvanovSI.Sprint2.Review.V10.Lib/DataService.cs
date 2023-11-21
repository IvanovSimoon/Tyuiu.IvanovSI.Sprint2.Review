﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovSI.Sprint2.Review.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x*x-2<=y)&&((-x <= y) || (x >= y)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}