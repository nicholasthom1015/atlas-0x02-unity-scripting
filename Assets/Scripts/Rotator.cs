using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotationsPerMinute = 10.0;


     //float angle = 45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //transform.Rotate(0,6.0*rotationsPerMinute*Time.deltaTime,0);
        rotate *= rotationsPerMinute * Time.deltaTime;
        transform.Rotate(rotate);
    }
}
