﻿using Playground.Application.Features.Pokemon.GetByName.Models;

namespace Playground.Application.Shared.Domain.ApiDto
{
    public static class PokemonOutApiDtoExtensions
    {
        public static string ToTroubleshooting(this PokemonOutApiDto input)
        {
            return $@"{nameof(input.Name)}:{input.Name}";
        }
    }
}
