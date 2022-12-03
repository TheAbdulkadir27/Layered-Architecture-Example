using BusinessLayer.Abstract;
using BusinessLayer.FluentValidator;
using EntityLayer.concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
namespace AgrıCultureProject.Controllers
{
    public class TeamController1 : Controller
    {
        ITeamService teamService;

        public TeamController1(ITeamService teamService)
        {
            this.teamService = teamService;
        }
        public IActionResult Index()
        {
            return View(teamService.GetList());
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult validation = validationRules.Validate(team);
            if (validation.IsValid)
            {
                teamService.İnsert(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteTeam(int id)
        {
            teamService.Delete(teamService.getbyid(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            return View(teamService.getbyid(id));
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult validation = validationRules.Validate(team);
            if (validation.IsValid)
            {
                teamService.Update(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}