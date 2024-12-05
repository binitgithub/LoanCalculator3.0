using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanCalculator3._0.Models;

namespace LoanCalculator3._0.Services
{
    public class LoanCalculatorServices
    {
        public LoanCalculationResponse LoanCalculate(LoanCalculationRequest request)
        {
            //Convert Annual Interest to decimal form
            double monthlyInterestRate = request.AnnualInterestRate/100/12;
            
            //Monthly Payment
            decimal monthlyPayment = request.Principle * (decimal)(monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, request.LoanTenureMonths)/
            (Math.Pow(1 + monthlyInterestRate, request.LoanTenureMonths)-1));

            //Total Payment
            decimal totalPayment = monthlyPayment * request.LoanTenureMonths;

            //Total Interest
            decimal totalInterest = totalPayment - request.Principle;

            return new LoanCalculationResponse
            {
                MonthlyPayment = monthlyPayment,
                TotalPayment = totalPayment,
                TotalInterest = totalInterest

            };
        }
    }
}