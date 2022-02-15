namespace NSCCCourseMap.Models{
public class Diploma {
// SCALAR PROPERTIES
public int Id { get; set; }
public string Title{ get; set; } = string.Empty;

// NAVIGATION PROPERTY 
public ICollection<DiplomaYear>? DiplomaYears { get; set; }
}
}