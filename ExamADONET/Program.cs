using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EducationalInstitutionContext())
            {
                //context.Teachers.ToList();
                #region Add
                Subject subject = new Subject();
                subject.Id = 0;
                subject.SubjectName = "Математика";
                //--
                Teacher teacher = new Teacher();
                teacher.Id = 0;
                teacher.Name = "Александр";
                teacher.Surname = "Иванов";
                teacher.Patronymic = "Иванович";
                teacher.Experience = 12;
                teacher.Rank = "Магистр";
                //--
                Student student = new Student();
                student.Id = 0;
                student.Name = "Алексей";
                student.Surname = "Попов";
                student.Patronymic = "Александрович";
                student.MidleScore = 8.9;
                //--
                Group group = new Group();
                group.Id = 0;
                group.GroupName = "КТА-7";
                group.Class = 2;
                //--
                Schedule schedule = new Schedule();
                schedule.Id = 0;
                schedule.TimeStart = DateTime.Now;
                schedule.TimeEnd = DateTime.Now.AddHours(3);
                schedule.Subject = subject;
                schedule.Teacher = teacher;
                schedule.Group = group;
                //--
                context.Students.Add(student);
                context.Subjects.Add(subject);
                context.Teachers.Add(teacher);
                context.Groups.Add(group);
                context.Schedules.Add(schedule);
                //--
                context.SaveChanges();
                #endregion

                var result = from sch in context.Schedules
                             join sub in context.Subjects
                             on sch.SubjectId equals sub.Id
                             join gr in context.Groups
                             on sch.GroupId equals gr.Id
                             join tch in context.Teachers
                             on sch.TeacherId equals tch.Id
                             select new { sch.Id, sch.Subject.SubjectName, sch.Group.GroupName, sch.Teacher.Surname, sch.Teacher.Name, sch.Teacher.Patronymic };
            }
        }
    }
}
