using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        if (audio != null && collision.gameObject.tag == "BallTag")
        {
            audio.Play();
        }
    }
}
