using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADONET
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Experience { get; set; }
        public string Rank { get; set; }
        public virtual IEnumerable<Subject> Subjects { get; set; }
        public virtual IEnumerable<Group> Groups { get; set; }
    }
}
