using System.Collections.Generic;
using System.Drawing;

namespace GBLib.Architecture.Implementations.Graphics
{
    public class GBColors
    {
        public static List<GBColor> DefinedColors;

        public static void Initialize()
        {
            DefinedColors = new List<GBColor>();
            AddColor(0, "White", Color.White, new byte[] { 0, 1 });
            AddColor(1, "Light Grey", Color.LightGray, new byte[] { 2, 3 });
            AddColor(2, "Dark Grey", Color.DarkGray, new byte[] { 4, 5 });
            AddColor(3, "Black", Color.Black, new byte[] { 6, 7 });
        }

        private static void AddColor(int id, string name=null, Color color, byte[] byteIds)
        {
            DefinedColors.Add(new GBColor
            {
                Id = id,
                Name = name,
                SystemColor = color,
                ByteIds = byteIds
            });
        }
    }
}
