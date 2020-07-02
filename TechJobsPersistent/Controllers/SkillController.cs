using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class SkillController : Controller
    {
        private JobDbContext context;

        public SkillController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Skill> skills = context.Skills.ToList();

            return View(skills);
        }

        public IActionResult Add()
        {
            AddSkillViewModel addSkillViewModel = new AddSkillViewModel();
            return View(addSkillViewModel);
        }

        public IActionResult ProcessAddSkillForm(AddSkillViewModel addSkillViewModel)
        {
            if (ModelState.IsValid)
            {
                Skill newSkill = new Skill
                {
                    Name = addSkillViewModel.Name,
                    Description = addSkillViewModel.Description
                };

                context.Skills.Add(newSkill);
                context.SaveChanges();

                return Redirect("/Skill");
            }

            return View("Add", addSkillViewModel);
        }

        [HttpGet("Skill/About/{skillId?}")]
        public IActionResult About(int skillId)
        {
            Skill skill = context.Skills.Find(skillId);

            return View(skill);
        }
    }
}
