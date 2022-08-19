using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class MobileTouch : MonoBehaviour
{
   
    public bool Clicked;
    public bool DoubleClicked;

    private float doubleclickDelay = 0.5f;
    private float passedTimeSinceLastClick;

    //public List<string> shoppingBasket = new List<string>();
    public GameObject clickObj;

    private string num;
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

    public void OnPointerDoublClick()
    {
        if(passedTimeSinceLastClick < doubleclickDelay)
        {
            DoubleClicked = true;
            Debug.Log("더블 클릭");

            if (CompareTag("MainSceneMenuButton"))
            {
                SceneManager.LoadScene(1);
            }
            else if (CompareTag("MenuSceneCategoriesButton"))
            {
                SceneManager.LoadScene(2);
            }
            else if(CompareTag("Shop"))
            {
                SceneManager.LoadScene(3);
            }
            else if (CompareTag("Food"))
            {
                clickObj = EventSystem.current.currentSelectedGameObject;
                //num = clickObj.GetComponentInChildren<TextMesh>().text;

                ShoppingBasket.shopping.Add(clickObj.GetComponentInChildren<TextMeshProUGUI>().text);

            }
            else if(CompareTag("test2"))
            {
                foreach(string temp in ShoppingBasket.shopping)
                {
                    Debug.Log(temp);
                }
            }
            else if(CompareTag("ShoppingBasket"))
            {
                SceneManager.LoadScene(4);
            }

            StartCoroutine(reset());
        }
        else
        {
            
            passedTimeSinceLastClick = 0;

        }
        
    }
}
