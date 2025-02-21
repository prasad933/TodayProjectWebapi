using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodayProjectWebapi.DBCONTEXT;
using TodayProjectWebapi.IREPOSITORIES;
using TodayProjectWebapi.MODELS;

namespace TodayProjectWebapi.REPOSITORIES
{
    public class CourseRepository : ICourseRepositories
    {

        public TodayprojectDBContext Tdb;

        public CourseRepository(TodayprojectDBContext _Tdb)
        {
            Tdb = _Tdb;
        }


        public async Task<List<Course>> GetAllCourse()
        {
              return await Tdb.Courses.ToListAsync();
        }

        public async Task<Course> GetCourseId(int courseId)
        {
          return await Tdb.Courses.FindAsync(courseId);
        }

        
        public async Task<int> InsertCource(Course Cource)
        {
           await Tdb.Courses.AddAsync(Cource);
            return await Tdb.SaveChangesAsync();
        }

        public async Task<int> UpdateCource(Course Cource)
        {
            Tdb.Courses.Update(Cource);
            return await Tdb.SaveChangesAsync(); 
        }

        public async Task<int> DeleteCource(int CourceId)
        {
            var fid = Tdb.Courses.Find(CourceId);
            Tdb.Courses.Remove(fid);
            return await Tdb.SaveChangesAsync();
        }

        public async Task<Course> GetCourseName(string CourseName)
        {
           //await Tdb.Courses.Where(x=>x.CourseName==CourseName).SingleOrDefaultAsync();
            return await Tdb.Courses.Where(x => x.CourseName == CourseName).SingleOrDefaultAsync();
        }
    }
}
