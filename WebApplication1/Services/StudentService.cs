using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> GetAllByKey(string key = "")
        {
            var data = await _studentRepository.GetAllAsync();
            return key != "" ? data.Where(s =>
            s.Firstname.ToLower().Contains(key.ToLower())).ToList()
            : data;
        }
    }
}
