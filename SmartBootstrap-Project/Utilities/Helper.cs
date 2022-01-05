using System.IO;

namespace SmartBootstrap_Project.Utilities
{
    public static class Helper
    {
        public static void FileRemove(string root,string folder,string image)
        {
            string path = Path.Combine(root, folder, image);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
