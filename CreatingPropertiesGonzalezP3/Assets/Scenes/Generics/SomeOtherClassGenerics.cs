using UnityEngine;
using System.Collections;

public class SomeOtherClassGenerics : MonoBehaviour
{
    void Start()
    {
        SomeClassGenerics myClass = new SomeClassGenerics();

        myClass.GenericMethod<int>(5);
    }
}