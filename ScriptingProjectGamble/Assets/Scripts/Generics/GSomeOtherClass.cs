using UnityEngine;
using System.Collections;

public class GSomeOtherClass : MonoBehaviour
{
    void Start()
    {
        GSomeClass myClass = new GSomeClass();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}
