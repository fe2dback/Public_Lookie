using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for ( int i = 0; i < 29; i++)
        {
            Debug.Log("else if(CompareTag(\"Menu_" + i + "))SoundM.instance.menu_" + i + "();");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
