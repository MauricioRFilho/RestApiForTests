var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RestApiForTests_Server>("restapifortests-server");

builder.Build().Run();
