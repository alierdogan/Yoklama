using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using System.Net.Http.Headers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //[EnableCors()]
        [HttpGet]
        [Route("")]
        public ActionResult Get()
        {
            List<Teachers> Teachers = new()
            {
                new Teachers(){
                    Name="Nebahat",
                    Surname="Akkiraz",
                    Branch="Fen Bilgisi",
                    Schools = new List<Okul>(){
                        new Okul(){
                            Code="01254",
                            Name="Adana Abdülkadir Paksoy Kyz Lisesi",
                            Default=false,
                            Classes=new List<Classes>()
                            {
                                new Classes()
                                {
                                    Brach="7-D",
                                    Lesson="Fen Bilgisi",
                                    StudentCount=36,
                                    ClassCode=18
                                },
                                new Classes()
                                {
                                    Brach="6-D",
                                    Lesson="Matematik",
                                    StudentCount=28,
                                    ClassCode=19
                                }
                            }
                        },
                        new Okul(){
                            Code="01253",
                            Name="Ceyhan Lisesi",
                            Default=false,
                            Classes=new List<Classes>()
                            {
                                new Classes()
                                {
                                    Brach="7-D",
                                    Lesson="Fen Bilgisi",
                                    StudentCount=23,
                                    ClassCode=4
                                },
                                new Classes()
                                {
                                    Brach="6-E",
                                    Lesson="Matematik",
                                    StudentCount=17,
                                    ClassCode=2
                                }
                            }
                        }
                    }
                }
            };

            try
            {
                
                return Ok(Teachers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }


    public class Teachers
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Branch { get; set; }
        public List<Okul> Schools { get; set; }
    }

    public class Okul
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Default { get; set; }
        public List<Classes> Classes { get; set; }
    }

    public class Classes
    {
        public string Brach { get; set; }
        public string Lesson { get; set; }
        public int StudentCount { get; set; }
        public int ClassCode { get; set; }
    }

}
