using Microsoft.AspNetCore.Mvc;


namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
        }

        private static readonly User[] users = new[]
        {
            new User { Name = "Shreyas", Age = 25, Gender = "Male" },
            new User { Name = "Rahul", Age = 33, Gender = "Male" },
            new User { Name = "Rahul", Age = 33, Gender = "Female" },
            new User { Name = "Vijay", Age = 24, Gender = "Male" }
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public User Get()
        {
            return users[new Random().Next(users.Length)];
        }

        [HttpGet("all", Name = "GetUsers")]
        public IEnumerable<string> GetUsers()
        {
            return users.Select(u => u.Name);
        }
    }
}
