using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //Bill is $40
    //Tip is going to be 20% or based on user desire
    //calculte total amount

    public float billAmount = 40.00f;

    //challenge review
    public float bill = 40.00f;
    public float tip = 20.0f;
    public float totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        //Your bill is : and your tip amount is : so you owe :
        Debug.Log("Your bill amount is $" + billAmount);
        Debug.Log("Your tip, at 20%, is $" + billAmount * 0.2);
        Debug.Log("Your total bill is now $" + (billAmount + (billAmount * 0.2)));

        //other option
        float tipAmount = bill * (tip / 100);
        float tipAmount2 = bill * tip;
        //or ...
        totalAmount = bill + tipAmount;

        Debug.Log("Your bill is " + bill + " and your tip amount is " + tipAmount);
        Debug.Log("So you now owe " + (bill + tipAmount));
        //Your bill is: and your tip amount is: so you owe: totalAmount
        //or ...
        Debug.Log("You now owe " + totalAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
