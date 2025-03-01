using BusinessLayer.Interface;
using CommonLayer;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeManagementController : ControllerBase
    {
        private readonly IEmployeeBL _employeeBusiness;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public EmployeeManagementController(IEmployeeBL employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }
        [HttpGet]
        public string Get()
        {
            return "Server running..";
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            try
            {
                _logger.Info("Received request to add employee: {Name}", employee.Name);
                _employeeBusiness.AddEmployee(employee);
                _logger.Info("Employee added successfully: {Name}", employee.Name);
                return Ok("Employee added successfully");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Internal Server Error while adding employee: {Name}", employee.Name);
                return StatusCode(500, new { message = "Internal Server Error", error = ex.Message });
            }
        }


    }
}
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <targets>
    <target name="logfile" type="File" fileName="logs/logfile.txt" />
    <target name="console" type="Console" />
  </targets>
  <rules>
    <logger name="*" minlevel="Info" writeTo="logfile" />
    <logger name="*" minlevel="Info" writeTo="console" />
  </rules>
</nlog>
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Logging.ClearProviders();
builder.Host.UseNLog();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
using Microsoft.AspNetCore.Mvc;
using NLog;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    [HttpPost("register")]
    public IActionResult RegisterUser([FromBody] User user)
    {
        try
        {
            if (user == null || string.IsNullOrEmpty(user.Username))
            {
                Logger.Warn("Invalid user data provided.");
                return BadRequest("User data is invalid.");
            }

            // Simulate user registration logic here
            Logger.Info($"User {user.Username} registered successfully.");
            return Ok($"User {user.Username} registered successfully.");
        }
        catch (Exception ex)
        {
            Logger.Error(ex, "An error occurred while registering the user.");
            return StatusCode(500, "Internal server error.");
        }
    }
}

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}
