using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SampleExercise.Models;
using SampleExercise.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SampleExercise.Controllers
{
    [ApiController]
    [Route("api/Sample")]
    public class SampleExerciseController : ControllerBase
    {
        [HttpGet, Route("Claims")]
        public async Task<IActionResult> GetMemberClaims([FromForm] string claimDate)
        {
            string memberCsvPath = "C:\\Applications\\SampleProject\\Member.csv";
            string claimCsvPath = "C:\\Applications\\SampleProject\\Claim.csv";

            if (!string.IsNullOrEmpty(claimDate))
            {

                var csvParserService = new CSVParserService();
                var memberResult = csvParserService.ReadCsvFileToMemberModel(memberCsvPath);
                var claimResult = csvParserService.ReadCsvFileToClaimModel(claimCsvPath);

                var memberToAdd = new Member();
                memberResult.Add(memberToAdd);

                var claimToAdd = new Claim();
                claimResult.Add(claimToAdd);
                //csvParserService.WriteNewCsvFile(, result);
                return Ok(memberResult.ToList());
            }

            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            return Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message);
        }
    }

}

