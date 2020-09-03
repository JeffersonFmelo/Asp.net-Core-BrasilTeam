using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrasilTeamMVC.Models;

namespace BrasilTeamMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("Esta e a pagina padrao");
        }

        public IActionResult Selecao(string nomejogador = "jefferson" , int idade = 24)
        {
            //return Content($"Brasil Seleção tem como jogador {nomejogador} com  a idade de {idade}");
            ViewData["Mensagem"] = " Essa é a Selecao campeã de 1994 com o jogador " + nomejogador;
            ViewData["Idade"] = idade;
            return View();

        }

        public IActionResult Brasil()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
