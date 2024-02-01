using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherGenericClass : MonoBehaviour
{
    void Start()
    {
        SomeGenericClass myClass = new SomeGenericClass();
        myClass.GenericMethod<int>(5);
    }
}
