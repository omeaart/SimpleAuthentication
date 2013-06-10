﻿//
// Based upon the SignalR code: https://github.com/SignalR/SignalR/blob/master/src/Microsoft.AspNet.SignalR.Core/Tracing/ITraceManager.cs
//

using System.Diagnostics;

namespace WorldDomination.Web.Authentication.Tracing
{
    public interface ITraceManager
    {
        TraceSource this[string name] { get; }
    }
}
