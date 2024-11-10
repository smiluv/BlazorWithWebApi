var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorAppWeb>("blazorappweb");

builder.Build().Run();
