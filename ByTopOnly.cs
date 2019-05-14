using System.IO;
using System.Collections.Generic;

namespace Managment_Tool
{
    public class MainFiltr : Filtr
    {
        //input bool
        private bool toponly;

        //number of layer to sort, possible to change
        private int depthOfDirectoriesToSort = 3;

        public MainFiltr(bool ifTopOnly)
        {
            toponly = ifTopOnly; //sorted in third layer, declared in depthOfDirectoriesToSort
        }
        
        public override List<string> GetDirectories(string directory)
        {
            var OnlyTopDirectories = new List<string>();
            RcvGetDirectories(OnlyTopDirectories, directory, 0);
            return OnlyTopDirectories;
        }

        private void RcvGetDirectories(List<string> filtredDirectories, string directory, int depth)
        {
            if (depth < depthOfDirectoriesToSort)
            {
                var directories = Directory.EnumerateDirectories(directory, "*", SearchOption.TopDirectoryOnly);
                var enumerator = directories.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var cur = enumerator.Current;
                    RcvGetDirectories(filtredDirectories, cur, ++depth);
                    depth--;
                }
            }
            else
            {
                var directories = Directory.EnumerateDirectories(directory, "*.*", SearchOption.TopDirectoryOnly); //get directories from chosen lvl
                var listToSort = new List<string>(directories);
                if (listToSort.Count != 0)
                {
                    if (toponly)
                    {
                        listToSort.Sort();
                        var topDirectory = listToSort[listToSort.Count - 1];
                        //add only one directory
                        filtredDirectories.Add(topDirectory);
                    }
                    else
                    {
                        filtredDirectories.AddRange(listToSort);
                    }
                }
            }
        }

        public override List<string> GetDirectories(List<string> directories)
        {
            var filtredTopOnly = new List<string>();
            //var enumerator = directories.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var cur = enumerator.Current;
            //    filtredTopOnly.Add(cur);
            //}
            return filtredTopOnly;
        }
    }
}
