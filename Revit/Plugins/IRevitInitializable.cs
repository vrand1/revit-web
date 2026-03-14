using Autodesk.Revit.UI;
using WebBridge.ViewModel;

namespace Plugins;

public interface IRevitInitializable
{
    void Initialize(UIApplication app);
}