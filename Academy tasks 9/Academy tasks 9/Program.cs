using System;

namespace Academy_tasks_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.StudentsLimit = 5;

            Student std1 = new Student
            {
                FullName = "Rza Mahmudov",
                GroupNo = "P231",
                Point = 100
            };

            Student std2 = new Student
            {
                FullName = "Rauf Ibrahimov",
                GroupNo = "V122",
                Point = 100
            };

            Student std3 = new Student
            {
                FullName = "Nermine Huseynli",
                GroupNo = "P232",
                Point = 90
            };
            course1.Students[0] = std1;
            course1.Students[1] = std2;
            course1.Students[2] = std3;

            try
            {
                course1.AddStudent(std1);
                course1.AddStudent(std2);
                course1.AddStudent(std3);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta bas verdi" + ex.Message);
            }
            
        }
        static void TryConvert(string input, ref int num)
        {
            try
            {
                num = Convert.ToInt32(input);
            }
            catch (Exception)
            {
                num = 0;
            }
        }

    }

    
}
