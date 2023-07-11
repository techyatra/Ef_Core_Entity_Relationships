using EFCore_Entity_Relationship.Entities.Many_to_Many_Mapping;
using EFCore_Entity_Relationship.Entities.One_to_One_Mapping;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Entity_Relationship.Context
{
    public class EFCoreRelationshipContext : DbContext
    {
        public EFCoreRelationshipContext(DbContextOptions<EFCoreRelationshipContext> options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
