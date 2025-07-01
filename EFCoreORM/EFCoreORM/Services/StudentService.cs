using EFCoreORM.Data;
using EFCoreORM.Models;

namespace EFCoreORM.Services
{
    public class StudentService
    {
        private readonly AppDbContext _context;

        public StudentService()
        {
            _context = new AppDbContext();
        }

        public void AddStudent(string fullName, int age)
        {
            var student = new Student
            {
                FullName = fullName,
                Age = age
            };
            _context.Students.Add(student);
            _context.SaveChanges();
            Console.WriteLine("Student added");
        }

        public void ListStudents()
        {
            var students = _context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.FullName}, Age: {student.Age}");
            }
        }

        public void UpdateStudent(int id, string fullName, int age)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                student.FullName = fullName;
                student.Age = age;
                _context.SaveChanges();
                Console.WriteLine("Student updated");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                Console.WriteLine("Student deleted");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }
    }
}
