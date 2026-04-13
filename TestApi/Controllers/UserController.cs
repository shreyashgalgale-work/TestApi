using Microsoft.AspNetCore.Mvc;


namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] users = new[]
        {
            {
                name: "Shreyas",
                age: 25,
                gender: "Male"
            },
            {
                name: "Rahul",
                age: 33,
                gender: "Male"
            },
            {
                name: "Rahul",
                age: 33,
                gender: "Female"
            },
            {
                name: "Vijay",
                age: 24,
                gender: "Male"
            }
        };
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetUser")]
        public string Get()
        {
            return users[new Random().Next(users.Length)];
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<string> GetUsers()
        {
            return users.Select(u => u.name);
        }

    }
}
