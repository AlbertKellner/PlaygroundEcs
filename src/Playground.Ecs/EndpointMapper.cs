﻿namespace Playground.Ecs
{
    public static partial class EndpointMapper
    {
        public static WebApplication RegisterEndpoints(this WebApplication app)
        {
            app.MapInitialEndPoints();
            app.MapRandomEndPoints();
            app.MapTodoEndPoints();

            return app;
        }

        public static WebApplication MapInitialEndPoints(this WebApplication app)
        {
            //app.MapGet("/initial/{topic?}", (string? topic, IInitialRespositoryAPI initialRespositoryAPI) => {
            //    return initialRespositoryAPI.SearchInitial(topic);
            //});
            /// more registertaions

            return app;
        }

        public static WebApplication MapRandomEndPoints(this WebApplication app)
        {
            //app.MapPut("/initial", (IRandomRespositoryAPI randomRespositoryAPI) =>
            //{
            //    return initialRespositoryAPI.Random();
            //});
            /// more registertaions

            return app;
        }

        public static WebApplication MapTodoEndPoints(this WebApplication app)
        {
            //app.MapGet("/todoitems", async (TodoDb db) =>
            //    await db.Todos.ToListAsync());

            //app.MapGet("/todoitems/complete", async (TodoDb db) =>
            //    await db.Todos.Where(t => t.IsComplete).ToListAsync());

            //app.MapGet("/todoitems/{id}", async (int id, TodoDb db) =>
            //    await db.Todos.FindAsync(id)
            //        is Todo todo
            //            ? Results.Ok(todo)
            //            : Results.NotFound());

            //app.MapPost("/todoitems", async (Todo todo, TodoDb db) =>
            //{
            //    db.Todos.Add(todo);
            //    await db.SaveChangesAsync();

            //    return Results.Created($"/todoitems/{todo.Id}", todo);
            //});

            //app.MapPut("/todoitems/{id}", async (int id, Todo inputTodo, TodoDb db) =>
            //{
            //    var todo = await db.Todos.FindAsync(id);

            //    if (todo is null) return Results.NotFound();

            //    todo.Name = inputTodo.Name;
            //    todo.IsComplete = inputTodo.IsComplete;

            //    await db.SaveChangesAsync();

            //    return Results.NoContent();
            //});

            //app.MapDelete("/todoitems/{id}", async (int id, TodoDb db) =>
            //{
            //    if (await db.Todos.FindAsync(id) is Todo todo)
            //    {
            //        db.Todos.Remove(todo);
            //        await db.SaveChangesAsync();
            //        return Results.Ok(todo);
            //    }

            //    return Results.NotFound();
            //});

            return app;
        }
    }
}
