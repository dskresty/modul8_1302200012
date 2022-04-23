using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302200012.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        public static List<string> bintang1 = new List<string>()
        {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        };

        public static List<string> bintang2 = new List<string>()
        {
            "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"
        };

        public static List<string> bintang3 = new List<string>()
        {
            "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"
        };

        public static List<Movies> movieList = new List<Movies>()
        {
            new Movies("The Shawshank Redemption", "Frank Darabont", bintang1, "Two imprisoned men bond over a number of years, finding solace and" +
                " eventual redemption through acts of common decency."),
            new Movies("The Godfather", "Francis Ford Coppola", bintang2, "The aging patriarch of an organized crime dynasty in postwar " +
                "New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movies("The Dark Knight", "Christopher Nolan", bintang3, "When the menace known as the Joker wreaks havoc and chaos on the " +
                "people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")

        };


        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return movieList;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return movieList[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movies value)
        {
            movieList.Add(value);
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movieList.RemoveAt(id);
        }


    }
}
