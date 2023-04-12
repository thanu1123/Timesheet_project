﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TimeSheet.Model
{
    public class TimeSheets
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeSheet_Id { get; set; }

        [ForeignKey("Employee_Id")]
        public int Employee_Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public DateTime? Date { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public string Day { get; set; }

        public bool Leave { get; set; }

        [ForeignKey("Project_Id")]
        public int Project_Id { get; set; }

        [ForeignKey("TimesheetSummary_Id")]
        public int TimesheetSummary_Id { get; set; }

        public int Duration_in_Hours { get; set; }
    }
}
