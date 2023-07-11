using EFCore_Entity_Relationship.Entities.One_to_One_Mapping;

namespace EFCore_Entity_Relationship.Entities.Many_to_Many_Mapping
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        //for many to many relationship 
        public IList<Student> Student { get; set; }
    }
}
