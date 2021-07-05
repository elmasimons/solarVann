using InvestorROI.Model;
using InvestorROI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestorROI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorROIController : ControllerBase
    {
        readonly IInvestorROIRepository<Actor> repos;
        private readonly ILogger<InvestorROIController> logger;
        public InvestorROIController(IInvestorROIRepository<Actor> _repos, ILogger<InvestorROIController> _logger)
        {
            repos = _repos;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Actor> Get()
        {
            var actors = repos.GetAll();
            return actors.ToList();
        }
    }
}
