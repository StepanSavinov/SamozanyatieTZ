using RGDialogsClientsService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IRGDialogsClientsService, RGDialogsClients>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/get-dialog-by-clients-ids", GetDialog)
    .Accepts<List<Guid>>("application/json")
    .Produces<Guid>()
    .WithName("GetDialogByClientsIds");

IResult GetDialog(List<Guid> clientsIds, IRGDialogsClientsService service)
{
    var dialog = service.GetDialog(clientsIds);
    return dialog != Guid.Empty ? Results.Ok(dialog) : Results.NotFound(dialog);
}

app.Run();