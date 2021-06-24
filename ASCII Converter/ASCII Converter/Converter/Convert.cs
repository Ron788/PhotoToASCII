using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ASCII_Converter.Converter
{
    public class ConvertFile
    {
        private string _path; 
        public ConvertFile(string path)
        {
            _path = path;
        }

        public void Start()
        {
            Bitmap bitmap = new Bitmap(_path);
            bitmap.ToGrayscale();

            var converter = new BitmapToASCII(bitmap);
            var rows = converter.Convert();

            File.WriteAllLines("text.txt", rows.Select(r => new string(r)));
        }
    }
}
