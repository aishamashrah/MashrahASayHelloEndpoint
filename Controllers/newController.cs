//aisha mashrah
//10-29-22
//EndPoint
// you are to turn in an entire webapi application that has endpoints

//Peer Review: Arely Martinez - The program works as intended. The Route name is formatted well making it easy for the user to understand. Overall nice job. 

using Microsoft.AspNetCore.Mvc;

namespace MashrahASayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class newController : ControllerBase
{
    // EndPoint 1 Say Hello
    [HttpGet]
    [Route("Min1/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}";
    }  
      
}
