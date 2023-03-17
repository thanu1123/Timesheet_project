using Microsoft.AspNetCore.Mvc;
using TimesheetPoject.Context_Timesheet;
using TimesheetPoject.Interface;
using TimesheetPoject.Model;

namespace TimesheetPoject.Repository
{
    public class UploadRepo : ControllerBase, IUploadInterface
    {
        private readonly Timesheet_Context _context;



        public UploadRepo(Timesheet_Context con)
        {
            _context = con;
        }

        public IActionResult add(UploadModel[] entries)
        {
            var model = new UploadModel();

            for (var i = 0; i < entries.Length; i++)
            {
                model.total_hours = entries[i].total_hours;
                model.Date = DateTime.Now.Date;
                model.Day = entries[i].Day;
                model.Status = entries[i].Status;
                model.month = entries[i].month;
                _context.TS_table.Add(model);
                _context.SaveChanges();
            }
            return Ok();

        }
        public IActionResult add1(EmployeeModel[] entries)
        {
            var model1 = new EmployeeModel();

            for (var i = 0; i < entries.Length; i++)
            {
                RegistrationModel register=new RegistrationModel();
                model1.UserId = register.UserId;
                model1.Employee_Name = register.Username;
                model1.Employee_Email = register.Email;
                model1.Joining_date = register.DateOfJoin;
                model1.Phone_Number = register.PhoneNumber;
                _context.ETS_table.Add(model1);
                _context.SaveChanges();
            }
            return Ok();
        }
        public List<EmployeeModel> GetEmpDet(int userId)
        {
            var data = from t in this._context.ETS_table
                       select new EmployeeModel
                       {
                           Id = t.Id,
                           UserId= t.UserId,
                           Employee_Name=t.Employee_Name,
                           Employee_Email= t.Employee_Email,
                           Joining_date= t.Joining_date,
                           Phone_Number= t.Phone_Number   
                       };
            return data.ToList();
        }
        public List<UploadModel> GetTSDet(int userId)
        {
            var data = from t in this._context.TS_table
                       select new UploadModel
                       {
                           Id = t.Id,
                           Date= t.Date,
                           Day= t.Day,
                           month=t.month,
                           Status= t.Status,
                           total_hours =t.total_hours
                       };
            return data.ToList();
        }

    }
}