var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Otelea_Irina_lab1_ApiService>("apiservice");

builder.AddProject<Projects.Otelea_Irina_lab1_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
