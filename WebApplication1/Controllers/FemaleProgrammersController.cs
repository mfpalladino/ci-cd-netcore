using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FemaleProgrammersController : ControllerBase
    {
        // GET api/femaleprogrammers
        [HttpGet]
        public ActionResult<IEnumerable<Programmer>> Get()
        {
            return new List<Programmer>
            {
                new Programmer
                {
                    Name="Grace Hopper", 
                    Description = "Grace Murray Hopper (Dec 9, 1906 – Jan 1, 1992) was one of the first programmers of the Harvard Mark I computer. She invented the first compiler for a computer programming language and the one of those who popularized the idea of machine-independent programming languages. Her ideas influenced the development of COBOL, one of the first high-level programming languages.  She introduced the term “debugging” for fixing computer glitches and programming errors. She is also remembered as “Amazing Grace”.",
                    Image = "https://www.technotification.com/wp-content/uploads/2018/05/univac-hagley-grace.jpg"
                },
                new Programmer
                {
                    Name="Ada Lovelace",
                    Description = "Ada Byron, also known as Lady Lovelace (10 Dec 1815 – 27 Nov 1852) was a writer and gifted mathematician. She was the first woman to devise an algorithm that could be processed a by a machine or the computer. Suffice to say based on her notes the algorithm she invented would have been accurately processed on the first general machine computer. She is thus considered the world’s first computer programmer.",
                    Image = "https://www.technotification.com/wp-content/uploads/2018/05/Ada_Lovelace_portrait.jpg"
                }
            };

        }
    }

    public class Programmer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

}
