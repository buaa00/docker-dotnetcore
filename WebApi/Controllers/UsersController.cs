using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var users = new List<User>();
            users.Add(new User(1, "Macke", "mackecar@gmail.com", "Centar dgra"));
            users.Add(new User(2, "Kizo", "zstevoviSCH@money.com", "NN"));
            users.Add(new User(3, "Dare", "dare@gcare.com", "Avalon"));

            return users;
        }

        [HttpGet]
        [Route("text")]
        public ActionResult<IEnumerable<string>> GetText()
        {
            var users = new List<User>();
            users.Add(new User(1, "Macke", "mackecar@gmail.com", "Centar dgra"));
            users.Add(new User(2, "Kizo", "zstevoviSCH@money.com", "NN"));
            users.Add(new User(3, "Dare", "dare@gcare.com", "Avalon"));

            var usersText = new List<string>();

            foreach (var user in users)
            {
                usersText.Add(user.ToString());
            }

            return usersText;
        }
    }
}