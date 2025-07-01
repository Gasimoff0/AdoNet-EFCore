using ADONET.Models;
using ADONET.Services;

namespace ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService();
            //studentService.AddStudent(new Student { FullName = "John Doe", Age = 20 });
            //studentService.AddStudent(new Student { FullName = "Jane Smith", Age = 22 });


            //studentService.GetAllStudents().ForEach(s => 
            //{
            //    Console.WriteLine($"Id: {s.Id},Name: {s.FullName}, Age: {s.Age}");
            //});

            //studentService.UpdateStudent(new Student { Id = 5, FullName = "Nate Drake", Age = 33 });

            //studentService.DeleteStudent(5);
        }
    }
}
