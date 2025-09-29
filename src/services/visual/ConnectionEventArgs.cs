using System;
using System.Collections.Generic;

namespace VLeague.Services.Visual
{
    public class ConnectionEventArgs : EventArgs
    {
        public ConnectionEventArgs(bool isConnected, string message, Dictionary<string, object> data = null)
        {
            IsConnected = isConnected;
            Message = message;
            Data = data ?? new Dictionary<string, object>();
        }

        public bool IsConnected { get; }

        public string Message { get; }

        public Dictionary<string, object> Data { get; }
    }
}
