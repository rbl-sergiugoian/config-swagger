using swager.Config;

var builder = WebApplication.CreateBuilder(args);

// c1
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

// c2 branch2
app.UseHttpsRedirection();

// c3 branch2
app.UseAuthorization();

// c4
app.MapControllers();

app.Run();
