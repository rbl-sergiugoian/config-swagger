using swager.Config;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiDocumentation();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// swagger docs
app.UseApiDocumentation();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
