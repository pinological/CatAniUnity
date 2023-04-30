using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogFlow : MonoBehaviour
{
    public TextMeshProUGUI dialogBox;

    int touchCount = 0;
    public List<string> allDialog;

    void Start()
    {
        dialogBox.text = "Hi My name is MIKO";
    }

    // Update is called once per frame


    

    public void dialogFlowSwitch()
    {
        if(allDialog.Count != touchCount)
        {
            Debug.Log(touchCount);
            dialogBox.text = allDialog[touchCount];
            touchCount++;

        }
        else
        {
            Debug.Log("END");
        }
        
    }
}
