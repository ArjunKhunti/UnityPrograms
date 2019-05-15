using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentEnable : MonoBehaviour
{
    Light myLight;
    
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
            myLight.enabled = !myLight.enabled;
    }
}
