using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class SpendingController : Controller
    {
        // GET: Spending
        public ActionResult Index()
        {
            return View();
        }

        // GET: Spending/Details/5
        public ActionResult Details(int id)
        {
            return RedirectToAction("Index");
        }

        // GET: Spending/Create
        public ActionResult Create()
        {
            return RedirectToAction("Index");
        }

        // POST: Spending/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Spending/Edit/5
        public ActionResult Edit(int id)
        {
            return RedirectToAction("Index");
        }

        // POST: Spending/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Spending/Delete/5
        public ActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }

        // POST: Spending/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Search()
        {

            SpendingSearch s = new BankingService().GetSpendingSearch();

            return View(s);
        }

        [HttpPost]
        public ActionResult Search(SpendingSearch s)
        {

            List<Spending> l = new BankingService().GetSpending(s);
            TempData["Spending"] = l;

            return Redirect("SearchResults");

        }

        public ActionResult SearchResults()
        {
            List<Spending> v = TempData["Spending"] as List<Spending>;
            return View(v);
        }

        public ActionResult AnnualSpendingCategory()
        {
            SpendingYear s = new BankingService().GetSpendingYears();

            return View(s);
        }

        [HttpPost]
        public ActionResult AnnualSpendingCategory(SpendingYear s)
        {
            List<AnnualSpending> l = new BankingService().GetAnnualSpendingCategory(s.Id);
            TempData["AnnualSpending"] = l;
            TempData["FieldName"] = "Category";
            TempData["Year"] = s.Id;
            TempData["Month"] = "";

            return Redirect("AnnualSpendingResults");
        }

        public ActionResult AnnualSpendingSubCategory()
        {
            SpendingYear s = new BankingService().GetSpendingYears();

            return View(s);
        }

        [HttpPost]
        public ActionResult AnnualSpendingSubCategory(SpendingYear s)
        {
            List<AnnualSpending> l = new BankingService().GetAnnualSpendingSubCategory(s.Id);
            TempData["AnnualSpending"] = l;
            TempData["FieldName"] = "Sub Category";
            TempData["Year"] = s.Id;
            TempData["Month"] = "";

            return Redirect("AnnualSpendingResults");
        }

        public ActionResult AnnualSpendingPayee()
        {
            SpendingYear s = new BankingService().GetSpendingYears();

            return View(s);
        }

        [HttpPost]
        public ActionResult AnnualSpendingPayee(SpendingYear s)
        {
            List<AnnualSpending> l = new BankingService().GetAnnualSpendingPayee(s.Id, s.CategoryId, s.SubCategoryId);
            TempData["AnnualSpending"] = l;
            TempData["FieldName"] = "Payee";
            TempData["Year"] = s.Id;
            TempData["Month"] = "";

            return Redirect("AnnualSpendingResults");
        }

        public ActionResult AnnualSpendingResults()
        {
            List<AnnualSpending> v = TempData["AnnualSpending"] as List<AnnualSpending>;
            ViewBag.FieldName = TempData["FieldName"];
            ViewBag.Year = TempData["Year"];
            ViewBag.Month = TempData["Month"];

            return View(v);
        }

        public ActionResult MonthlySpendingBetweenPaydays()
        {
            SpendingMonthly s = new BankingService().GetSpendingMonthly();

            return View(s);
        }

        [HttpPost]
        public ActionResult MonthlySpendingBetweenPaydays(SpendingMonthly s)
        {
            List<MonthlySpending> l = new BankingService().GetMonthlySpendingBetweenPaydays(s.MonthId, s.YearId);
            TempData["MonthlySpending"] = l;
            TempData["FieldName"] = "Category";
            TempData["Year"] = s.YearId;
            TempData["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(s.MonthId); 

            return Redirect("MonthlySpendingBetweenPaydaysResults");
        }

        public ActionResult MonthlySpendingCategory()
        {
            SpendingMonthly s = new BankingService().GetSpendingMonthly();

            return View(s);
        }

        [HttpPost]
        public ActionResult MonthlySpendingCategory(SpendingMonthly s)
        {
            List<MonthlySpending> l = new BankingService().GetMonthlySpendingCategory(s.MonthId, s.YearId);
            TempData["MonthlySpending"] = l;
            TempData["FieldName"] = "Category";
            TempData["Year"] = s.YearId;
            TempData["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(s.MonthId);

            return Redirect("MonthlySpendingResults");
        }

        public ActionResult MonthlySpendingSubCategory()
        {
            SpendingMonthly s = new BankingService().GetSpendingMonthly();

            return View(s);
        }

        [HttpPost]
        public ActionResult MonthlySpendingSubCategory(SpendingMonthly s)
        {
            List<MonthlySpending> l = new BankingService().GetMonthlySpendingSubCategory(s.MonthId, s.YearId);
            TempData["MonthlySpending"] = l;
            TempData["FieldName"] = "Sub Category";
            TempData["Year"] = s.YearId;
            TempData["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(s.MonthId);

            return Redirect("MonthlySpendingResults");
        }

        public ActionResult MonthlySpendingPayee()
        {
            SpendingMonthly s = new BankingService().GetSpendingMonthly();
            
            return View(s);
        }

        [HttpPost]
        public ActionResult MonthlySpendingPayee(SpendingMonthly s)
        {
            List<MonthlySpending> l = new BankingService().GetMonthlySpendingPayee(s.MonthId, s.YearId, s.CategoryId, s.SubCategoryId);
            TempData["MonthlySpending"] = l;
            TempData["FieldName"] = "Payee";
            TempData["Year"] = s.YearId;
            TempData["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(s.MonthId);

            return Redirect("MonthlySpendingResults");
        }


        public ActionResult MonthlySpendingResults()
        {
            List<MonthlySpending> v = TempData["MonthlySpending"] as List<MonthlySpending>;
            ViewBag.FieldName = TempData["FieldName"];
            ViewBag.Year = TempData["Year"];
            ViewBag.Month = TempData["Month"];
            return View(v);
        }

        public ActionResult MonthlySpendingBetweenPaydaysResults()
        {
            List<MonthlySpending> v = TempData["MonthlySpending"] as List<MonthlySpending>;
            ViewBag.FieldName = TempData["FieldName"];
            ViewBag.Year = TempData["Year"];
            ViewBag.Month = TempData["Month"];
            return View(v);
        }
    }
}
