
using Data;
using Dtos;
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

app.MapPost("/personas", async (Persona persona, UniversidadContext context) => {

    context.Attach(persona.Plan);
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
    persona.Telefono = p.Telefono;
    persona.FechaNacimiento = p.FechaNacimiento;
    persona.Plan = p.Plan;

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

app.MapPost("/planes", async (Plan p, UniversidadContext context) => {
    context.Attach(p.Especialidad);
    context.Planes.Add(p);
    await context.SaveChangesAsync();

    return Results.Created($"/planes/{p.Id}", p);
});

app.MapGet("/planes", async (UniversidadContext context) => {

    var planes = await context.Planes
    .Select(p => new PlanDto()
    {
        Id = p.Id,
        Descripcion = p.Descripcion,
        DescripcionEspecialidad = p.Especialidad.Descripcion
    })
    .ToListAsync();

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
    
    /*context.Entry(pl)
       .Reference(p => p.Especialidad)
       .Load();*/

    //var esp = await context.Especialidades.FindAsync(p.Especialidad.Id);
    context.Attach(p.Especialidad);
    pl.Especialidad = p.Especialidad;
    

    pl.Descripcion = p.Descripcion;

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

// Materia


app.MapPost("/materias", async (Materia m, UniversidadContext context) =>
{
    context.Attach(m.Plan);
    context.Materias.Add(m);
    await context.SaveChangesAsync();

    return Results.Ok(m);
});


app.MapGet("/materias", async( UniversidadContext context) =>

{
    var materias = await context.Materias
    .Select(ma => new MateriaDto()
    {
        Id = ma.Id,
        Descripcion = ma.Descripcion,
        HsSemanales = ma.HsSemanales,
        HsTotales  = ma.HsTotales,
        DescripcionPlan = ma.Plan.Descripcion
    })
    .ToListAsync();

    return Results.Ok(materias);

});

app.MapGet("/materias/{id}", async (int id, UniversidadContext context) =>
    await context.Materias.FindAsync(id) is Materia m
        ? Results.Ok(m)
        : Results.NotFound());

app.MapPut("/materias/{id}", async(Materia m, int id, UniversidadContext context) => 
{
    var mat = await context.Materias.FindAsync(id);

    if (mat is null) return Results.NotFound();

    context.Attach(m.Plan);
    mat.Plan = m.Plan;
    mat.Descripcion = m.Descripcion;
    mat.HsSemanales = m.HsSemanales;
    mat.HsTotales = m.HsTotales;

    await context.SaveChangesAsync();
    return Results.NoContent();

});

app.MapDelete("/materias/{id}", async (int id, UniversidadContext context) =>
{
    if (await context.Materias.FindAsync(id) is Materia m)
    {
        context.Remove(m);
        await context.SaveChangesAsync();
        return Results.Ok(m);
    }
    else
    {
        return Results.NotFound();
    }
});

// Comision

app.MapPost("/comisiones", async(Comision c, UniversidadContext context) =>
{
    context.Attach(c.Plan);
    context.Add(c);
    await context.SaveChangesAsync();

    return Results.Ok(c);
});

app.MapGet("/comisiones", async (UniversidadContext context) =>
{
    var comisiones = await context.Comisiones
        .Select(c => new ComisionDto()
        {
            Id = c.Id,
            Descripcion = c.Descripcion,
            Anio = c.Anio,
            DescripcionPlan = c.Plan.Descripcion
        })
        .ToListAsync(); ;

    return Results.Ok(comisiones);



});

app.MapPut("/comisiones/{id}", async(Comision c, int id, UniversidadContext context) =>
{
    var com = await context.Comisiones.FindAsync(id);

    if (com is null) return Results.NotFound();

    context.Attach(c.Plan);
    com.Descripcion = c.Descripcion;
    com.Anio = c.Anio;
    com.Plan = c.Plan;

    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/comisiones/{id}", async (int id, UniversidadContext context) =>
{
    if (await context.Comisiones.FindAsync(id) is Comision c)
    {
        context.Remove(c);
        await context.SaveChangesAsync();
        return Results.Ok(c);
    }
    else
    {
        return Results.NotFound();
    }
});


app.Run();
