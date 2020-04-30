using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockTime : MonoBehaviour
{
    public bool slowTime;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (slowTime)
            {
                GameObject.FindWithTag("Player").GetComponent<SlowTime>().enabled = true;
                Destroy(gameObject);
            }
             
            
        }
    }
}
