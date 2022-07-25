using Autodesk.Revit.UI;
using Revit.Addin.SharedProject.Buttons;
using System;
using System.Linq;

namespace Revit.Addin.SharedProject
{
    public class AppCommand : IExternalApplication
    {
        string tabName = "TabName";
        string ribbonPanelName = "RibbonPanelName";

        public Result OnStartup(UIControlledApplication application)
        {
            try
            {
                application.CreateRibbonTab(tabName);
            }
            catch (Exception)
            {
                // Ignored
            }

            var ribbonPanel = application.GetRibbonPanels().FirstOrDefault(x => x.Name == ribbonPanelName)
                ?? application.CreateRibbonPanel(tabName, ribbonPanelName);

            FirstButtonCommand.CreateButton(ribbonPanel);
            SecondButtonCommand.CreateButton(ribbonPanel);

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
