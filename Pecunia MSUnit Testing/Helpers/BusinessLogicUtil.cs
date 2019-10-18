﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini.Pecunia.Helpers
{
    public static class BusinessLogicUtil
    {
        public static double ComputeEMI(double Amount, int RepaymentPeriod, double InterestRate)
        {
            // implements simple interset 
            double TotalAmountToBePaid = Amount * (1 + (InterestRate / 100));
            int TotalMonths = RepaymentPeriod;
            double EMI = TotalAmountToBePaid / (double)TotalMonths;

            //Console.WriteLine($"total mounts to be paid {TotalAmountToBePaid}");
            return EMI;
        }

        public static DateTime validateDate(string v, string inputDateStr)
        {
            throw new NotImplementedException();
        }
    }
}
