using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initialization of Start Method");    
    }

    float coffeeTemperature = 60.0f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            TemperatureTest();
            coffeeTemperature -= Time.deltaTime * 10.0f;
        }
    }

    void TemperatureTest()
    {
        if (coffeeTemperature > 50.0f)
            print("It's Gonna too Hot!");
        else if (coffeeTemperature < 50.0f)
            print("It's a Cold Coffee");
    }
}
