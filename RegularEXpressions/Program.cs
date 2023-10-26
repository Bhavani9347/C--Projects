﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regularexpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(Mr\\.?|Mrs\\.?|Miss|Ms\\.?)";
            string[] names = {"Mr.Henry Hunt","Ms.Sara Samuels","Abraham Adams","Ms.Nicole Norris"};
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name,pattern,String.Empty));
        }
    }
}
