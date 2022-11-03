using SevStudentsApp.Models;

namespace SevStudentsApp.DAO
{
    public interface IStudentCourseDAO
    {
        void Insert(StudentCourse? studentCourse);
        void Update(StudentCourse? studentCourse);
        StudentCourse? Delete(StudentCourse? studentCourse);
        StudentCourse? GetStudentCourse(int studentId, int courseId);
        List<StudentCourse> GetAll();
        List<Student> GetAllS();
        List<Course> GetAllC();
        Student? GetStudent(int id);
        Course? GetCourse(int id);
        
    }
}
