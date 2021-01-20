using Business.Entities;
using System.Collections.Generic;

namespace Business.DataContexts
{
    public interface IBankingDataContext
    {

        #region Create


        #endregion

        #region Get

        List<Account> GetAccounts();

        List<AnnualSpending> GetAnnualSpendingCategory(int year);

        List<AnnualSpending> GetAnnualSpendingSubCategory(int year);

        List<AnnualSpending> GetAnnualSpendingPayee(int year);

        List<IdName> GetCategories();

        List<MonthlySpending> GetMonthlySpendingCategory(int month, int year);

        List<MonthlySpending> GetMonthlySpendingSubCategory(int month, int year);

        List<MonthlySpending> GetMonthlySpendingPayee(int month, int year);

        List<IdName> GetPayees();

        List<Spending> GetSpending();

        List<IdName> GetSubCategories();

        #endregion

        #region Get

        SpendingMonthly GetSpendingMonthly();

        SpendingSearch GetSpendingSearch();

        SpendingYear GetSpendingYears();

        List<Spending> GetSpending(SpendingSearch s);

        List<IdName> GetYears();

        #endregion
    }
}
