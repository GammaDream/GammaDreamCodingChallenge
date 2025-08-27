using UnityEngine;
using System;

public class ButtonPress : MonoBehaviour
{

    //TODO: This should notify other scripts when the button is pressed.
    public event Action<ButtonPress> ButtonPressed;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player")
        {
            //TODO: Alert the other scripts that the button has been pressed!
            Debug.Log("Button Pressed!");
        }
    }
}
