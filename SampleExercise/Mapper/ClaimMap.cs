using CsvHelper.Configuration;
using SampleExercise.Implementations;
using SampleExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleExercise.Mapper
{
    public sealed class ClaimMap : ClassMap<Claim>
    {
        public ClaimMap()
        {
            Map(m => m.MemberID).Name(Constants.MEMBER_ID);
            Map(m => m.ClaimDate).Name(Constants.CLAIM_DATE);
            Map(m => m.ClaimAmount).Name(Constants.CLAIM_AMOUNT);
        }
    }
}

