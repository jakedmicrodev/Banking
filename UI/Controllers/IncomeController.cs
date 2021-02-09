using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class IncomeController : Controller
    {
        // GET: Income
        public ActionResult Index()
        {
            return View();
        }

        // GET: Income/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Income/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Income/Create
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

        // GET: Income/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Income/Edit/5
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

        // GET: Income/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Income/Delete/5
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

        public ActionResult AnnualIncomeChecking2()
        {
            IncomeYear s = new BankingService().GetIncomeYears();

            return View(s);
        }

        [HttpPost]
        public ActionResult AnnualIncomeChecking2(IncomeYear s)
        {
            List<AnnualSpending> l = new BankingService().GetAnnualIncomeChecking2(s.Id);
            TempData["AnnualIncome"] = l;
            TempData["FieldName"] = "Account";
            TempData["Year"] = s.Id;
            TempData["Month"] = "";

            return Redirect("AnnualIncomeResults");
        }

        public ActionResult AnnualIncomeChecking3()
        {
            IncomeYear s = new BankingService().GetIncomeYears();

            return View(s);
        }

        [HttpPost]
        public ActionResult AnnualIncomeChecking3(IncomeYear s)
        {
            List<AnnualSpending> l = new BankingService().GetAnnualIncomeChecking3(s.Id);
            TempData["AnnualIncome"] = l;
            TempData["FieldName"] = "Account";
            TempData["Year"] = s.Id;
            TempData["Month"] = "";

            return Redirect("AnnualIncomeResults");
        }

        public ActionResult AnnualIncomeChecking4()
        {
            IncomeYear s = new BankingService().GetIncomeYears();

            return View(s);
        }

        [HttpPost]
        public ActionResult AnnualIncomeChecking4(IncomeYear s)
        {
            List<AnnualSpending> l = new BankingService().GetAnnualIncomeChecking4(s.Id);
            TempData["AnnualIncome"] = l;
            TempData["FieldName"] = "Account";
            TempData["Year"] = s.Id;
            TempData["Month"] = "";

            return Redirect("AnnualIncomeResults");
        }

        public ActionResult AnnualIncomeResults()
        {
            List<AnnualSpending> v = TempData["AnnualIncome"] as List<AnnualSpending>;
            ViewBag.FieldName = TempData["FieldName"];
            ViewBag.Year = TempData["Year"];
            ViewBag.Month = TempData["Month"];

            return View(v);
        }

        public ActionResult MonthlyIncomeChecking2()
        {
                IncomeMonth s = new BankingService().GetIncomeMonthly();

                return View(s);
        }

        [HttpPost]
        public ActionResult MonthlyIncomeChecking2(IncomeMonth s)
        {
            List<MonthlySpending> l = new BankingService().GetMonthlyIncomeChecking2(s.MonthId, s.YearId);
            TempData["MonthlylIncome"] = l;
            TempData["FieldName"] = "Account";
            TempData["Year"] = s.YearId;
            TempData["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(s.MonthId);


            return Redirect("MonthlyIncomeResults");
        }

        public ActionResult MonthlyIncomeChecking3()
        {
            IncomeMonth s = new BankingService().GetIncomeMonthly();

            return View(s);
        }

        [HttpPost]
        public ActionResult MonthlyIncomeChecking3(IncomeMonth s)
        {
            List<MonthlySpending> l = new BankingService().GetMonthlyIncomeChecking3(s.MonthId, s.YearId);
            TempData["MonthlylIncome"] = l;
            TempData["FieldName"] = "Account";
            TempData["Year"] = s.YearId;
            TempData["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(s.MonthId);


            return Redirect("MonthlyIncomeResults");
        }

        public ActionResult MonthlyIncomeChecking4()
        {
            IncomeMonth s = new BankingService().GetIncomeMonthly();

            return View(s);
        }

        [HttpPost]
        public ActionResult MonthlyIncomeChecking4(IncomeMonth s)
        {
            List<MonthlySpending> l = new BankingService().GetMonthlyIncomeChecking4(s.MonthId, s.YearId);
            TempData["MonthlylIncome"] = l;
            TempData["FieldName"] = "Account";
            TempData["Year"] = s.YearId;
            TempData["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(s.MonthId);


            return Redirect("MonthlyIncomeResults");
        }

        public ActionResult MonthlyIncomeResults()
        {
            List<MonthlySpending> v = TempData["MonthlylIncome"] as List<MonthlySpending>;
            ViewBag.FieldName = TempData["FieldName"];
            ViewBag.Year = TempData["Year"];
            ViewBag.Month = TempData["Month"];

            return View(v);
        }

    }
}
