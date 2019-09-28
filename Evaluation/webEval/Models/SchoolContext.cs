namespace mvcAddress.Models
{
    using System.Data.Entity;
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<webEval.Models.Student> Students { get; set; }
    }
}
