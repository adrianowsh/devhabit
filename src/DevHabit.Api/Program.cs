using DevHabit.Api;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddObservability();

builder.Services.AddControllers();

builder.Services.AddOpenApi();


WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

await app.RunAsync();
