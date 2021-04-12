using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculette : MonoBehaviour
{
    public Text CurrentButtonNumber;
    public Text Result;
    public int resultValue;
    private GameObject CurrentButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisplayResult()
    {

        Debug.Log(CurrentButtonNumber.text);
        //Result.text = CurrentButtonNumber.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
