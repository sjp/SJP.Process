﻿using System;

namespace SJP.ProcessRedux
{
    /// <summary>
    /// Defines properties, methods and events that are common to processes on all platforms, and assumes that output is textual.
    /// </summary>
    public interface IObservableTextStreamingProcess : IProcessAsync
    {
        /// <summary>
        /// Provides a subscriptions to events when a process writes a line to its redirected standard error stream.
        /// </summary>
        IObservable<string> ErrorLines { get; }

        /// <summary>
        /// Provides a subscriptions to events when a process writes a line to its redirected standard output stream.
        /// </summary>
        IObservable<string> OutputLines { get; }
    }
}
