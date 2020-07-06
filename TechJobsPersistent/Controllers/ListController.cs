using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Models;
using TechJobsPersistent.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class ListController : Controller
    {
        private JobDbContext context;

        public ListController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // list jobs by column and value
        public IActionResult Jobs(string column, string value)
        {
            List<Job> jobs;
            if (column.ToLower().Equals("all"))
            {
                jobs = context.Jobs.Include(j => j.Employer).ToList();
                ViewBag.title = "All Jobs";
            }
            else
            {
                jobs = context
                // ViewBag.title = "Jobs with " + ColumnChoices[column] + ": " + value;
            }
            // ViewBag.jobs = jobs;

            return View();
        }


    }
}
