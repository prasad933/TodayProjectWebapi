using System.Collections.Generic;
using System.Threading.Tasks;
using TodayProjectWebapi.MODELS;

namespace TodayProjectWebapi.IREPOSITORIES
{
    public interface ICourseRepositories
    {
        Task<List<Course>> GetAllCourse();

        Task<Course> GetCourseId(int courseId);
        Task<Course> GetCourseName(string CourseName);

        Task<int> InsertCource(Course Cource);
        Task<int> UpdateCource(Course Cource);

        Task<int> DeleteCource(int CourceId);
    }
}
