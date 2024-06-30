using System.Linq;
using System.Xml.Linq;

namespace NamesSplit.Management
{
    public class NamesSplitManagement
    {
        public string[] GetNames(string fullname)
        {
            fullname = fullname.ToLower();
            string _fullname = string.Empty;

            string[] compounds = new string[] { "de", "del", "la" };
            string[] names = fullname.Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                if ((i + 1) < names.Length && compounds.Contains(names[i + 1]) || compounds.Contains(names[i]))
                    _fullname += $"{names[i]}_";
                else
                    _fullname += $"{names[i]} ";
            }

            return _fullname.Trim().Split(' ').Select(x => x.Contains('_') ? x.Replace('_', ' ') : x).ToArray();
        }
    }
}