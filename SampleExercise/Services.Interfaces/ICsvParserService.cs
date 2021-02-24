using SampleExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleExercise.Services.Interfaces
{
    public interface ICsvParserService
    {
        //List<Member>ReadCsvFileToMemberModel(CsvUploadViewModel csvUploadViewModel); 
        List<Member> ReadCsvFileToMemberModel(string memberCsvPath);
        //List<Claim> ReadCsvFileToClaimModel(CsvUploadViewModel csvUploadViewModel);
        List<Claim> ReadCsvFileToClaimModel(string claimCsvPath);
        //void WriteNewCsvFile(string path, List<Member> memberModels, List<Claim> claimModels);
    }
}
