using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanCalculator3._0.Models;
using LoanCalculator3._0.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoanCalculator3._0.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanCalculatorController : ControllerBase
    {
        private readonly LoanCalculatorServices _loanCalculatorServices;
        public LoanCalculatorController()
        {
            _loanCalculatorServices = new LoanCalculatorServices();
        }

    //Calculate Loan
    [HttpPost ("calculate")]
    public IActionResult CalculateLoan([FromBody] LoanCalculationRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("invalid Input");
        }

        var response = _loanCalculatorServices.LoanCalculate(request);
        return Ok(response);
    }
    }
}