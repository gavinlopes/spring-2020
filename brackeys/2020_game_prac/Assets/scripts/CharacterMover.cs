using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour

{
    private CharacterController controller;

    public Vector3 position;
    public FloatData moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
        position.Set(Input.GetAxis("Horizontal") * moveSpeed.value,0, Input.GetAxis("Vertical") * moveSpeed.value);
        if (position != Vector3.zero)
        {
            controller.transform.forward = position;
        }
        controller.Move(position * Time.deltaTime);

    }
}

