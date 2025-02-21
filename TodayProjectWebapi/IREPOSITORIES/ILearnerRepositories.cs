using System.Collections.Generic;
using System.Threading.Tasks;
using TodayProjectWebapi.MODELS;

namespace TodayProjectWebapi.IREPOSITORIES
{
    public interface ILearnerRepositories
    {
        Task<List<Learner>> GetLearners();
        Task<Learner> GetLearnerID(int LearnerId);

        Task<Learner> GetLearnerByCourseID(int CourseId);

        Task<int> InsertLearner(Learner learner);

        Task<int> UpdateLearner(Learner learner);
        Task<int> DeleteLearner(int LearnerId);

       

    }
}
