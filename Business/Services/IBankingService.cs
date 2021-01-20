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

        List<AnnualSpending> GetAnnualSpendingPayee(int year);

        List<IdName> GetCategories();

        List<IdName> GetPayees();

        List<MonthlySpending> GetMonthlySpendingCategory(int month, int year);
        
        List<MonthlySpending> GetMonthlySpendingSubCategory(int month, int year);

        List<Spending> GetSpending();

        List<Spending> GetSpending(SpendingSearch s);

        SpendingMonthly GetSpendingMonthly();

        SpendingYear GetSpendingYears();

        List<IdName> GetSubCategories();

        List<IdName> GetYears();

        #endregion
    }
}
