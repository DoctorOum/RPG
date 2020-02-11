using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class DialougeSystem : MonoBehaviour
{

    public Canvas DialougeChoice;
    public Canvas Option1, Option2, Option3;

    // Start is called before the first frame update
    void Start()
    {
        DialougeChoice.enabled = true;
        Option1.enabled = false;
        Option2.enabled = false;
        Option3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Option1"))
        {
            Option1.enabled = true;
            DialougeChoice.enabled = false;
        }
        else if (CrossPlatformInputManager.GetButtonDown("Option2"))
        {
            Option2.enabled = true;
            DialougeChoice.enabled = false;
        }
        else if (CrossPlatformInputManager.GetButtonDown("Option3"))
        {
            Option3.enabled = true;
            DialougeChoice.enabled = false;
        }
    }

    void chooseOption()
    {

    }
}
