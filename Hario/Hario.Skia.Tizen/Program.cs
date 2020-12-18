using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Hario.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Hario.App(), args);
            host.Run();
        }
    }
}
