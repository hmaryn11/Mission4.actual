using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission41.Models
{
    public class GradeCalcModel
    {
        //create attributes of the class for each input
       //Here we add a required range for the input 0 to 100 and if input does not meet requirements, an error message will let the user know
        [Range(0, 100, ErrorMessage = "The percentages must be between 0 and 100")]
        public float ClsAssign { get; set; } //the "{get; set;}" does everything that the below code does for you.

        [Range(0, 100, ErrorMessage = "The percentages must be between 0 and 100")]
        public float ClsGp { get; set; }

        [Range(0, 100, ErrorMessage = "The percentages must be between 0 and 100")]
        public float ClsQuiz { get; set; }

        [Range(0, 100, ErrorMessage = "The percentages must be between 0 and 100")]
        public float ClsMid { get; set; }

        [Range(0, 100, ErrorMessage = "The percentages must be between 0 and 100")]
        public float ClsFinal { get; set; }

        [Range(0, 100, ErrorMessage = "The percentages must be between 0 and 100")]
        public float ClsIntex { get; set; }
    }
}
