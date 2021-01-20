﻿using Business.Entities;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class PayeeController : Controller
    {
        // GET: Payee
        public ActionResult Index()
        {
            List<IdName> v = new BankingService().GetPayees();
            return View(v);
        }

        // GET: Payee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Payee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Payee/Create
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

        // GET: Payee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Payee/Edit/5
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

        // GET: Payee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Payee/Delete/5
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
    }
}
