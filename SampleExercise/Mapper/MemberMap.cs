using CsvHelper.Configuration;
using SampleExercise.Implementations;
using SampleExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleExercise.Mapper
{
    public class MemberMap : ClassMap<Member>
    {
        public MemberMap()
        {
            Map(m => m.MemberID);
            Map(m => m.EnrollmentDate).TypeConverterOption.Format("MM/dd/yyyy"); 
            Map(m => m.FirstName);
            Map(m => m.LastName);
        }
    }
}
