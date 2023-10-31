
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
{
    var persona = await context.Personas
           .Where(p => p.Id == id)
           .Select(p => new
           {
               Id = p.Id,
               Plan = new Plan() { Id = p.Plan.Id },
               Nombre = p.Nombre,
               Apellido = p.Apellido,
               Email = p.Email,
               Direccion = p.Direccion,
               Legajo = p.Legajo,
               Telefono = p.Telefono,
               FechaNacimiento = p.FechaNacimiento,
           })
           .FirstOrDefaultAsync();

    return Results.Ok(persona);
});

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
    {
        var plan = await context.Planes
           .Where(p => p.Id == id)
           .Select(p => new
           {
               Id = p.Id,
               Especialidad = new Especialidad() { Id = p.Especialidad.Id },
               Descripcion = p.Descripcion
           })
           .FirstOrDefaultAsync();

        return Results.Ok(plan);

    });

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
{
    var materia = await context.Materias
           .Where(m => m.Id == id)
           .Select(m => new
           {
               Id = m.Id,
               Plan = new Plan() { Id = m.Plan.Id },
               Descripcion = m.Descripcion,
               HsSemanales = m.HsSemanales,
               HsTotales = m.HsTotales
           })
           .FirstOrDefaultAsync();

    return Results.Ok(materia);

});

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

app.MapGet("/comisiones/{id}", async (int id, UniversidadContext context) =>
{
    var comision = await context.Comisiones
           .Where(c => c.Id == id)
           .Select(c => new
           {
               Id = c.Id,
               Plan = new Plan() { Id = c.Plan.Id },
               Descripcion = c.Descripcion,
               Anio = c.Anio,

               
           })
           .FirstOrDefaultAsync();

    return Results.Ok(comision);
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
        context.Comisiones.Remove(c);
        await context.SaveChangesAsync();
        return Results.Ok(c);
    }
    else
    {
        return Results.NotFound();
    }
});


// Curso

app.MapPost("cursos", async(Curso c, UniversidadContext context) =>
{
    context.Attach(c.Materia);
    context.Attach(c.Comision);
    context.Cursos.Add(c);
    await context.SaveChangesAsync();

    return Results.Ok(c);
});

app.MapGet("/cursos", async (UniversidadContext context) =>
{
    var cursos = await context.Cursos
        .Select(c => new CursoDto()
        {
            Id = c.Id,
            DescripcionMateria = c.Materia.Descripcion,
            Año = c.Anio,
            DescripcionComision = c.Comision.Descripcion,
            Cupo = c.Cupo
        })
        .ToListAsync(); ;

    return Results.Ok(cursos);
});

app.MapGet("/cursos/{id}", async (int id, UniversidadContext context) =>
    {
        var curso = await context.Cursos
        .Where(c => c.Id == id)
        .Select(c => new
        {
            Id = c.Id,
            Materia = new Materia (){
                Id = c.Materia.Id
            },
            Anio = c.Anio,
            Comision = new Comision()
            {
                Id = c.Comision.Id
            },
            Cupo = c.Cupo
        })
        .FirstOrDefaultAsync();

        return Results.Ok(curso);

    });


app.MapPut("/cursos/{id}", async (Curso c, int id, UniversidadContext context) =>
{
    var curso = await context.Cursos.FindAsync(id);

    if (curso is null) return Results.NotFound();

    context.Attach(c.Materia);
    context.Attach(c.Comision);
    curso.Cupo = c.Cupo;
    curso.Anio = c.Anio;
    curso.Materia = c.Materia;
    curso.Comision = c.Comision;

    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/cursos/{id}", async (int id, UniversidadContext context) =>
{
    if (await context.Cursos.FindAsync(id) is Curso c)
    {
        context.Cursos.Remove(c);
        await context.SaveChangesAsync();
        return Results.Ok(c);
    }
    else
    {
        return Results.NotFound();
    }
});




app.Run();
