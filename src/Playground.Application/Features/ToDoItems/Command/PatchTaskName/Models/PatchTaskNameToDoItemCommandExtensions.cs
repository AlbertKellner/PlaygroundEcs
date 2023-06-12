﻿namespace Playground.Application.Features.ToDoItems.Command.PatchTaskName.Models
{
    public static class PatchTaskNameToDoItemCommandExtensions
    {
        public static string ToWarning(this PatchTaskNameToDoItemCommand input)
        {
            return $@"{nameof(input.Id)}:{input.Id}|{nameof(input.Task)}:{input.Task}|{nameof(input.FormattedErrosList)}:{input.FormattedErrosList()}";
        }

        public static string ToError(this PatchTaskNameToDoItemCommand input)
        {
            return $@"{nameof(input.Id)}:{input.Id}|{nameof(input.Task)}:{input.Task}";
        }
    }
}