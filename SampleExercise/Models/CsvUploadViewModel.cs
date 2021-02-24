using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleExercise.Models
{
    public class CsvUploadViewModel
    {
        [Required]
        public IFormFile MemberCsv { get; set; }

        [Required]
        public IFormFile ClaimCsv { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ClaimDate { get; set; }

    }
}
