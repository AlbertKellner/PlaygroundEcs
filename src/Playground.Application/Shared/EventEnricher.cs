﻿using Playground.Application.Shared.AsyncLocals;
using Serilog.Context;
using Serilog.Core;
using Serilog.Events;

namespace Playground.Application.Shared
{
    public class LogEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("ExecutionTime", ExecutionTimeContext.GetFormattedExecutionTime()));
            logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("UserId", UserAuthorizationContext.GetUserId()));
        }

        internal static void PushPropertyCustomerName(string name)
        {
            LogContext.PushProperty("CustomerData.Name", name);
        }
    }
}
