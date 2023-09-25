
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UniversidadContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


// Personas

app.MapPost("/personas", async (Persona persona, UniversidadContext context) =>
{
    context.Personas.Add(persona);
    await context.SaveChangesAsync();

    return Results.Created($"/personas/{persona.Id}", persona);
});


app.MapGet("/personas", async (UniversidadContext context) =>
{
    var alu = await context.Personas.ToListAsync();

    return Results.Ok(alu);


});


app.MapGet("/personas/{id}", async (int id, UniversidadContext context) =>
    await context.Personas.FindAsync(id) is Persona persona
        ? Results.Ok(persona)
        : Results.NotFound());

app.MapPut("/personas/{id}", async (int id, Persona p, UniversidadContext context) =>
{
    var persona = await context.Personas.FindAsync(id);

    if (persona is null) return Results.NotFound();

    persona.Nombre = p.Nombre;
    persona.Apellido = p.Apellido;
    persona.Direccion = p.Direccion;
    persona.Legajo = p.Legajo;
    persona.Email = p.Email;
    persona.FechaNacimiento = p.FechaNacimiento;
    persona.IdPlan = p.IdPlan;

    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/personas/{id}", async (int id, UniversidadContext context) =>
{
    if (await context.Personas.FindAsync(id) is Persona p)
    {
        context.Remove(p);
        await context.SaveChangesAsync();
        return Results.Ok(p);
    }
    else
    {
        return Results.NotFound();
    }
});




// Especialidad

app.MapPost("/especialidades", async (Especialidad e, UniversidadContext context) =>
{
    context.Especialidades.Add(e);
    await context.SaveChangesAsync();

    return Results.Created($"/especialidades/{e.Id}", e);
});

app.MapGet("/especialidades", async (UniversidadContext context) =>
{
    var esp = await context.Especialidades.ToListAsync();

    return Results.Ok(esp);


});

app.MapGet("/especialidades/{id}", async (int id, UniversidadContext context) =>
    await context.Especialidades.FindAsync(id) is Especialidad e
        ? Results.Ok(e)
        : Results.NotFound());

app.MapPut("/especialidades/{id}", async (int id, Especialidad p, UniversidadContext context) =>
{
    var e = await context.Especialidades.FindAsync(id);

    if (e is null) return Results.NotFound();

    e.Descripcion = p.Descripcion;

    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/especialidades/{id}", async (int id, UniversidadContext context) =>
{
    if (await context.Especialidades.FindAsync(id) is Especialidad e)
    {
        context.Remove(e);
        await context.SaveChangesAsync();
        return Results.Ok(e);
    }
    else
    {
        return Results.NotFound();
    }
});



// Plan

app.MapPost("/planes", async (Plan p, UniversidadContext context) =>
{
    context.Planes.Add(p);
    await context.SaveChangesAsync();

    return Results.Created($"/planes/{p.Id}", p);
});

app.MapGet("/planes", async (UniversidadContext context) =>
{
    var planes = await context.Planes.ToListAsync();

    return Results.Ok(planes);
});

app.MapGet("/planes/{id}", async (int id, UniversidadContext context) =>
    await context.Planes.FindAsync(id) is Plan p
        ? Results.Ok(p)
        : Results.NotFound());

app.MapPut("/planes/{id}", async (int id, Plan p, UniversidadContext context) =>
{
    var pl = await context.Planes.FindAsync(id);

    if (pl is null) return Results.NotFound();

    pl.Descripcion = p.Descripcion;
    pl.IdEspecialidad = p.IdEspecialidad;

    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/planes/{id}", async (int id, UniversidadContext context) =>
{
    if (await context.Planes.FindAsync(id) is Plan p)
    {
        context.Remove(p);
        await context.SaveChangesAsync();
        return Results.Ok(p);
    }
    else
    {
        return Results.NotFound();
    }
});





app.Run();
