using CalculatorApp.Models;
using System;
using System.Web.Mvc;

namespace CalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel model, string Operator, string Clear)
        {
            if (!string.IsNullOrEmpty(Clear))
            {
                // Reset fields if the Clear button is clicked
                ModelState.Clear();
                ViewBag.Result = null;
                ViewBag.Error = null;
                return View(new CalculatorModel());
            }

            try
            {
                model.Operator = Operator;
                model.Calculate();
                ViewBag.Result = model.Result;
            }
            catch (DivideByZeroException ex)
            {
                ViewBag.Error = ex.Message;
            }
            catch (InvalidOperationException ex)
            {
                ViewBag.Error = ex.Message;
            }

            return View(model);
        }
    }
}
