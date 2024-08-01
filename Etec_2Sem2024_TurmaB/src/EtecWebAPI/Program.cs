using EtecWebAPI.Domain;
using EtecWebAPI.Enumerators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapGet("/curso/listar", () =>
{
    var curso01 = new Curso
    {
        Id = 1,
        Nome = "Desenvolvimento de Sistema",
        Periodo = EnumPeriodo.Manha
    };

    var curso02 = new Curso
    {
        Id = 2,
        Nome = "Administração",
        Periodo = EnumPeriodo.Tarde
    };

    var curso03 = new Curso
    {
        Id = 3,
        Nome = "Mecânica",
        Periodo = EnumPeriodo.Noite
    };

    var curso04 = new Curso();
    curso04.Id = 4;
    curso04.Nome = "Enfermagem";
    curso04.Periodo = EnumPeriodo.Tarde;

    var cursos = new List<Curso>();
    cursos.Add(curso01);
    cursos.Add(curso02);
    cursos.Add(curso03);
    cursos.Add(curso04);

    return Results.Ok(cursos.OrderBy(c => c.Nome));
})
.WithOpenApi();

app.Run();