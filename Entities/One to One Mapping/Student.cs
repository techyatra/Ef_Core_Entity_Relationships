using EFCore_Entity_Relationship.Entities.Many_to_Many_Mapping;
using EFCore_Entity_Relationship.Entities.One_to_Many_Mapping;

namespace EFCore_Entity_Relationship.Entities.One_to_One_Mapping
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentAddress Address { get; set; }

        //for one to many relationship
         public Grade Grade { get; set; }

        //for many to many relationship
        public IList<Course> StudentCourses { get; set; }
    }
}
