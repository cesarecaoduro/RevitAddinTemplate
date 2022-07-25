using System;
using System.Collections.Generic;
using System.Text;

namespace Revit.Addin.SharedProject.Buttons
{
    public class SecondButtonViewModel
    {
        public SecondButtonModel Model { get; set; }

        public SecondButtonViewModel(SecondButtonModel model)
        {
            Model = model;
        }
    }
}
