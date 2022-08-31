using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundM : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip MenuSelect;
    public AudioClip Tutorial;
    public AudioClip Option;
    public AudioClip Quit;
    public AudioClip Drink;
    public AudioClip Coffee;
    public AudioClip Shop;

    public AudioClip Menu_1;
    public AudioClip Menu_2;
    public AudioClip Menu_3;
    public AudioClip Menu_4;
    public AudioClip Menu_5;
    public AudioClip Menu_6;
    public AudioClip Menu_7;
    public AudioClip Menu_8;
    public AudioClip Menu_9;
    public AudioClip Menu_10;
    public AudioClip Menu_11;
    public AudioClip Menu_12;
    public AudioClip Menu_13;
    public AudioClip Menu_14;
    public AudioClip Menu_15;
    public AudioClip Menu_16;
    public AudioClip Menu_17;
    public AudioClip Menu_18;
    public AudioClip Menu_19;
    public AudioClip Menu_20;
    public AudioClip Menu_21;
    public AudioClip Menu_22;
    public AudioClip Menu_23;
    public AudioClip Menu_24;
    public AudioClip Menu_25;
    public AudioClip Menu_26;
    public AudioClip ShoppingBasket;

  
    


    public static SoundM instance;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Awake()
    {
        if (SoundM.instance == null)
        {
            SoundM.instance = this;
        }
    }



    public void menuselect()
    {
       
       audioSource.PlayOneShot(MenuSelect);
        
        
    }

    public void tutorial()
    {
        audioSource.PlayOneShot(MenuSelect);
    }

    public void option()
    {
        audioSource.PlayOneShot(Option);
    }

    public void quit()
    {
        audioSource.PlayOneShot(Quit);
    }

    public void drink()
    {
        audioSource.PlayOneShot(Drink);
    }

    public void coffee()
    {
        audioSource.PlayOneShot(Coffee);
    }
    public void shop()
    {
        audioSource.PlayOneShot(Shop);
    }

    public void menu_1()
    {
        audioSource.PlayOneShot(Menu_1);
    }

    public void menu_2()
    {
        audioSource.PlayOneShot(Menu_2);
    }

    public void menu_3()
    {
        audioSource.PlayOneShot(Menu_3);
    }

    public void menu_4()
    {
        audioSource.PlayOneShot(Menu_4);
    }

    public void menu_5()
    {
        audioSource.PlayOneShot(Menu_5);
    }

    public void menu_6()
    {
        audioSource.PlayOneShot(Menu_6);
    }

    public void menu_7()
    {
        audioSource.PlayOneShot(Menu_7);
    }

    public void menu_8()
    {
        audioSource.PlayOneShot(Menu_8);
    }

    public void menu_9()
    {
        audioSource.PlayOneShot(Menu_9);
    }

    public void menu_10()
    {
        audioSource.PlayOneShot(Menu_10);
    }

    public void menu_11()
    {
        audioSource.PlayOneShot(Menu_11);
    }

    public void menu_12()
    {
        audioSource.PlayOneShot(Menu_12);
    }

    public void menu_13()
    {
        audioSource.PlayOneShot(Menu_13);
    }

    public void menu_14()
    {
        audioSource.PlayOneShot(Menu_14);
    }

    public void menu_15()
    {
        audioSource.PlayOneShot(Menu_15);
    }

    public void menu_16()
    {
        audioSource.PlayOneShot(Menu_16);
    }

    public void menu_17()
    {
        audioSource.PlayOneShot(Menu_17);
    }
    public void menu_18()
    {
        audioSource.PlayOneShot(Menu_18);
    }
    public void menu_19()
    {
        audioSource.PlayOneShot(Menu_19);
    }
    public void menu_20()
    {
        audioSource.PlayOneShot(Menu_20);
    }

    public void menu_21()
    {
        audioSource.PlayOneShot(Menu_21);
    }
    public void menu_22()
    {
        audioSource.PlayOneShot(Menu_22);
    }

    public void menu_23()
    {
        audioSource.PlayOneShot(Menu_23);
    }
    public void menu_24()
    {
        audioSource.PlayOneShot(Menu_24);
    }
    public void menu_25()
    {
        audioSource.PlayOneShot(Menu_25);
    }
    public void menu_26()
    {
        audioSource.PlayOneShot(Menu_26);
    }

    public void shoppingBasket()
    {
        audioSource.PlayOneShot(ShoppingBasket);
    }

}
