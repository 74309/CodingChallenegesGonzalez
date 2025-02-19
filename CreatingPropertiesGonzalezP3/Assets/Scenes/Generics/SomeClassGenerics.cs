using UnityEngine;
using System.Collections;

public class SomeClassGenerics
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}