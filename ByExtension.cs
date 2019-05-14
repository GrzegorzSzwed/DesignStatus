using System.Collections.Generic;
namespace Managment_Tool
{
    public class ByExtension : Filtr
    {
        private string extension;
        public ByExtension(string extension)
        {
            this.extension = extension;
        }
        public override List<string> GetDirectories(List<string> directories)
        {
            var filtredlist = new List<string>();
            var patterns = extension.Split('|');
            foreach (var pattern in patterns)
            {
                var enumerator = directories.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var cur = enumerator.Current.ToString();
                    if (cur.Contains(pattern))
                    {
                        filtredlist.Add(cur);
                    }
                }
            }
            directories.Clear();
            directories.AddRange(filtredlist);
            filtredlist.Clear();
            return directories;
        }

        public override List<string> GetDirectories(string directory)
        {
            var filtredByName = new List<string>();
            //var enumerator = directories.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var cur = enumerator.Current;
            //    filtredTopOnly.Add(cur);
            //}
            return filtredByName;
        }
    }
}
