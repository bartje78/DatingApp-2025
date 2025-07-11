using System;

namespace API.Entities;

public class LoanModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required decimal Principal { get; set; } //original loan amount
    public required decimal Outstanding { get; set; } // current outstanding balance
    public required decimal InterestRate { get; set; } //annual interest rate in percentage
    public required string LoanType { get; set; } // annuity, bullet, interest only
    public required string LoanCollateral { get; set; } // e.g. 1st mortgage, 2nd mortgage, unsecured 
    public required string CollateralType { get; set; } // e.g. residential property, commercial real estate, industrial real estate 
    public required DateTime StartDate { get; set; } // date when the loan started
    public required int Tenor { get; set; } // in months
    public required string Currency { get; set; } // e.g. EUR, USD
    public required string LoanStatus { get; set; } // e.g. active, closed, defaulted

}