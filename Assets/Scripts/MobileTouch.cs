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

    
    private bool bPushed = false;
    private float tStartPush = 0f;

    public int iSceneNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        passedTimeSinceLastClick += Time.deltaTime;
        Clicked = false;
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            BackSpace();
        }

    }

    private IEnumerator reset()
    {
        yield return new WaitForEndOfFrame();
        Clicked = false;
        DoubleClicked = false;
    }

    public void BackSpace()
    {
        iSceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (iSceneNumber == 0)
        {
            Application.Quit();
            Debug.Log("종료");
        }
        else
        {
            SceneManager.LoadScene(iSceneNumber - 1);
        }
    }
    public void OnPointClick()
    {
        Clicked = true;
        //SceneManager.LoadScene(1);
        Debug.Log("한번 클릭");
        StartCoroutine(reset());
    }

    public static void OnPointerLongPushed(string key)
    {
        ShoppingBasket.lShopItems[key] = ShoppingBasket.lShopItems[key] - 1;
        ShoppingBasket.instance.ShowBasketList();
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
            else if(CompareTag("Quit"))
            {
                iSceneNumber = SceneManager.GetActiveScene().buildIndex;
                if(iSceneNumber == 0)
                {
                    Application.Quit();
                    Debug.Log("종료");
                }
                else
                {
                    SceneManager.LoadScene(iSceneNumber - 1);
                }
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
                

                string sCurrent = clickObj.GetComponentInChildren<TextMeshProUGUI>().text;
                if( ShoppingBasket.lShopItems.TryGetValue(sCurrent, out int nUseless) == false)
                {
                    ShoppingBasket.lShopItems[sCurrent] = 1;
                }
                else
                {
                    ShoppingBasket.lShopItems[sCurrent] = ShoppingBasket.lShopItems[sCurrent] + 1;
                }
            }
            else if(CompareTag("test2"))
            {
                foreach(KeyValuePair<string, int> temp in ShoppingBasket.lShopItems)
                {
                    Debug.Log(temp.Key + " " + temp.Value);
                }
            }
            else if(CompareTag("ShoppingBasket"))
            {
                SceneManager.LoadScene(4);
            }
            else if(CompareTag("ShoppingBasketFood"))
            {
                clickObj = EventSystem.current.currentSelectedGameObject;


                string sCurrent = clickObj.GetComponentInChildren<TextMeshProUGUI>().text.Split('\n')[0];
                if (ShoppingBasket.lShopItems.TryGetValue(sCurrent, out int nUseless) == false)
                {
                    ShoppingBasket.lShopItems[sCurrent] = 1;
                }
                else
                {
                    ShoppingBasket.lShopItems[sCurrent] = ShoppingBasket.lShopItems[sCurrent] + 1;
                }

                ShoppingBasket.instance.ShowBasketList();
            }

            StartCoroutine(reset());
        }
        else
        {
            
            passedTimeSinceLastClick = 0;

        }
        
    }
}
