using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Threading.Tasks;

class Solution
{

    // Complete the checkMagazine function below.
    static void checkMagazine(List<string> magazines, List<string> notes)
    {

        magazines.Sort();
        notes.Sort();
        foreach (string n in notes)
        {
            if (!magazines.Remove(n))
            {
                Console.WriteLine("No");
                return;
            }
        }
        Console.WriteLine("Yes");
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        List<string> magazine = Console.ReadLine().Split(' ').ToList();

        List<string> note = Console.ReadLine().Split(' ').ToList();

        checkMagazine(magazine, note);
    }
}
