using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class CalculManager : MonoBehaviour
{
    public int CurrentButtonNumber;

    public GameObject Final;
    public Canvas InterfaceJeu;
    public GameObject[] Levels;
    public GameObject CalculOnScreen;
    public Text CalculValueOnScreen;
    public string[] Calculs;

    private int n = 0;

    public Image ImageJeu;
    //public Image ImgCanva;
    public Sprite[] Images;
    public SpriteRenderer spriteRenderer;
    public GameObject ImgObject;

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

        if (IsLevelComplete == true)
        {
            Levels[n].SetActive(false);
            if (n <= 5)
            {
                n++;
            }
            
            Levels[n].SetActive(true);
            ImageJeu.GetComponent<Image>().sprite = Images[n];

            IsLevelComplete = false;
            CalculValueOnScreen.text = Calculs[n];


            if (n == 5)
            {
                Levels[5].SetActive(false);
                Final.SetActive(true);
                CalculOnScreen.SetActive(false);
                //ImgObject.enabled(false);
            }

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