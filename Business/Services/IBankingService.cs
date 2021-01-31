using Business.Entities;
using System.Collections.Generic;

namespace Business.Services
{
    public interface IBankingService
    {
        #region Get

        List<Account> GetAccounts();

        List<AnnualSpending> GetAnnualSpendingCategory(int year);

        List<AnnualSpending> GetAnnualSpendingSubCategory(int year);

        List<AnnualSpending> GetAnnualSpendingPayee(int year, int category);

        List<IdName> GetCategories();

        List<MonthlySpending> GetMonthlySpendingCategory(int month, int year);

        List<MonthlySpending> GetMonthlySpendingPayee(int month, int year, int category);

        List<MonthlySpending> GetMonthlySpendingSubCategory(int month, int year);

        List<IdName> GetPayees();

        List<Spending> GetSpending();

        List<Spending> GetSpending(SpendingSearch s);

        SpendingMonthly GetSpendingMonthly();

        SpendingSearch GetSpendingSearch();

        SpendingYear GetSpendingYears();

        List<IdName> GetSubCategories();

        List<IdName> GetYears();

        #endregion
    }
}
