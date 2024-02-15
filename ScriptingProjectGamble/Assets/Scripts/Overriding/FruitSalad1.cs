using UnityEngine;
using System.Collections;

public class FruitSalad1 : MonoBehaviour
{
    void Start()
    {
        Apple1 myApple = new Apple1();

        //Notice that the Apple version of the methods
        //override the fruit versions. Also notice that
        //since the Apple versions call the Fruit version with
        //the "base" keyword, both are called.
        myApple.SayHello();
        myApple.Chop();

        //Overriding is also useful in a polymorphic situation.
        //Since the methods of the Fruit class are "virtual" and
        //the methods of the Apple class are "override", when we 
        //upcast an Apple into a Fruit, the Apple version of the 
        //Methods are used.
        Fruit1 myFruit = new Apple1();
        myFruit.SayHello();
        myFruit.Chop();
    }
}