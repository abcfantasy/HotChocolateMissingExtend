var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddGraphQLServer()
       .AddApolloFederation()
       .AddQueryType()
       .AddType<Customer>();

var app = builder.Build();

app.MapGraphQL();

app.Run();

[ExtendServiceType]
public class Customer
{
    [Key]
    [External]
    public string Id { get; set; }

    public string CustomField { get; set; }
}