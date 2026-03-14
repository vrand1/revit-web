using System;
using Autodesk.Revit.UI;
using Core.Contracts;
using Core.Models;
using WebBridge.ViewModel;

namespace Plugins.Panel.MainPlugin
{
    public class Model : IRevitPluginModel, IRevitInitializable
    {
        public event Action<MessageToWeb> OnMessageReady;
        private UIApplication _uiApp;
        private ExternalEvent _externalEvent;
        
        public IPayload Payload { get; set; }

        public void Initialize(UIApplication uiApp)
        {
            Payload = new BasePayload();
            _uiApp = uiApp;
            _externalEvent = ExternalEvent.Create(new Handler());
        }


        public void Execute()
        {
            _externalEvent?.Raise();

            var msg = new MessageToWeb("Плагин выполнен", "Проблем не было 💩");
            OnMessageReady?.Invoke(msg);
        }
    }
}