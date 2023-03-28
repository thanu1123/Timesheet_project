using System.ComponentModel.DataAnnotations;

namespace TimesheetPoject.Model
{
    public class LoginModel
    {
        public string UserId { get; set; }
       [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
          ErrorMessage = "Invalid password pattern (Eg, Abcd!@#$%^&*1234)")]
        public string Password { get; set; }
        public string Confirmpassword { get; set; }

    }
}