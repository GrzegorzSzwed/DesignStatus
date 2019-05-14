using System.Collections.Generic;
namespace Managment_Tool
{
    public abstract class Filtr
    {
        public abstract List<string> GetDirectories(List<string> directories);
        public abstract List<string> GetDirectories(string directory);
    }
}
