using ClassLibraryLaboratoria;
using Laboratoria;
using System;

internal class Program
{
    static void Main()
    {
        Captcha captcha = new Captcha(5);
        Console.WriteLine(captcha.captchaText);
        Console.ReadKey();
    }
}

