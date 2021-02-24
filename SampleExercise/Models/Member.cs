using CsvHelper.Configuration.Attributes;
using SampleExercise.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleExercise.Models
{
    public class Member
    {
        [Name(Constants.MEMBER_ID)]
        public int MemberID;
        [Name(Constants.ENROLLMENT_DATE)]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate;
        [Name(Constants.FIRST_NAME)]
        public DateTime FirstName;
        [Name(Constants.LAST_NAME)]
        public DateTime LastName;
    }
}
