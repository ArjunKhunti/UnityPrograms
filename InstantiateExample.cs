    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public Transform prefab;
    
        for(int i=0;i<10;i++)
        {
            Instantiate( prefab, NewBehaviourScript Vector3(int*2.0f, 0, 0),  Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
