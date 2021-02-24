using CsvHelper.Configuration.Attributes;
using SampleExercise.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleExercise.Models
{
    public class Claim
    {
        [Name(Constants.MEMBER_ID)]
        public int MemberID;
        [Name(Constants.CLAIM_DATE)]
        public DateTime ClaimDate;
        [Name(Constants.CLAIM_AMOUNT)]
        public decimal ClaimAmount;
    }
}
