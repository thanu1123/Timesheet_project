using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheet.Model
{
    public class UploadModel
    {
        public string Id { get; set; }

        public string Day { get; set; } 

        public string Type { get; set; }    

        public int total_hours { get; set; }

        [ForeignKey("user_id")]
        public int user_id { get; set; }
        
    }
}
