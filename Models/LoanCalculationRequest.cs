using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanCalculator3._0.Models
{
    public class LoanCalculationRequest
    {
        public decimal Principle { get; set; }
        public double AnnualInterestRate { get; set; }
        public int LoanTenureMonths { get; set; }
    }
}