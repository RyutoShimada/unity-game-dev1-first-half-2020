using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeCountBreakeBlock : MonoBehaviour
{
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BallTag" && i == 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            i++;
        }
    }

}
