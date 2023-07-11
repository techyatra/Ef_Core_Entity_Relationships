using EFCore_Entity_Relationship.Entities.One_to_One_Mapping;

namespace EFCore_Entity_Relationship.Entities.One_to_Many_Mapping
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        
        //Convention 2 
        //for one to many mapping
        //public ICollection<Student> Students { get; set; } 
    }
}
