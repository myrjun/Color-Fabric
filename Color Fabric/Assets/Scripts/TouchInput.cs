using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour
{
    public int CurrentButtonNumber;
    
    public Canvas Interface01;
    public Canvas Interface02;
    public Canvas Interface03;
    public Canvas Interface04;
    public Canvas Final;

    public Text Result;

    public int resultValue;

    private Button CurrentButton;

    //public ArrayList;

    
    void Start()
    {
       
    }

    public void DisplayResult()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        int CurrentButtonNumber;
        int.TryParse(name, out CurrentButtonNumber);
        Debug.Log(CurrentButtonNumber);

        ResultatCalcul();

    }

    public void ResultatCalcul()
    {

    }


    void Update()
    {
        
    }

    public void OnChangeCanvas()
    {

    }
}
