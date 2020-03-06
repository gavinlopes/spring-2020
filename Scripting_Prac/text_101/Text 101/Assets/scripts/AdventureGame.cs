using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    string[] daysOfWeek = {"mon", "tues", "wed", "thurs"};

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(daysOfWeek[1]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
