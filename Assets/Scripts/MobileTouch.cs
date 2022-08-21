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

    public static string sCurrent;

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
        if(Clicked == true)
        {
            if (CompareTag("MainSceneMenuButton"))
            {
                SoundM.instance.menuselect();
            }
            else if(CompareTag("Tutorial"))
            {
                SoundM.instance.tutorial();
            }
            else if(CompareTag("Option"))
            {
                SoundM.instance.option();
            }
            else if (CompareTag("Quit"))
            {
                SoundM.instance.quit();
            }
            else if(CompareTag("Drink"))
            {
                SoundM.instance.drink();
            }
            else if(CompareTag("Coffee"))
            {
                SoundM.instance.coffee();
            }
            else if(CompareTag("Shop"))
            {
                SoundM.instance.shop();
            }
            else if(CompareTag("Menu_1"))
            {
                SoundM.instance.menu_1();
            }
            else if (CompareTag("Menu_2"))
            {
                SoundM.instance.menu_2();
            }
            else if (CompareTag("Menu_3"))
            {
                SoundM.instance.menu_3();
            }
            else if (CompareTag("Menu_4"))
            {
                SoundM.instance.menu_4();
            }
            else if (CompareTag("Menu_5"))
            {
                SoundM.instance.menu_5();
            }
            else if (CompareTag("Menu_6"))
            {
                SoundM.instance.menu_6();
            }
            else if (CompareTag("Menu_7"))
            {
                SoundM.instance.menu_7();
            }
            else if (CompareTag("Menu_8"))
            {
                SoundM.instance.menu_8();
            }
            else if (CompareTag("Menu_9"))
            {
                SoundM.instance.menu_9();
            }
            else if (CompareTag("Menu_10"))
            {
                SoundM.instance.menu_10();
            }
            else if (CompareTag("Menu_11"))
            {
                SoundM.instance.menu_12();
            }
            else if (CompareTag("Menu_13"))
            {
                SoundM.instance.menu_14();
            }
            else if (CompareTag("Menu_15"))
            {
                SoundM.instance.menu_15();
            }
            else if (CompareTag("Menu_16"))
            {
                SoundM.instance.menu_16();
            }
            else if (CompareTag("Menu_17"))
            {
                SoundM.instance.menu_17();
            }
            else if (CompareTag("Menu_18"))
            {
                SoundM.instance.menu_18();
            }
            else if (CompareTag("Menu_19"))
            {
                SoundM.instance.menu_19();
            }
            else if (CompareTag("Menu_20"))
            {
                SoundM.instance.menu_20();
            }
            else if (CompareTag("Menu_21"))
            {
                SoundM.instance.menu_21();
            }
            else if (CompareTag("Menu_22"))
            {
                SoundM.instance.menu_22();
            }
            else if (CompareTag("Menu_23"))
            {
                SoundM.instance.menu_23();
            }
            else if (CompareTag("Menu_24"))
            {
                SoundM.instance.menu_24();
            }
            else if (CompareTag("Menu_25"))
            {
                SoundM.instance.menu_25();
            }
            else if (CompareTag("Menu_26"))
            {
                SoundM.instance.menu_26();
            }
            






            else
            {
                StartCoroutine(reset());
            }
        }
       

        
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
            else if(CompareTag("Drink"))
            {
                SceneManager.LoadScene(2);
            }
            else if (CompareTag("Coffee"))
            {
                SceneManager.LoadScene(2);
            }
            else if(CompareTag("Shop"))
            {
                SceneManager.LoadScene(3);
            }




            else if (CompareTag("Menu_1"))
                {
                    clickObj = EventSystem.current.currentSelectedGameObject;


                    string sCurrent = clickObj.GetComponentInChildren<TextMeshProUGUI>().text;

                    if (ShoppingBasket.lShopItems.TryGetValue(sCurrent, out int nUseless) == false)
                    {
                        ShoppingBasket.lShopItems[sCurrent] = 1;
                    }
                    else
                    {
                        ShoppingBasket.lShopItems[sCurrent] = ShoppingBasket.lShopItems[sCurrent] + 1;
                    }

                }
            else if (CompareTag("Menu_2"))
            {
                clickObj = EventSystem.current.currentSelectedGameObject;


                string sCurrent = clickObj.GetComponentInChildren<TextMeshProUGUI>().text;

                if (ShoppingBasket.lShopItems.TryGetValue(sCurrent, out int nUseless) == false)
                {
                    ShoppingBasket.lShopItems[sCurrent] = 1;
                }
                else
                {
                    ShoppingBasket.lShopItems[sCurrent] = ShoppingBasket.lShopItems[sCurrent] + 1;
                }

            }
            else if (CompareTag("Menu_3"))
            {
                clickObj = EventSystem.current.currentSelectedGameObject;


                string sCurrent = clickObj.GetComponentInChildren<TextMeshProUGUI>().text;

                if (ShoppingBasket.lShopItems.TryGetValue(sCurrent, out int nUseless) == false)
                {
                    ShoppingBasket.lShopItems[sCurrent] = 1;
                }
                else
                {
                    ShoppingBasket.lShopItems[sCurrent] = ShoppingBasket.lShopItems[sCurrent] + 1;
                }

            }
            else if (CompareTag("Menu_4"))
            {
                clickObj = EventSystem.current.currentSelectedGameObject;


                string sCurrent = clickObj.GetComponentInChildren<TextMeshProUGUI>().text;

                if (ShoppingBasket.lShopItems.TryGetValue(sCurrent, out int nUseless) == false)
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
