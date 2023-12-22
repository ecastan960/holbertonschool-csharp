using System;
using System.Reflection;
using System.Collections.Generic;
/// <summary>
/// Obj class add on
/// </summary>
class Obj
{
    /// <summary>
    /// method that prints methods and properties of an object
    /// </summary>
    /// <param name="myObj">input object</param>
    public static void Print(object myObj)
    {
        TypeInfo objType = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", objType.Name);
        PropertyInfo[] typeProperties = myObj.GetType().GetProperties();
        for (int i = 0; i < typeProperties.Length; i++)
        {
            Console.WriteLine("{0}", typeProperties[i].Name);
        }
        Console.WriteLine("{0} Methods:", objType.Name);
        MethodInfo[] info = myObj.GetType().GetMethods();
        for (int i = 0; i < info.Length; i++)
        {
            Console.WriteLine("{0}", info[i].Name);
        }
    }
}
