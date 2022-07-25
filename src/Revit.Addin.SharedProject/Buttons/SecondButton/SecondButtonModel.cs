using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Revit.Addin.SharedProject.Buttons
{
    public class SecondButtonModel
    {
        public UIApplication UIApp { get; }
        public Document Doc { get; }

        public SecondButtonModel(UIApplication uiApp)
        {
            UIApp = uiApp;
            Doc = uiApp.ActiveUIDocument.Document;
        }
    }
}
