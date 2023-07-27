using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapComplete : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject miliDisplay;


    public static GameObject test;
    public GameObject finish;
    public GameObject[] checkpoints;
    // checkpoints;
    private void Start()
    {
        finish.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {


        if (Trigger.checkGesammelt == 11)
        {
            if (LapTimer.sekZaehler <= 9)
            {
                secondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimer.sekZaehler + "."; //01.

            }
            else
            {
                secondDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimer.sekZaehler + "."; //01.
            }
            if (LapTimer.minZaehler <= 9)
            {
                minuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimer.minZaehler + "."; //01.
  
            }
            else
            {
                minuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimer.minZaehler + "."; //01.

                miliDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimer.miliZaehler;

            }
            
            finish.SetActive(false);
            LapTimer.miliZaehler = 0;
            LapTimer.minZaehler = 0;
            LapTimer.sekZaehler = 0;

            for (int i =0; i < checkpoints.Length; i++) {
                checkpoints[i].SetActive(true);
                Debug.Log("schleife1");
            }
            Trigger.checkGesammelt = 0;

        }
        else
        {
            
        }
           
      
            
                



        
       

        
    }
}
