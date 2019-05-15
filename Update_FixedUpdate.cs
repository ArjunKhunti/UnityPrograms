using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Update_FixedUpdate : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time is : " + Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log("Time is : " + Time.deltaTime);
    }
}
