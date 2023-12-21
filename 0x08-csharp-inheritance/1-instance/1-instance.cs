using System;

/// <summary>
/// Class Obj add on
/// </summary>
class Obj
{
    /// <summary>
    /// method that returns True if the object is an instance of, 
    /// or if the object is an instance of a class that inherited from, Array, 
    /// otherwise return False.
    /// </summary>
    /// <param name="obj">obj to compare</param>
    /// <returns></returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType().IsSubclassOf(typeof(Array))) return true;
        if (typeof(Array).IsInstanceOfType(obj.GetType())) return true;

        return false;
    }
}

