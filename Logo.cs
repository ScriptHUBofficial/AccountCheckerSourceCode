using System;
using System.Drawing;

namespace Checker_Source_Code
{
    class Logo
    {
        //Birinci bölüm renkleri
        static Color _color1 = Color.FromArgb(91, 35, 113);

        //ikinci bölüm renkleri
        static Color _color2 = Color.FromArgb(53, 26, 117);

        //üçüncü bölüm renkleri
        static Color _color3 = Color.FromArgb(70, 50, 143);


        public static void _Show()
        {
            Console.Clear();
            string line = "\t";
            Console.Write("\n\n");
            Colorful.Console.Write(line + @" ██╗", _color1); Colorful.Console.Write(@"██████╗ ", _color2); Colorful.Console.Write(@"   ██████╗██╗  ██╗███████╗ ██████╗██╗  ██╗███████╗██████╗ " + "\n", _color3);
            Colorful.Console.Write(line + @"███║", _color1); Colorful.Console.Write(@"╚════██╗", _color2); Colorful.Console.Write(@"  ██╔════╝██║  ██║██╔════╝██╔════╝██║ ██╔╝██╔════╝██╔══██╗" + "\n", _color3);
            Colorful.Console.Write(line + @"╚██║", _color1); Colorful.Console.Write(@" █████╔╝", _color2); Colorful.Console.Write(@"  ██║     ███████║█████╗  ██║     █████╔╝ █████╗  ██████╔╝" + "\n", _color3);
            Colorful.Console.Write(line + @" ██║", _color1); Colorful.Console.Write(@"██╔═══╝ ", _color2); Colorful.Console.Write(@"  ██║     ██╔══██║██╔══╝  ██║     ██╔═██╗ ██╔══╝  ██╔══██╗" + "\n", _color3);
            Colorful.Console.Write(line + @" ██║", _color1); Colorful.Console.Write(@"███████╗", _color2); Colorful.Console.Write(@"  ╚██████╗██║  ██║███████╗╚██████╗██║  ██╗███████╗██║  ██║" + "\n", _color3);
            Colorful.Console.Write(line + @" ╚═╝", _color1); Colorful.Console.Write(@"╚══════╝", _color2); Colorful.Console.Write(@"   ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝" + "\n", _color3);

        }
    }
}
