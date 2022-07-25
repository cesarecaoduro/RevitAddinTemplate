using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;

namespace Revit.Addin.SharedProject.Buttons
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    [Journaling(JournalingMode.NoCommandData)]
    public class FirstButtonCommand : IExternalCommand
    {
        private static string buttonText = $"First\nButton";
        private static string buttonTooltip = $"First Button Tooltip";

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                MessageBox.Show("First Button Commnad", "AECOM Tech", MessageBoxButton.OK);
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
            }
            );
        }

    }
}
