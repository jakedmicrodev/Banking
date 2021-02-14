using Business.Entities;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class IncomeAndExpensesController : Controller
    {
        // GET: IncomeAndExpenses
        public ActionResult Index()
        {
            return View();
        }

        // GET: IncomeAndExpenses/Details/5
        public ActionResult Details(int id)
        {
            return RedirectToAction("Index");
        }

        // GET: IncomeAndExpenses/Create
        public ActionResult Create()
        {
            return RedirectToAction("Index");
        }

        // POST: IncomeAndExpenses/Create
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

        // GET: IncomeAndExpenses/Edit/5
        public ActionResult Edit(int id)
        {
            return RedirectToAction("Index");
        }

        // POST: IncomeAndExpenses/Edit/5
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

        // GET: IncomeAndExpenses/Delete/5
        public ActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }

        // POST: IncomeAndExpenses/Delete/5
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

        public ActionResult AnnualIncomeAndExpensesPayee()
        {
            //SpendingMonthly s = new BankingService().GetSpendingMonthly();

            //return View(s);
            // TODO: Add delete logic here

            return RedirectToAction("Index");
        }

        public ActionResult MonthlyIncomeAndExpensesPayee()
        {
            SpendingMonthly s = new BankingService().GetSpendingMonthly();

            return View(s);
        }

        [HttpPost]
        public ActionResult MonthlyIncomeAndExpensesPayee(SpendingMonthly s)
        {
            List<MonthlySpending> l = new BankingService().GetMonthlyIncomeAndExpenses(s.MonthId, s.YearId);
            TempData["MonthlyIncomeAndExpenses"] = l;
            TempData["FieldName"] = "Category";
            TempData["Year"] = s.YearId;
            TempData["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(s.MonthId);

            return Redirect("MonthlyIncomeAndExpensesResults");
        }

        public ActionResult MonthlyIncomeAndExpensesResults()
        {
            List<MonthlySpending> v = TempData["MonthlyIncomeAndExpenses"] as List<MonthlySpending>;
            ViewBag.FieldName = TempData["FieldName"];
            ViewBag.Year = TempData["Year"];
            ViewBag.Month = TempData["Month"];

            return View(v);
        }

    }
}
