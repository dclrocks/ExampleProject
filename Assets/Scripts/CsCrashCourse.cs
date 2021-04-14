using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCrashCourse : MonoBehaviour
{
    //create a variable to store your name
    //create a variable to store you age
    //create a variable to store you speed
    //create a variable to store your health
    //create  variable to store your score
    //create a variable to check if all keys have been collected
    //create a variable or your ammo count



    //Unity specific variables that can be hooked up to objects within the editor
    public string myName = "David";
    public int age = 49;
    public float mySpeed = 5.5f;
    public GameObject player;
    public Animator anim;
    public Transform myTransform;
    public int health = 80;
    public double score = 100000000000;
    public bool allKeys = false;
    public int ammoCount = 34652387;

    // Start is called before the first frame update
    void Start()
    {
        //With the UNity-specific vars, you can now grab data from those objects via the variable in the script
        Debug.Log(myTransform.position.x);
        Debug.Log("My name is " + myName);
        Debug.Log("I am " + age + "years old.");
        Debug.Log("My speed is " + mySpeed + "meters per second.");
        Debug.Log("My health is " + health + "%.");
        Debug.Log("My score in this game is " + score + "points.");
        Debug.Log("Do I have all the keys? " + allKeys);
        Debug.Log("I have " + ammoCount + "rounds of ammunition.");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
