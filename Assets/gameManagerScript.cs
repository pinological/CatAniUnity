using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startCanvas;
    public GameObject mainStory;
    public GameObject mainCat;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void startgame()
    {
        startCanvas.SetActive(false);

        mainStory.SetActive(true);

        mainCat.SetActive(true);

        

    }
}
