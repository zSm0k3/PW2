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
    Curso curso01 = new Curso
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
.Produces(200)
.Produces<List<Curso>>()
.WithOpenApi(info =>
{
    info.Description = "Endpoint é utilizado para listar todos os cursos";
    info.Summary = "Listagem de cursos";
    return info;   
})
.WithTags("Cursos");

app.MapPost("/curso/adicionar", (Curso curso) =>
{
    return Results.Created("created", "Curso Criado com sucesso");
})
.WithOpenApi(info =>
{
    info.Description = "Endpoint é utilizado para cadastrar um cursos";
    info.Summary = "Cadastra Curso";
    return info;
})
.WithTags("Cursos");

app.Run();