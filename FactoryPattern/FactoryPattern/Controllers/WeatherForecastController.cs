using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.Core;
using FactoryPattern.Repository.EFCore;
using FactoryPattern.Repository.Sugar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FactoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            // 实例化工厂，这里用来生产 efcore 这一系列的 产品
            AbstractFactory efcoreFactory = new EFCoreRepositoryFactory();
            efcoreFactory.UserRepository().Add();
            efcoreFactory.RoleRepository().Delete();
            efcoreFactory.PermissionRepository().Query();


            // 实例化工厂，这里用来生产 sugar 这一系列的 产品
            AbstractFactory sugarFactory = new SugarRepositoryFactory();
            sugarFactory.UserRepository().Add();
            sugarFactory.RoleRepository().Delete();
            sugarFactory.PermissionRepository().Query();


        }
    }
}
