using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentExample : MonoBehaviour
{

    public GameObject otherGameObject;

    private Script1 scr1;
    private Script2 scr2;
    private BoxCollider boxCol;

    private void Awake()
    {
        scr1 = GetComponent<Script1>();
        scr2 = otherGameObject.GetComponent<Script2>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("Data of Script1 : " + scr1.msg);
        Debug.Log("Data of Script2 : " + scr2.str);
    }

}
