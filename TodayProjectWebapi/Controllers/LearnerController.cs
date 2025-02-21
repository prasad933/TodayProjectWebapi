using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TodayProjectWebapi.IREPOSITORIES;
using TodayProjectWebapi.MODELS;

namespace TodayProjectWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnerController : ControllerBase
    {
        public ILearnerRepositories ILR ;
        public LearnerController(ILearnerRepositories _iLR)
        {
            ILR = _iLR;
        }

        [HttpPost]
        [Route("InsertLearner")]
         public async Task<IActionResult> InsertLearner(Learner learner)
        {
            try
            {
               var count=await ILR.InsertLearner(learner);
                if (count > 0) {
                return Ok(count);

                }
                else
                {
                    return NotFound("Records are not Inserted");
                }

            }
            catch (Exception ex) {

                return BadRequest("Something went wrong" + ex.Message + "Will resolve soon");
            }
        }


        [HttpGet]
        [Route("GetLearners")]
        public async Task<IActionResult> GetLearners()
        {
            try
            {
                var Learn = await ILR.GetLearners();
                if (Learn !=null)
                {
                    return Ok(Learn);

                }
                else
                {
                    return NotFound("Records are not Available");
                }

            }
            catch (Exception ex)
            {

                return BadRequest("Something went wrong" + ex.Message + "Will resolve soon");
            }
        }

       

        [HttpGet]
        [Route("GetLearnerID")]
        public async Task<IActionResult> GetLearnerID(int LearnerId)
        {
            try
            {
                var Learn = await ILR.GetLearnerID(LearnerId);
                if (Learn != null)
                {
                    return Ok(Learn);

                }
                else
                {
                    return NotFound("Records are not Available");
                }

            }
            catch (Exception ex)
            {

                return BadRequest("Something went wrong" + ex.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetLearnerByCourseID")]
        public async Task<IActionResult> GetLearnerByCourseID(int CourseId)
        {
            try
            {
                var Learn = await ILR.GetLearnerByCourseID(CourseId);
                if (Learn != null)
                {
                    return Ok(Learn);

                }
                else
                {
                    return NotFound("Records are not Available");
                }

            }
            catch (Exception ex)
            {

                return BadRequest("Something went wrong" + ex.Message + "Will resolve soon");
            }
        }





        [HttpDelete]
        [Route("DeleteLearner")]
        public async Task<IActionResult> DeleteLearner(int LearnerId)
        {
            try
            {
                var count = await ILR.DeleteLearner(LearnerId);
                if (count > 0)
                {
                    return Ok(count);

                }
                else
                {
                    return NotFound("Records are not Deleted");
                }

            }
            catch (Exception ex)
            {

                return BadRequest("Something went wrong" + ex.Message + "Will resolve soon");
            }
        }


        [HttpPut]
        [Route("UpdateLearner")]
        public async Task<IActionResult> UpdateLearner(Learner learner)
        {
            try
            {
                var count = await ILR.UpdateLearner( learner);
                if (count > 0)
                {
                    return Ok(count);

                }
                else
                {
                    return NotFound("Records are not Updated");
                }

            }
            catch (Exception ex)
            {

                return BadRequest("Something went wrong" + ex.Message + "Will resolve soon");
            }
        }

    }
}
