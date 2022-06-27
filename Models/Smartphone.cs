

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Smartphone : ICallable, IBrowsable

{
    public Smartphone()
    {

    }

    public string Browse(string url)
    {

        if (url.Any(Char.IsDigit))

        {
            return $"Invalid URL!";
        }


        return $"Browsing: {url}!";


    }

    public string Call(string number)
    {
        if (number.All(char.IsDigit))
        {
            return $"Calling... {number}";
        }

        return $"Invalid number!";


    }


}
