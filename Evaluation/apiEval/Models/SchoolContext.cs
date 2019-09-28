namespace apiEval.Models
{
    using System.Data.Entity;
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiEval.Models.Student> Students { get; set; }
    }
}