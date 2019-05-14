using System;
using System.Data;
using System.Collections.Generic;
using System.IO;
namespace Managment_Tool
{

    public class folderBrowser
    {
        //states for folders
        private bool readyToCheckInSim;
        private bool inSim;//uwzglednij komentarz
        private bool designChecked;
        private bool waitingForDesign;
        private bool frd;
        private bool readComment;

        //extensions
        private string pptExtension = "*.ppt|*.pptx";
        private string outlookExtension = "*.eml|*.msg";
        private string designExtension = "*.jt";

        public string extension { get; set; }
        public bool onlyLast { get; set; }
        public bool HideFrd { get; set; }
        public string name { get; set; }

        private string designName = string.Empty;
        public string directory { get; set; }
        public DataTable LoadDGV()
        {
            var table = new DataTable();
        
            LoadColumns(table);
            LoadRows(table);

            return table;
        }
        private void LoadRows(DataTable table)
        {
            var riddle = new List<Filtr>();
            if(this.name!=string.Empty)
                riddle.Add(new ByName(this.name));
            //riddle.Add(new ByExtension(this.extension));

            //main riddle
            var riddleByLast = new MainFiltr(onlyLast);
            var filtredDirectories = new List<string>(riddleByLast.GetDirectories(this.directory)); //contains filtred directories
            //additional roddles
            var enumerator = riddle.GetEnumerator();
            var instantFiltr = new List<string>();
            while(enumerator.MoveNext())
            {
                var cur = enumerator.Current;
                instantFiltr.AddRange(cur.GetDirectories(filtredDirectories));
                filtredDirectories.Clear();
                filtredDirectories.AddRange(instantFiltr);
                instantFiltr.Clear();
            }
            if(filtredDirectories.Count!=0)
            {
                foreach (var dir in filtredDirectories)
                {
                    AddNewRow(table, dir);
                }
            }
            filtredDirectories.Clear();
        }

        private void AddNewRow(DataTable table,string subDirectory)
        {
            var state = GetState(subDirectory);
            var comment = "no comment";
            if (state != "free for detailing")
                comment = GetComment(subDirectory);
            if(!(HideFrd&state=="free for detailing"))
            {
                var cutDirectory = subDirectory.Remove(0, this.directory.Length + 1);
                var splittedDirectory = cutDirectory.Split('\\');
                DataRow dataRow = table.NewRow();
                dataRow["Line"] = splittedDirectory[0];
                dataRow["Station"] = splittedDirectory[1];
                dataRow["Fixture"] = splittedDirectory[2];
                dataRow["Version"] = splittedDirectory[3];
                dataRow["Name"] = GetDesignName();
                dataRow["State"] = state;
                dataRow["Comment"] = comment;
                table.Rows.Add(dataRow);
            }
        }

        private string GetComment(string subDirectory)
        {
            var filtredDirectories = new List<string>();
            filtredDirectories.AddRange(Directory.EnumerateFiles(subDirectory, "*.txt", SearchOption.TopDirectoryOnly));
            var enumerator = filtredDirectories.GetEnumerator();
            if(filtredDirectories.Count!=0)
            {
                while (enumerator.MoveNext())
                {
                    var cur = enumerator.Current;
                    var pathName = Path.GetFileNameWithoutExtension(cur);
                    if (pathName != "frd")
                        return pathName;
                }
            }
            return "no comment";
        }

        private void LoadColumns(DataTable table)
        {
            AddColumn(table, typeof(string), "Line");
            AddColumn(table, typeof(string), "Station");
            AddColumn(table, typeof(string), "Fixture");
            AddColumn(table, typeof(string), "Version");
            AddColumn(table, typeof(string), "Name");
            AddColumn(table, typeof(string), "State");
            AddColumn(table, typeof(string), "Comment");
        }

        private void AddColumn(DataTable table, Type type, string v)
        {
            var column = new DataColumn(v, type);
            table.Columns.Add(column);
        }

        //maitanace of the states

        public string GetState(string directory)
        {
            readyToCheckInSim = ifReadyToCheck(directory);
            inSim = ifInSim(directory);
            designChecked = ifDesignChecked(directory);
            waitingForDesign = ifWaitingForDesign(directory);
            frd = ifFrd(directory);
            readComment = ifCommentExist(directory);


            if (frd)
                return "free for detailing";
            if (designChecked)
                return "loop checked";
            if (inSim)
                return "in SIM work";
            if (readyToCheckInSim)
                return "ready to check in SIM";
            if (waitingForDesign)
                return "waiting for new DESIGN";

            return "not predicted case, tell GGosh Sweat";
        }

        private bool ifCommentExist(string directory)
        {
            var filtredDirectories = new List<string>();
            filtredDirectories.AddRange(Directory.EnumerateFiles(directory, "*.txt", SearchOption.TopDirectoryOnly));
            if(filtredDirectories.Count!=0)
            {
                var enumerator = filtredDirectories.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var cur = enumerator.Current;
                    if (Path.GetFileNameWithoutExtension(cur) != "frd")
                        return true;
                }
                return false;
            }
            return false;
        }

        private bool ifWaitingForDesign(string directory)
        {
            var filtredDirectories = new List<string>();
            filtredDirectories.AddRange(Directory.EnumerateFiles(directory, "*", SearchOption.TopDirectoryOnly));
            var amount = filtredDirectories.Count;
            if (amount == 0)
                return true;
            else
            {
                var txtDirectories = new List<string>();
                txtDirectories.AddRange(Directory.EnumerateFiles(directory, "*.txt", SearchOption.TopDirectoryOnly));
                if(txtDirectories.Count!=0)
                {
                    var enumerator = txtDirectories.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        var cur = enumerator.Current;
                        if (Path.GetFileNameWithoutExtension(cur) != "frd")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
             
        private bool ifReadyToCheck(string topDirectory)
        {
            var filtredDirectories = new List<string>();
            filtredDirectories.AddRange(Directory.EnumerateDirectories(topDirectory,"*",SearchOption.TopDirectoryOnly));
            if(filtredDirectories.Count!=0)
            {
                var enumerator = filtredDirectories.GetEnumerator();
                while(enumerator.MoveNext())
                {
                    var cur = enumerator.Current;
                    var splittedDirectory = cur.Split('\\');
                    var name = splittedDirectory[splittedDirectory.Length - 1];
                    if (name!="old")
                    {
                        designName = name;
                        return true;
                    }
                    else
                    {
                        return GetNameOfDesign(topDirectory);
                    }
                }
            }
            else
            {
                return GetNameOfDesign(topDirectory);
            }
            return false;

        }

        private bool GetNameOfDesign(string directory)
        {
            var filtredFiles = new List<string>();
            var patterns = designExtension.Split('|');
            foreach (var ext in patterns)
            {
                filtredFiles.AddRange(Directory.EnumerateFiles(directory, ext, SearchOption.TopDirectoryOnly));
            }
            if (filtredFiles.Count != 0)
            {
                designName = Path.GetFileNameWithoutExtension(filtredFiles[0].ToString());
                return true;
            }
            else
                return false;
        }

        private bool ifDesignChecked(string topDirectory)
        {
            var filtredDirectories = new List<string>();
            var patterns = outlookExtension.Split('|');
            foreach (var ext in patterns)
            {
                filtredDirectories.AddRange(Directory.EnumerateFiles(topDirectory, ext, SearchOption.TopDirectoryOnly));
            }
            if (filtredDirectories.Count != 0)
                return true;
            else
                return false;
        }

        private bool ifFrd(string topDirectory)
        {
            var filtredDirectories = new List<string>(Directory.EnumerateFiles(topDirectory, "*.txt", SearchOption.TopDirectoryOnly));
            if (filtredDirectories.Count != 0)
            {
                var enumerator = filtredDirectories.GetEnumerator();
                while(enumerator.MoveNext())
                {
                    var cur = enumerator.Current;
                    if (Path.GetFileNameWithoutExtension(cur) == "frd")
                        return true;
                }
                return false;
            }
            else
                return false;
        }

        private bool ifInSim(string topDirectory)
        {
            var filtredDirectories = new List<string>();
            var patterns = pptExtension.Split('|');
            foreach (var ext in patterns)
            {
                filtredDirectories.AddRange(Directory.EnumerateFiles(topDirectory, ext, SearchOption.TopDirectoryOnly));
            }
            if (filtredDirectories.Count != 0)
                return true;
            else
                return false;
        }

        private string GetDesignName()
        {
            var newname = designName;
            designName = string.Empty;
            return newname;
        }
    }
}
