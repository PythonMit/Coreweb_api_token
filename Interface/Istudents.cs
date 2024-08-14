using Coreweb_api_token.Model;

namespace Coreweb_api_token.Interface
{
    public interface Istudents
    {
        public List<Student> GetStudentDetails();
        public Student GetStudentDetailsByid(int id);
        public void AddStudent(Student employee);
        public void UpdateStudent(Student employee);
        public Student DeleteStudent(int id);
        public bool CheckStudent(int id);
    }
}
