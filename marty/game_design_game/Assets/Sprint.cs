using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sprint : MonoBehaviour
{
    public UnityEvent spaceDown, spaceUp;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spaceDown.Invoke();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            spaceUp.Invoke();
        }
        


    }
}
