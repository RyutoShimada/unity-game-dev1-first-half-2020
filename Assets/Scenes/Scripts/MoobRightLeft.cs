using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoobRightLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = 4f;
        float b = 2f;

        float t = Time.time;
        Vector2 p = Vector2.down * 1;
        p.x = a * Mathf.Sin(b * t);       
        this.transform.position = p;
    }
}
