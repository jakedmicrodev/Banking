using Business.Core;
using Business.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace Business.DataContexts
{
    public class BankingDataContext : IBankingDataContext
    {

        #region Private

        private List<SelectListItem> FillAccount(List<Account> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Account c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;

        }


        private List<SelectListItem> FillList(List<IdName> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (IdName c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;

        }

        #endregion

        public List<Account> GetAccounts()
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                return conn.Query<Account>(StoredProcedures.GETACCOUNTS).ToList<Account>();
            }
        }

        public List<AnnualSpending> GetAnnualIncomeChecking2(int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETANNUALINCOMECHECKING2, "@Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<AnnualSpending>(sql, parameters).ToList<AnnualSpending>().ToList();
            }
        }

        public List<AnnualSpending> GetAnnualIncomeChecking3(int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETANNUALINCOMECHECKING3, "@Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<AnnualSpending>(sql, parameters).ToList<AnnualSpending>().ToList();
            }
        }

        public List<AnnualSpending> GetAnnualIncomeChecking4(int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETANNUALINCOMECHECKING4, "@Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<AnnualSpending>(sql, parameters).ToList<AnnualSpending>().ToList();
            }
        }

        public List<AnnualSpending> GetAnnualSpendingCategory(int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETANNUALSPENDINGCATEGORY, "@Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<AnnualSpending>(sql, parameters).ToList<AnnualSpending>().ToList();
            }
        }

        public List<AnnualSpending> GetAnnualSpendingSubCategory(int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETANNUALSPENDINGSUBCATEGORY, "@Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<AnnualSpending>(sql, parameters).ToList<AnnualSpending>().ToList();
            }
        }

        public List<AnnualSpending> GetAnnualSpendingPayee(int year, int category, int subcategory)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETANNUALSPENDINGPAYEE, "@Year, @CategoryId, @SubCategoryId");
                var parameters = new DynamicParameters();
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);
                if (category > 0)
                {
                    parameters.Add("@CategoryId", category, DbType.Int32, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@CategoryId", null, DbType.Int32, ParameterDirection.Input);
                }

                if (subcategory > 0)
                {
                    parameters.Add("@SubCategoryId", subcategory, DbType.Int32, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@SubCategoryId", null, DbType.Int32, ParameterDirection.Input);
                }

                return conn.Query<AnnualSpending>(sql, parameters).ToList<AnnualSpending>().ToList();
            }
        }

        public List<IdName> GetCategories()
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETCATEGORIES).ToList<IdName>();
            }
        }

        public IncomeMonth GetIncomeMonthly()
        {
            IncomeMonth i = new IncomeMonth();

            i.Months = FillList(GetMonths());
            i.Years = FillList(GetYears());

            return i;
        }

        public IncomeYear GetIncomeYears()
        {
            IncomeYear i = new IncomeYear();

            i.Years = FillList(GetYears());

            return i;
        }

        public List<MonthlySpending> GetMonthlyIncomeAndExpenses(int month, int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETMONTHLYINCOMEANDEXPENSES, "@Month, @Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Month", month, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<MonthlySpending>(sql, parameters).ToList<MonthlySpending>().ToList();
            }
        }

        public List<MonthlySpending> GetMonthlyIncomeChecking2(int month, int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETMONTHLYINCOMECHECKING2, "@Month, @Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Month", month, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<MonthlySpending>(sql, parameters).ToList<MonthlySpending>().ToList();
            }
        }

        public List<MonthlySpending> GetMonthlyIncomeChecking3(int month, int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETMONTHLYINCOMECHECKING3, "@Month, @Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Month", month, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<MonthlySpending>(sql, parameters).ToList<MonthlySpending>().ToList();
            }
        }

        public List<MonthlySpending> GetMonthlyIncomeChecking4(int month, int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETMONTHLYINCOMECHECKING4, "@Month, @Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Month", month, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<MonthlySpending>(sql, parameters).ToList<MonthlySpending>().ToList();
            }
        }

        public List<MonthlySpending> GetMonthlySpendingBetweenPaydays(int month, int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETMONTHLYSPENDINGBETWEENPAYDAYS, "@Month, @Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Month", month, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<MonthlySpending>(sql, parameters).ToList<MonthlySpending>().ToList();
            }
        }

        public List<MonthlySpending> GetMonthlySpendingCategory(int month, int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETMONTHLYSPENDINGCATEGORY, "@Month, @Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Month", month, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<MonthlySpending>(sql, parameters).ToList<MonthlySpending>().ToList();
            }
        }

        public List<MonthlySpending> GetMonthlySpendingSubCategory(int month, int year)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETMONTHLYSPENDINGSUBCATEGORY, "@Month, @Year");
                var parameters = new DynamicParameters();
                parameters.Add("@Month", month, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);

                return conn.Query<MonthlySpending>(sql, parameters).ToList<MonthlySpending>().ToList();
            }
        }

        public List<MonthlySpending> GetMonthlySpendingPayee(int month, int year, int category, int subcategory)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                string sql = string.Format("{0} {1}", StoredProcedures.GETMONTHLYSPENDINGPAYEE, "@Month, @Year, @CategoryId, @SubCategoryId");
                var parameters = new DynamicParameters();
                parameters.Add("@Month", month, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Year", year, DbType.Int32, ParameterDirection.Input);
                if (category > 0)
                {
                    parameters.Add("@CategoryId", category, DbType.Int32, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@CategoryId", null, DbType.Int32, ParameterDirection.Input);
                }

                if (subcategory > 0)
                {
                    parameters.Add("@SubCategoryId", subcategory, DbType.Int32, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@SubCategoryId", null, DbType.Int32, ParameterDirection.Input);
                }

                return conn.Query<MonthlySpending>(sql, parameters).ToList<MonthlySpending>().ToList();
            }
        }

        public List<IdName> GetPayees()
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETPAYEES).ToList<IdName>();
            }
        }

        public List<Spending> GetSpending()
        {
            throw new NotImplementedException();
        }

        public List<Spending> GetSpending(SpendingSearch s)
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                var parameters = new DynamicParameters();
                string sql = string.Format("{0} {1}", StoredProcedures.GETSPENDING, "@Id, @CategoryId, @SubcategoryId, @StartDate, @EndDate, @Description, @Payee, @AccountId, @StartAmount, @EndAmount");
                var isValid = false;

                parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);

                if (s.CategoryId > 0)
                {
                    parameters.Add("@CategoryId", s.CategoryId, DbType.Int32, ParameterDirection.Input);
                    isValid = true;
                }
                else
                {
                    parameters.Add("@CategoryId", null, DbType.Int32, ParameterDirection.Input);
                }

                if (s.SubCategoryId > 0)
                {
                    parameters.Add("@SubcategoryId", s.SubCategoryId, DbType.Int32, ParameterDirection.Input);
                    isValid = true;
                }
                else
                {
                    parameters.Add("@SubcategoryId", null, DbType.Int32, ParameterDirection.Input);
                }

                if (s.StartDate.ToShortDateString() != "1/1/0001" && s.EndDate.ToShortDateString() != "1/1/0001")
                {
                    parameters.Add("@StartDate", s.StartDate, DbType.DateTime, ParameterDirection.Input);
                    parameters.Add("@EndDate", s.EndDate, DbType.DateTime, ParameterDirection.Input);
                    isValid = true;
                }
                else
                {
                    parameters.Add("@StartDate", null, DbType.DateTime, ParameterDirection.Input);
                    parameters.Add("@EndDate", null, DbType.DateTime, ParameterDirection.Input);
                }

                if (!string.IsNullOrEmpty(s.Description))
                {
                    parameters.Add("@Description", s.Description, DbType.String, ParameterDirection.Input, s.Description.Length);
                    isValid = true;
                }
                else
                {
                    parameters.Add("@Description", null, DbType.Int32, ParameterDirection.Input);
                }

                if (!string.IsNullOrEmpty(s.Payee))
                {
                    parameters.Add("@Payee", s.Payee, DbType.String, ParameterDirection.Input, s.Payee.Length);
                    isValid = true;
                }
                else
                {
                    parameters.Add("@Payee", null, DbType.Int32, ParameterDirection.Input);
                }

                if (s.AccountId > 0)
                {
                    parameters.Add("@AccountId", s.AccountId, DbType.Int32, ParameterDirection.Input);
                    isValid = true;
                }
                else
                {
                    parameters.Add("@AccountId", null, DbType.Int32, ParameterDirection.Input);
                }

                if (s.StartAmount > 0 && s.EndAmount > 0)
                {
                    parameters.Add("@StartAmount", s.StartAmount, DbType.Currency, ParameterDirection.Input);
                    parameters.Add("@EndAmount", s.EndAmount, DbType.Currency, ParameterDirection.Input);
                    isValid = true;
                }
                else
                {
                    parameters.Add("@StartAmount", null, DbType.Currency, ParameterDirection.Input);
                    parameters.Add("@EndAmount", null, DbType.Currency, ParameterDirection.Input);
                }

                if (!isValid)
                {                    
                    return new List<Spending>();
                }
                else
                {
                    return conn.Query<Spending>(sql, parameters).ToList<Spending>().ToList();
                }
            }
        }

        public List<IdName> GetSubCategories()
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETSUBCATEGORIES).ToList<IdName>();
            }
        }

        public SpendingMonthly GetSpendingMonthly()
        {
            SpendingMonthly s = new SpendingMonthly();

            s.Months = FillList(GetMonths());
            s.Years = FillList(GetYears());
            s.Categories = FillList(GetCategories());
            s.SubCategories = FillList(GetSubCategories());

            return s;
        }

        public SpendingYear GetSpendingYears()
        {
            SpendingYear s = new SpendingYear();

            s.Years = FillList(GetYears());
            s.Categories = FillList(GetCategories());
            s.SubCategories = FillList(GetSubCategories());

            return s;
        }

        public SpendingSearch GetSpendingSearch()
        {
            SpendingSearch s = new SpendingSearch();

            s.Accounts = FillAccount(GetAccounts());
            s.Categories = FillList(GetCategories());
            s.SubCategories = FillList(GetSubCategories());

            return s;
        }

        public List<IdName> GetYears()
        {
            using (IDbConnection conn = new SqlConnection(Settings.BankingConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETSPENDINGYEARS).ToList<IdName>();
            }
        }

        public List<IdName> GetMonths()
        {
            List<IdName> l = new List<IdName>();

            for(var i = 1; i <= 12; i++)
            {
                l.Add(new IdName
                {
                    Id = i,
                    Name = new DateTimeFormatInfo().GetMonthName(i).ToString()
                });
            }

            return l;
        }

    }
}
