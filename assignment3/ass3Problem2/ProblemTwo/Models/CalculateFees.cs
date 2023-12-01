using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo.Models
{
    public class CalculateFees
    {
        public double getCalculateFees(double weights,int mile)
        {
            double fees = 0;
            if (mile % 500 == 0)
            {
                mile = mile / 500;
            }
            else
            {
                mile = mile / 500 + 1;
            }

            if (weights > 0 && weights <= 2)
            {
                fees = 1.10 * mile;

            }
            else if (weights <= 6)
            {
                fees = 2.2 * mile;
            }
            else if (weights <= 10)
            {
                fees = 3.7 * mile;
            }
            else { fees = 4.8 * mile; }
            return fees;
        }
    }
}
