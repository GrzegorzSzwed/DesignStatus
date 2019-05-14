using System.Collections.Generic;
namespace Managment_Tool
{
    public class ByName : Filtr
    {
        public ByName(string name)
        {
            this.name = name;
        }
        private string name;
        public override List<string> GetDirectories(List<string> directories)
        {
            var filtredlist = new List<string>();
            var enumerator = directories.GetEnumerator();
            while(enumerator.MoveNext())
            {
                var cur = enumerator.Current.ToString();
                if(cur.Contains(this.name))
                {
                    filtredlist.Add(cur);
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
