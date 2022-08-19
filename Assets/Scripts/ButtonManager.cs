using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public MobileTouch soundButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(soundButton.Clicked)
        {
            Debug.Log("À½¼º µè±â");
        }
    }
}
