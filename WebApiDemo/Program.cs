var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//Routing after Request Comes
app.MapGet("/", (Func<string>)(() => "Hello World!"));
app.MapGet("/Shirts", () =>
{
    return "Reading All Shirts";
});
app.MapGet("/Shirts/{id}", (int id) =>
{
    return $"Reading Shirt with id {id}";
});
app.MapPost("/Shirts", () =>
{
    return "Creating Shirt";
});
app.MapPut("/Shirts/{id}", (int id) =>
{
    return $"Updating Shirt with id {id}";
});
app.MapDelete("/Shirts/{id}", (int id) =>
{
    return $"Deleting Shirt with id {id}";
});

app.Run();


