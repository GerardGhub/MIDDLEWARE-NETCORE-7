var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
  await context.Response.WriteAsync("Hello");
    await next(context);
});

//Middleware 2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello 2 times");
    await next(context);
});

//http redirection/ authorization
//Middleware 3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello Again");

});

app.Run();
