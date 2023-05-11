using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public ActionResult GetList()
        {
            List<Teachers> Teachers = new List<Teachers>()
            {
                new Teachers(){
                    name="Nebahat",
                    surname="Akkiraz",
                    branch="Fen Bilgisi",
                    schools = new List<School>(){
                        new School(){
                            code="01254",
                            name="Adana Abdülkadir Paksoy Kyz Lisesi",
                            _default=false,
                            classes=new List<Classes>()
                            {
                                new Classes()
                                {
                                    brach="7-D",
                                    lesson="Fen Bilgisi",
                                    studentCount=36,
                                    classCode=18
                                },
                                new Classes()
                                {
                                    brach="6-D",
                                    lesson="Matematik",
                                    studentCount=28,
                                    classCode=19
                                }
                            }
                        },
                        new School(){
                            code="01253",
                            name="Ceyhan Lisesi",
                            _default=false,
                            classes=new List<Classes>()
                            {
                                new Classes()
                                {
                                    brach="7-D",
                                    lesson="Fen Bilgisi",
                                    studentCount=23,
                                    classCode=4
                                },
                                new Classes()
                                {
                                    brach="6-E",
                                    lesson="Matematik",
                                    studentCount=17,
                                    classCode=2
                                }
                            }
                        }
                    }
                }
            };

            try
            {
                return Ok(new Result(true, "", Teachers));
            }
            catch (Exception ex)
            {
                return BadRequest(new Result(false, ex.Message, null));
            }
        }
    }


    public class Teachers
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string branch { get; set; }
        public List<School> schools { get; set; }
    }

    public class School
    {
        public string code { get; set; }
        public string name { get; set; }
        public bool _default { get; set; }
        public List<Classes> classes { get; set; }
    }

    public class Classes
    {
        public string brach { get; set; }
        public string lesson { get; set; }
        public int studentCount { get; set; }
        public int classCode { get; set; }
    }

}
