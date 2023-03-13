using Microsoft.EntityFrameworkCore;
using Timesheet.Model;

namespace Timesheet.Context_Timesheet
{
    public class Timesheet_Context : DbContext
    {
        public Timesheet_Context(DbContextOptions<Timesheet_Context> options) : base(options) { }
        public DbSet<RegestrationModel> Employee_Timesheet { get; set; }
    }
}
