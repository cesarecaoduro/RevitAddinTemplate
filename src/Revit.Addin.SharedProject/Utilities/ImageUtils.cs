using System;
using System.Linq;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace Revit.Addin.SharedProject.Utilities
{
    public static class ImageUtils
    {
        public static BitmapImage LoadImage(Assembly assembly, string name)
        {
            var img = new BitmapImage();
            try
            {
                var resourceName = assembly
                    .GetManifestResourceNames()
                    .FirstOrDefault(x => x.Contains(name));
                var stream = assembly.GetManifestResourceStream(resourceName);
                img.BeginInit();
                img.StreamSource = stream;
                img.EndInit();

            }
            catch (Exception)
            {
                // Ignored 
            }

            return img;
        }

    }
}
