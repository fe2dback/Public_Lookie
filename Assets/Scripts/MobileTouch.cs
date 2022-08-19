using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MobileTouch : MonoBehaviour
{
   
    public bool Clicked;
    public bool DoubleClicked;

    private float doubleclickDelay = 0.5f;
    private float passedTimeSinceLastClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        passedTimeSinceLastClick += Time.deltaTime;
        Clicked = false;
        
    }


    private IEnumerator reset()
    {
        yield return new WaitForEndOfFrame();
        Clicked = false;
        DoubleClicked = false;
    }

    public void OnPointClick()
    {
        Clicked = true;
        //SceneManager.LoadScene(1);
        Debug.Log("한번 클릭");
        StartCoroutine(reset());
    }

    public void OnPointerDown()
    {
        if(passedTimeSinceLastClick < doubleclickDelay)
        {
            DoubleClicked = true;
            Debug.Log("더블 클릭");
            SceneManager.LoadScene(1);
            StartCoroutine(reset());
        }
        else
        {
            
            passedTimeSinceLastClick = 0;

        }
        
    }
}
