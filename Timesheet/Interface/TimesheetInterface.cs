using Microsoft.AspNetCore.Mvc;
using Timesheet.Model;

namespace Timesheet.Interface
{
    public interface TimesheetInterface
    {
        public IActionResult Regester(RegestrationModel regestrationModel);
        public IActionResult Login(LoginModel loginModel);
        public IActionResult ResetPassword(LoginModel loginModel);
    }
}
