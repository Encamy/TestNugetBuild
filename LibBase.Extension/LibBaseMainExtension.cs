using System;

namespace LibBase.Extension
{
    public static class LibBaseMainExtension
    {
        public static void TestExtension()
        {
            Console.WriteLine(nameof(LibBaseMainExtension));
            LibBase.LibBaseMain.Test();
        }
    }
}
