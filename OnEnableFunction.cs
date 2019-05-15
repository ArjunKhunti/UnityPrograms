using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("Script is Enable");
    }

    private void OnDisable()
    {
        Debug.Log("Script is Disable");
    }
}
