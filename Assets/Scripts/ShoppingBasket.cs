using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShoppingBasket : MonoBehaviour
{
    public static ShoppingBasket instance;

    public static Dictionary<string, int> lShopItems = new Dictionary<string, int>();


    public GameObject goButtonOrigin;
    public Transform tContent;

    private List<GameObject> m_lObjectsToShow;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else
            return;

        m_lObjectsToShow = new List<GameObject>();
        ShowBasketList();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowBasketList()
    {
        for(int i = 0; i < tContent.childCount; i++)
        {
            Destroy(tContent.GetChild(i).gameObject);
        }

        foreach(KeyValuePair<string, int> item in lShopItems)
        {
            if (item.Value == 0)
                continue;

            GameObject ii = Instantiate(goButtonOrigin);
            ii.transform.SetParent(tContent);
            ii.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = item.Key + "\n" + item.Value.ToString();

            m_lObjectsToShow.Add(ii);
        }
        
    }
}
