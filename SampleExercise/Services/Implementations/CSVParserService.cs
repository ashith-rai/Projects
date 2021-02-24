using CsvHelper;
using CsvHelper.TypeConversion;
using SampleExercise.Mapper;
using SampleExercise.Models;
using SampleExercise.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExercise.Services.Implementations
{
    public class CSVParserService : ICsvParserService
    {
        public List<Member> ReadCsvFileToMemberModel(string memberCsvPath)
        {
            try
            {
                using (var reader = new StreamReader(memberCsvPath, Encoding.Default)) 
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                {
                    var options = new TypeConverterOptions { Formats = new[] { "MM/dd/yyyy" } };
                    csv.Configuration.TypeConverterOptionsCache.AddOptions<DateTime>(options);
                    csv.Configuration.RegisterClassMap<MemberMap>();
                    var records = csv.GetRecords<Member>().ToList();
                    return records;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e)
            {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Claim> ReadCsvFileToClaimModel(string claimCsvPath)
        {
            try
            {
                using (var reader = new StreamReader(claimCsvPath, Encoding.Default))
                using (var csv = new CsvReader((IParser)reader))
                {
                    csv.Configuration.RegisterClassMap<ClaimMap>();
                    var records = csv.GetRecords<Claim>().ToList();
                    return records;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e)
            {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void WriteNewCsvFile(string path, List<Member> memberModels, List<Claim> claimModels)
        {
            using (StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(true)))
            using (CsvWriter cw = new CsvWriter((ISerializer)sw))
            {
                cw.WriteHeader<Member>();
                cw.NextRecord();
                foreach (Member mem in memberModels)
                {
                    cw.WriteRecord<Member>(mem);
                    cw.NextRecord();
                }

                cw.WriteHeader<Claim>();
                cw.NextRecord();
                foreach (Claim clm in claimModels)
                {
                    cw.WriteRecord<Claim>(clm);
                    cw.NextRecord();
                }
            }
        }
    }
}
