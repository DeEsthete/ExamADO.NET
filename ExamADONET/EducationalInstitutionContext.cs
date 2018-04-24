namespace ExamADONET
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EducationalInstitutionContext : DbContext
    {
        public EducationalInstitutionContext()
            : base("name=EducationalInstitutionContext")
        {
        }

        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}