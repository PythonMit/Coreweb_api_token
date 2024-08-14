using Microsoft.EntityFrameworkCore;
using Coreweb_api.Models;
using Coreweb_api_token.Interface;
using Coreweb_api_token.Model;

namespace Coreweb_api_token.Repository
{

   
    public class StudentRepository : Istudents
    {
        readonly StudDataContext _context;
            
        public StudentRepository(StudDataContext Context)
        {
            _context = Context;
        }

        public void AddStudent(Student student)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckStudent(int id)
        {
            return _context.Students.Any(e => e.Stuid == id);
        }

        public Student DeleteStudent(int id)
        {
            try
            {
                Student? student = _context.Students.Find(id);

                if (student != null)
                {
                    _context.Students.Remove(student);
                    _context.SaveChanges();
                    return student;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Student> GetStudentDetails()
        {
            try
            {
                return _context.Students.ToList();
            }
            catch
            {
                throw new NotImplementedException();
            }
           
        }

        public Student GetStudentDetailsByid(int id)
        {
            try
            {
                Student? student = _context.Students.Find(id);
                if (student != null)
                {
                    return student;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateStudent(Student student)
        {
            try
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
