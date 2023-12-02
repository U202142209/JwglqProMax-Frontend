using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwglqProMax_Frontend
{
    class Course
    {
        public string courseNumber;        // 课程号
        public string NotificationNumber;  // 通知单编号
        public string CourseName;          // 课程名称
        public string MainTeacher;         // 主讲教师;
        public string EnrollmentLimit;     // 限选人数;
        public string CourseAvailability;  // 课余量
        public string CourseType;          // 课程性质;
        public string Credits;             // 学分;

        public Course()
        {
            // Parameterless constructor
        }

        public Course(string cousrseNumber, string notificationNumber, string courseName, string mainTeacher, string enrollmentLimit, string courseAvailability, string courseType, string credits)
        {
            courseNumber = cousrseNumber;
            NotificationNumber = notificationNumber;
            CourseName = courseName;
            MainTeacher = mainTeacher;
            EnrollmentLimit = enrollmentLimit;
            CourseAvailability = courseAvailability;
            CourseType = courseType;
            Credits = credits;
        }

        public override string ToString()
        {
            return this.CourseName;
        }
    }

}
