using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayBehaviourScript : MonoBehaviour
{
    void OnGUI() 
    {
        const int buttonWidth = 84;
        const int buttonHeight = 60;

        if (GUI.Button(
            new Rect(Screen.width / 2  - (buttonWidth / 2),
            (2 * Screen.height / 2.3f) - (buttonWidth / 2),
            buttonWidth, buttonHeight),
            "Start"))
            {
                Application.LoadLevel("MenuScene");
            }
    }
}
