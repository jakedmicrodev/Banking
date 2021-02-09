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

        List<AnnualSpending> GetAnnualIncomeChecking2(int year);

        List<AnnualSpending> GetAnnualIncomeChecking3(int year);

        List<AnnualSpending> GetAnnualIncomeChecking4(int year);

        List<AnnualSpending> GetAnnualSpendingCategory(int year);

        List<AnnualSpending> GetAnnualSpendingSubCategory(int year);

        List<AnnualSpending> GetAnnualSpendingPayee(int year, int category, int subcategory);

        List<IdName> GetCategories();

        IncomeMonth GetIncomeMonthly();

        IncomeYear GetIncomeYears();

        List<MonthlySpending> GetMonthlyIncomeChecking2(int month, int year);

        List<MonthlySpending> GetMonthlyIncomeChecking3(int month, int year);

        List<MonthlySpending> GetMonthlyIncomeChecking4(int month, int year);

        List<MonthlySpending> GetMonthlySpendingBetweenPaydays(int month, int year);

        List<MonthlySpending> GetMonthlySpendingCategory(int month, int year);

        List<MonthlySpending> GetMonthlySpendingPayee(int month, int year, int category, int subcategory);

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
