using System;
using Core.Models;

namespace Core.Contracts
{
    /// <summary>
    /// Interface of plugin model
    /// </summary>
    public interface IRevitPluginModel
    {
        public event Action<MessageToWeb> OnMessageReady;
        public IPayload Payload { get; set; }
        
        /// <summary>
        /// Execute command from web interface
        /// </summary>
        void Execute();
    }
}