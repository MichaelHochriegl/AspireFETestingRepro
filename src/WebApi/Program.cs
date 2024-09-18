using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);
builder.AddServiceDefaults();

builder.Services.AddFastEndpoints();

var app = builder.Build();

app.MapFastEndpoints();

app.Run();
