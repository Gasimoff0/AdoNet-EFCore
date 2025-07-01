

using ADONET.Models;
using Microsoft.Data.SqlClient;

namespace ADONET.Services
{
    public class StudentService
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=AdoNetDB;TrustServerCertificate=True;Trusted_Connection=True;";

        // CREATE
        public void AddStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Students (FullName, Age) VALUES (@FullName, @Age)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@Age", student.Age);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // READ
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Students";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = (int)reader["Id"],
                            FullName = reader["FullName"].ToString(),
                            Age = (int)reader["Age"]
                        });
                    }
                }
            }

            return students;
        }

        // UPDATE
        public void UpdateStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Students SET FullName = @FullName, Age = @Age WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@Age", student.Age);
                    cmd.Parameters.AddWithValue("@Id", student.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void DeleteStudent(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Students WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
