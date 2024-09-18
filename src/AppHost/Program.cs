using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<WebApi>("api");

builder.Build().Run();