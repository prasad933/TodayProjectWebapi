using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodayProjectWebapi.DBCONTEXT;
using TodayProjectWebapi.IREPOSITORIES;
using TodayProjectWebapi.MODELS;

namespace TodayProjectWebapi.REPOSITORIES
{
    public class LearnerRepositories : ILearnerRepositories
    {
        public TodayprojectDBContext TDC ;

        public LearnerRepositories(TodayprojectDBContext _TDC)
        {
            TDC = _TDC;
        }

        public async Task<List<Learner>> GetLearners()
        {
            return await TDC.Learners.ToListAsync();

        }

        public async Task<int> InsertLearner(Learner learner)
        {
            await TDC.Learners.AddAsync(learner);
            return await TDC.SaveChangesAsync();
        }

        public async Task<int> UpdateLearner(Learner learner)
        {
            TDC.Learners.Update(learner);
            return await TDC.SaveChangesAsync();
        }
        public async Task<int> DeleteLearner(int LearnerId)
        {
            var LID =  TDC.Learners.Find(LearnerId);
            TDC.Learners.Remove(LID);
            return await TDC.SaveChangesAsync();
        }

        public async Task<Learner> GetLearnerByCourseID(int CourseId)
        {
            return await TDC.Learners.Where(x=>x.CourseId == CourseId).SingleOrDefaultAsync();
        }

        public async Task<Learner> GetLearnerID(int CourseId)
        {
            return  await TDC.Learners.FindAsync(CourseId);
        }
        

       
    }
}
