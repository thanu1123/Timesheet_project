using Microsoft.EntityFrameworkCore;
using Timesheet.Model;

namespace Timesheet.Context
{
    public class Uploadcontext: DbContext

    {
        public Uploadcontext(DbContextOptions<Uploadcontext> options) : base(options) { }

        public DbSet<UploadModel> TS_table { get; set; }

        public DbSet<EmployeeModel> ETS_table { get; set; }

    }
}
