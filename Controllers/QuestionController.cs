using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quiz.Models;

namespace quiz.controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.CurrentQuestion=0;

            return View(QuestionRepository.Questions);
        }
        public IActionResult Question(int id)
        {

            ViewBag.CurrentQuestion=id;

            return View("Index",QuestionRepository.Questions);
        }
    }
}