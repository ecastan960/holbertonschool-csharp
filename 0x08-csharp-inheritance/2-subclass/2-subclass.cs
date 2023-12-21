using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType) && baseType != derivedType) return true;
        return false;
    }
}

