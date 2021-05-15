using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testdome_mergelist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> KeyVal = new Dictionary<string, int>(){ {"A",1 }, {"B", 2}};
            string[] vals = null;
            
            // use this 1 - to add names in array
            int m = 0;
            foreach (string K in KeyVal.Keys)
            {
                vals[m] = K;
            }

            // use this 2 - to add names in array
            foreach (string K in KeyVal.Keys)
            {
                vals.Concat(new string[] {K}).ToArray();
            }

            // use this 3 - to add names in array
            // first make a string and use Add method
            // then convert ToArray
            List<string> valsList = new List<string>();
            foreach (string K in KeyVal.Keys)
            {
                valsList.Add(K);
            }
            string[] vals_final = valsList.ToArray(); // convert List to Array

            //use this 4 - to add names in array
            // use only if you had dictionary as {{1, "Ava"},{2, "Emma"}}
            // string[] vals = new string[400];
            for (int i = 0; i < 400; i++)
            {
                vals[i] = Dict1[i];
            }

        }
    }
}

public class MergeNames
{
using System;
using System.Collections.Generic;
using System.Linq;

public class MergeNames
{
    

    using System;
using System.Collections.Generic;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        Dictionary<string, int> keyvale = new Dictionary<string, int>();
        var val = new List<string>();
        int i = 0;
        for (i = 0; i < names1.Length; i++)
        {
            if (keyvale.ContainsKey(names1[i]))
            { }
            else
                keyvale.Add(names1[i], i);
        }

        for (int j = 0; j < names2.Length; j++)
        {
            if (keyvale.ContainsKey(names2[j]))
            { }
            else
                keyvale.Add(names2[j], i);
        }


        foreach (string K in keyvale.Keys)
        {
            val.Add(K);
        }
        return val.ToArray();


    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}
}



public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        var list = new List<string>();
        list.AddRange(names1);
        list.AddRange(names2);

        return list
                .Distinct() //The returned array should have no duplicates.
                .ToArray(); //should return an array
    }

    public static void Main(string[] args)
    {
        var names1 = new string[] { "Ava", "Emma", "Olivia" };
        var names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}