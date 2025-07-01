using EFCoreORM.Services;

namespace EFCoreORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new StudentService();
            service.AddStudent("John Doe",20);
            service.AddStudent("Jane Doe",22);
            service.AddStudent("Frank Drake",22);
            service.UpdateStudent(1,"John Smith",21);
            service.DeleteStudent(2);
            service.ListStudents();

        }
    }
}
