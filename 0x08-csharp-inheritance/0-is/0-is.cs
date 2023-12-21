using System;

/// <summary>
/// Class Obj add on
/// </summary>
class Obj
{
    /// <summary>
    /// return true if obj is of type int
    /// </summary>
    /// <param name="obj">Object to compare</param>
    /// <returns></returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int)) return true;
        return false;
    }
}

