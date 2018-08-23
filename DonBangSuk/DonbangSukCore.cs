using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonBangSuk
{
    public class DonbangSukCore
    {
        Client client = null;
        RetirementGoal rg = null;
        Income income = null;


    }

    public class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string SpouseName { get; set; }
        public string SpouseOccupation { get; set; }
        public int SpouseAge { get; set; }
        public int NumberOfFamily { get; set; }
        public string Email { get; set; }
    }

    public class FamilyGoal
    {
        public decimal CollegeFund { get; set; }
        public decimal VacationOtherPlans { get; set; }
        public decimal CareerBusinessGoals { get; set; }
        public decimal OtherGoals { get; set; }


    }

    public class RetirementGoal
    {
        public int RetirementAge { get; set; }
        public decimal RetirementSavings { get; set; }
        public decimal Legacy { get; set; }
        public decimal VacationTravel { get; set; }
        public decimal OtherGoals { get; set; }
    }

    public class Income
    {
        public decimal TotalHouseholdIncone { get; set; }
        public decimal TotalNetIncome { get; set; }

    }

    public class Expences
    {
        public decimal MortgageRental { get; set; }
        public decimal CarPayments { get; set; }
        public decimal CreditCardPayment { get; set; }
        public decimal FoodClothingUtilities { get; set; }
        public decimal PersonalExpenses { get; set; }
        public decimal Insurance { get; set; }
        public decimal Life { get; set; }
    }

    public class Asset
    {
        public decimal EstimatedHomeValue { get; set; }
        public decimal MutualFundsStocks { get; set; }
        public decimal CheckingAccounts { get; set; }
        public decimal SavingsAccounts { get; set; }


    }


}
