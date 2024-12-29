using Leck2.Config;
using Leck2.Constants;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Ajout des services
builder.Services.AddApplicationServices(builder.Configuration);

// Configurer Serilog comme fournisseur de log
builder.ConfigureSerilog();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

// Configurer les middlewares dans le pipeline HTTP
app.ConfigureMiddlewares();


try
{
    Log.Information(ProgramSetupLogs.AppInitialisation);
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, ProgramSetupLogs.AppStartupError);
}
finally
{
    Log.CloseAndFlush();
}