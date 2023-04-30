using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myanimation : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator myanimationcat;
    void Start()
    {
        myanimationcat = GetComponent<Animator>();
        myanimationcat.SetTrigger("sitAnimation");
    }
    
}
