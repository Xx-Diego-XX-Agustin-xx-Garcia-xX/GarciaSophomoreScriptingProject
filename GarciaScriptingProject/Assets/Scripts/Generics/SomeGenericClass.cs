using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeGenericClass
{
    public T GenericMethod<T>(T parameter)
    {
        return parameter;
    }
}
