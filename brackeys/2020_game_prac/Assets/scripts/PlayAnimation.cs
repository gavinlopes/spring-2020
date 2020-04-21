using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimation.SetBool("PlayDrive", true);
        }
    }    
}
