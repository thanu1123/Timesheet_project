﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TimeSheet.Model
{
    public class ViewPreviousChanges
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Employee_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Employee_code { get; set; }
        public string Reporting_Manager1 { get; set; }
        public string Reportinng_Manager2 { get; set; }

        [ForeignKey("Employee_Type_Id")]
        public int Employee_Type_Id { get; set; }
        public string Email { get; set; }
        public string Alternate_Email { get; set; }
        
        [ForeignKey("Designation_Id")]
        public int Designation_Id { get; set; }
        public string Contact_No { get; set; }
        public bool Is_Active { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public DateTime Joining_Date { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public Nullable<DateTime> End_Date { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YYYY}")]
        public Nullable<DateTime> Modified_Date { get; set; }
    }
}
