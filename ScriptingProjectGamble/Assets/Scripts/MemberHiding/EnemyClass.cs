using UnityEngine;
using System.Collections;

public class EnemyClass : HumanoidClass
{
    //This hides the Humanoid version.
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
