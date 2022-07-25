using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Revit.Addin.SharedProject.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Revit.Addin.SharedProject.Buttons
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    [Journaling(JournalingMode.NoCommandData)]
    public class SecondButtonCommand : IExternalCommand
    {
        private static string buttonName = "SecondButton";
        private static string buttonText = $"Second\nButton";
        private static string buttonTooltip = $"Second Button Tooltip";

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                var uiApp = commandData.Application;
                var m = new SecondButtonModel(uiApp);
                return Result.Succeeded;
            }
            catch (Exception)
            {

                return Result.Failed;
            }
        }

        internal static void CreateButton(RibbonPanel ribbonPanel)
        {
            var assembly = Assembly.GetExecutingAssembly();
            ribbonPanel.AddItem(new PushButtonData(
                MethodBase.GetCurrentMethod().DeclaringType?.Name,
                buttonText,
                assembly.Location,
                MethodBase.GetCurrentMethod().DeclaringType?.FullName
                )
            {
                ToolTip = buttonTooltip,
                LargeImage = ImageUtils.LoadImage(assembly, $"_32x32.{buttonName}.png")
            }
            );
        }

    }
}
