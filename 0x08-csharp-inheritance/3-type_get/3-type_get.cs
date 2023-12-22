using System.Text;
using System;
using System.Globalization;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo objType = myObj.GetType().GetTypeInfo();
        string preformatstr = objType.ToString();
        if (preformatstr[preformatstr.Length - 1] == ']')
        {
            string[] split1 = preformatstr.Split('[');
            preformatstr = split1[0];
        }
        string[] strArray = preformatstr.Split('.');
        string formatstr = strArray[strArray.Length - 1];
        Console.WriteLine("{0} Properties:", formatstr);
        PropertyInfo[] typeProperties = myObj.GetType().GetProperties();
        for (int i = 0; i < typeProperties.Length; i++)
        {
            string s = typeProperties[i].ToString();
            string[] output = s.Split(' ');
            Console.WriteLine("{0}", output[1]);
        }
        Console.WriteLine("{0} Methods:", formatstr);
        MethodInfo[] info = myObj.GetType().GetMethods();
        for (int i = 0; i < info.Length; i++)
        {
            string s = info[i].ToString();
            string[] output = s.Split(' ');
            output = output[1].Split('(');
            Console.WriteLine("{0}", output[0]);
        }
    }
}
