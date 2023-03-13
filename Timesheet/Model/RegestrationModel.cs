using System.ComponentModel.DataAnnotations;

namespace Timesheet.Model
{
    public class RegestrationModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public string HashKeyPassword { get; set; }

        public string Conformpassword { get; set; }
    }
}
