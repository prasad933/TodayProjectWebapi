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
    public class CourseController : ControllerBase
    {

        public ICourseRepositories Icr;

        public CourseController(ICourseRepositories _Icr)
        {
            Icr = _Icr;
        }

        [HttpPost]
        [Route("InsertCource")]
        public async Task<IActionResult> InsertCource(Course Cource)
        {
            try
            {
               var count=await Icr.InsertCource(Cource);
                if (count>0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("No Record Inserted");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong"+ex+"will resolve soon");
            }
        }


        [HttpGet]
        [Route("GetAllCourse")]
        public async Task<IActionResult> GetAllCourse()
        {
            try
            {
                var CourcList = await Icr.GetAllCourse();
                if (CourcList.Count>0)
                {
                    return Ok(CourcList);
                }
                else
                {
                    return NotFound("No Record Available");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong" + ex + "will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetCourseName")]
        public async Task<IActionResult> GetCourseName(string CourseName)
        {
            try
            {
                var Courc = await Icr.GetCourseName(CourseName);
                if (Courc != null)
                {
                    return Ok(Courc);
                }
                else
                {
                    return NotFound("No Record Available");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong" + ex + "will resolve soon");
            }
        }


        [HttpGet]
        [Route("GetCourseId")]
        public async Task<IActionResult> GetCourseId(int courseId)
        {
            try
            {
                var Courc = await Icr.GetCourseId(courseId);
                if (Courc !=null)
                {
                    return Ok(Courc);
                }
                else
                {
                    return NotFound("No Record Available");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong" + ex + "will resolve soon");
            }
        }



        [HttpPut]
        [Route("UpdateCource")]
        public async Task<IActionResult> UpdateCource(Course Cource)
        {
            try
            {
                var count = await Icr.UpdateCource(Cource);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("No Record Updated");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong" + ex + "will resolve soon");
            }
        }


        [HttpDelete]
        [Route("InsertCource")]
        public async Task<IActionResult> DeleteCource(int CourceId)
        {
            try
            {
                var count = await Icr.DeleteCource(CourceId);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("No Record Deleted");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong" + ex + "will resolve soon");
            }
        }





    }
}
