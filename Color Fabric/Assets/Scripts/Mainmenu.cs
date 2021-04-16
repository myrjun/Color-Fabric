using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Canvas;
    bool Menuactive = true;

    private void Start()
    {
        Menu.SetActive(true);
        Canvas.SetActive(false);
    }

    void Update()
    {

    }
 
    public void CacaProut() 
    {
        Menuactive = false;
        Menubool();
    }

    public void ReturnButton()
    {
        Menuactive = true;
        Menubool();
    }


    public void Menubool()
    {
        if (Menuactive == true)
        {          
            Menu.SetActive(true);
            Canvas.SetActive(false);

        } else if (Menuactive == false)
        {
            Menu.SetActive(false);
            Canvas.SetActive(true);
        }

    }

   
}
