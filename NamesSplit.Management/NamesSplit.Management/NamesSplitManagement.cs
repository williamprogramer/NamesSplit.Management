using System.Linq;

namespace NamesSplit.Management
{
    public class NamesSplitManagement
    {
        public string[] GetNames(string fullname)
        {
            string[] compuestos = new string[] { "de" };
            string name = string.Empty;
            string[] names = fullname.Split(' ');

            foreach (string item in names)
            {
                if (compuestos.Contains(item))
                {
                    name += $"{item}_";
                }
                else
                {
                    name += $"{item} ";
                }
            }

            string[] fix = name.Split(' ').ToList().Select(x => x.Contains('_') ? x.Replace('_', ' ') : x).ToArray();

            return fix;
        }
    }
}