using hello_world_api;

var builder = WebApplication.CreateBuilder(args);

// Call Startup methods
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();
startup.Configure(app, app.Environment);

app.Run();
