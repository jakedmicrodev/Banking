using Business.DataContexts;
using Business.Entities;
using System.Collections.Generic;

namespace Business.Services
{
    public class BankingService : IBankingService
    {
        public List<Account> GetAccounts()
        {
            return new BankingDataContext().GetAccounts();
        }

        public List<AnnualSpending> GetAnnualIncomeChecking2(int year)
        {
            return new BankingDataContext().GetAnnualIncomeChecking2(year);
        }

        public List<AnnualSpending> GetAnnualIncomeChecking3(int year)
        {
            return new BankingDataContext().GetAnnualIncomeChecking3(year);
        }

        public List<AnnualSpending> GetAnnualIncomeChecking4(int year)
        {
            return new BankingDataContext().GetAnnualIncomeChecking4(year);
        }

        public List<AnnualSpending> GetAnnualSpendingCategory(int year)
        {
            return new BankingDataContext().GetAnnualSpendingCategory(year);
        }

        public List<AnnualSpending> GetAnnualSpendingSubCategory(int year)
        {
            return new BankingDataContext().GetAnnualSpendingSubCategory(year);
        }

        public List<AnnualSpending> GetAnnualSpendingPayee(int year, int category, int subcategory)
        {
            return new BankingDataContext().GetAnnualSpendingPayee(year, category, subcategory);
        }

        public List<IdName> GetCategories()
        {
            return new BankingDataContext().GetCategories();
        }

        public IncomeMonth GetIncomeMonthly ()
        {
            return new BankingDataContext().GetIncomeMonthly();
        }

        public IncomeYear GetIncomeYears()
        {
            return new BankingDataContext().GetIncomeYears();
        }

        public List<MonthlySpending> GetMonthlyIncomeChecking2(int month, int year)
        {
            return new BankingDataContext().GetMonthlyIncomeChecking2(month, year);
        }

        public List<MonthlySpending> GetMonthlyIncomeChecking3(int month, int year)
        {
            return new BankingDataContext().GetMonthlyIncomeChecking3(month, year);
        }

        public List<MonthlySpending> GetMonthlyIncomeChecking4(int month, int year)
        {
            return new BankingDataContext().GetMonthlyIncomeChecking4(month, year);
        }

        public List<MonthlySpending> GetMonthlySpendingCategory(int month, int year)
        {
            return new BankingDataContext().GetMonthlySpendingCategory(month, year);
        }

        public List<MonthlySpending> GetMonthlySpendingSubCategory(int month, int year)
        {
            return new BankingDataContext().GetMonthlySpendingSubCategory(month, year);
        }

        public List<MonthlySpending> GetMonthlySpendingPayee(int month, int year, int category, int subcategory)
        {
            return new BankingDataContext().GetMonthlySpendingPayee(month, year, category, subcategory);
        }

        public List<IdName> GetPayees()
        {
            return new BankingDataContext().GetPayees();
        }

        public List<Spending> GetSpending()
        {
            return new BankingDataContext().GetSpending();
        }

        public List<Spending> GetSpending(SpendingSearch s)
        {
            return new BankingDataContext().GetSpending(s);
        }

        public SpendingMonthly GetSpendingMonthly()
        {
            return new BankingDataContext().GetSpendingMonthly();
        }

        public SpendingSearch GetSpendingSearch()
        {
            return new BankingDataContext().GetSpendingSearch();
        }

        public SpendingYear GetSpendingYears()
        {
            return new BankingDataContext().GetSpendingYears();
        }

        public List<IdName> GetSubCategories()
        {
            return new BankingDataContext().GetSubCategories();
        }

        public List<IdName> GetYears()
        {
            return new BankingDataContext().GetYears();
        }

    }
}
