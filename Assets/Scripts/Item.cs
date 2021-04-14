using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //every item has a name
    //every item has a description
    //every item has an image icon
    //every item has an attack strength

    public string itemName;
    public string itemDescription;
    //the Unity site recomends that these three things be set together to define the sprite
    //so, one variable becomes three
    public Sprite itemIconImage;
    public string itemIconName;
    public string itemIconType;
    //back to regulaly scheduled programming
    public int itemAttackStrength;



    // Start is called before the first frame update
    void Start()
    {

    }


}

