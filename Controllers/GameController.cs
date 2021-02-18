using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        public static List<Games> GetGames()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games(){ Id - 1, Name - "Game 1", Price - 10 });
            games.Add(new Games(){ Id - 1, Name - "Game 1", Price - 10 }); 
            games.Add(new Games(){ Id - 1, Name - "Game 1", Price - 10 });
            return games;
        }
        
    }
}
