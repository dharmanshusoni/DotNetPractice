using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.DotNetClasses
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }

    internal class LinqQueries
    {

        public static void Main1()
        {
            IList<string> strList1 = new List<string>() {
                    "One",
                    "Two",
                    "Three",
                    "Four"
                };

            IList<string> strList2 = new List<string>() {
                    "One",
                    "Two",
                    "Five",
                    "Six"
                };

            var innerJoin = strList1.Join(strList2,
                                  str1 => str1,
                                  str2 => str2,
                                  (str1, str2) => str1);




            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
            new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
            new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
            new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
            new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            IList<Standard> standardList = new List<Standard>() {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var innerJoinNew = studentList.Join(// outer sequence 
                                  standardList,  // inner sequence 
                                  student => student.StandardID,    // outerKeySelector
                                  standard => standard.StandardID,  // innerKeySelector
                                  (student, standard) => new  // result selector
                                  {
                                      student.StudentName,
                                      standard.StandardName
                                  });

            var td = (from s in studentList
                     join r in standardList
                     on s.StudentID equals r.StandardID
                     where s.StudentName == r.StandardName
                     select s.StudentName).SingleOrDefault();
        }
    }
}
