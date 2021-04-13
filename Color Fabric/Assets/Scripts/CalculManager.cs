using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class CalculManager : MonoBehaviour
{
    public int CurrentButtonNumber;

    public Canvas InterfaceJeu;
    public Canvas Final;
    public GameObject[] Levels;
    public GameObject CalculOnScreen;
    public Text CalculValueOnScreen;

    private int n = 0;

    public GameObject ImageJeu;
    public Sprite[] Images;

    public string[] Calculs;

    private bool IsLevelComplete;
    private int InterfaceNumber;


    void Start()
    {
        IsLevelComplete = false;
        CalculValueOnScreen = CalculOnScreen.GetComponent<Text>();
        CalculValueOnScreen.text = Calculs[0];
    }

    public void DisplayResult()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        int.TryParse(name, out CurrentButtonNumber);
        ResultatCalcul();

    }

    public void CanvaChange()
    {
        Debug.Log(n + "n");
        if (IsLevelComplete == true)
        {

            Levels[n].SetActive(false);
            if (n <= 4)
            {
                n++;
            }
            Levels[n].SetActive(true);

            Debug.Log(n + "n");
            IsLevelComplete = false;
            CalculValueOnScreen.text = Calculs[n];

        }

        if (n == 5)
        {
            Final.enabled = true;
            InterfaceJeu.enabled = false;
        }

    }


    public void ResultatCalcul()
    {
        int[] Result = new int[] { 2, 7, 4, 8, 2 };
        if (CurrentButtonNumber == Result[n])
        {
            Debug.Log("it works");
            IsLevelComplete = true;
            CanvaChange();

        }
        else if (CurrentButtonNumber != Result[n])
        {
            Debug.Log("false");
        }

    }
}