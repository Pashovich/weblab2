using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using weblab2.Models;

namespace weblab2.Controllers
{
    public class FormController : Controller
    {
        private int calculate(int first, int second , string operation)
        {
            switch (operation)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;

                case "/":
                    if (second == 0)
                    {
                        return 0;
                    }
                    return first / second;
                default:
                    return 0;
            }
        }
        public ViewResult ModelBindPar()
        {
            FormModel model = new FormModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult ModelBindPar(int first, string operation, int second)
        {
            FormModel model = new FormModel(first, second,operation);
            if (!TryValidateModel(model, nameof(model)))
            {
                return View(model);
            }
            model.calculationResult = this.calculate(model.first, model.second, model.operation);
            return View("ResultFormModel", model);
        }
        public ViewResult ModelBindSep()
        {
            FormModel model = new FormModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult ModelBindSep(FormModel model)
        {
            if (!TryValidateModel(model, nameof(model))){
                return View(model);
            }
            model.calculationResult = this.calculate(model.first, model.second, model.operation);
            return View("ResultFormModel", model);
        }

        [HttpGet]
        public IActionResult ManualSep()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ManualSep(int first, string operation, int second)
        {
            int result = this.calculate(first, second, operation);
            ViewBag.expression = $"{first} {operation} {second} = {result}";
            return View("ResultForm");
        }
        public IActionResult ManualSingle (int first, string operation, int second)
        {
            if(Request.Method == "GET")
            {
                return View();
            }
            if (Request.Method == "POST")
            {
                int result = this.calculate(first, second, operation);
                ViewBag.expression = $"{first} {operation} {second} = {result}";
                return View("ResultForm");
            }
            return View();
        }
    }
}