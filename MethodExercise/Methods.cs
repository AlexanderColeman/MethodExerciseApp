using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise;

public class Methods
{
    public string GetString(string prompt)
    {
        Console.WriteLine(prompt);
        var input = Console.ReadLine();
        return input;
    }


}
