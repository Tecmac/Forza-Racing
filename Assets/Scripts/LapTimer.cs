using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // wird für die UI Elemente benötigt,LapTime und BestLap
public class LapTimer : MonoBehaviour
{
    public static int minZaehler ;
    public static int sekZaehler ;
    public static float miliZaehler ;
    public static string miliDisplay;

    public GameObject minBox;
    public GameObject sekBox;
    public GameObject miliBox;
   
    void Update()
    {
        if (Trigger.checkGesammelt >= 1)
        {
            miliZaehler += Time.deltaTime * 10; // intervall in sekunden deswegen *10 für mili
            miliDisplay = miliZaehler.ToString("F0");
            miliBox.GetComponent<TextMeshProUGUI>().SetText(miliDisplay);
            if (miliZaehler >= 8.99999)
            {
                miliZaehler = 0;
                sekZaehler += 1;

            }
            // Sekunden formatieren zu 1 : 01.
            //
            //
            if (sekZaehler <= 9)

                sekBox.GetComponent<TextMeshProUGUI>().text = "0" + sekZaehler + "."; //01.
            else
                sekBox.GetComponent<TextMeshProUGUI>().text = "" + sekZaehler + "."; //10.


            if (sekZaehler >= 60)
            {
                sekZaehler = 0;
                minZaehler += 1;
            }
            // Sekunden in Minuten
            if (minZaehler <= 9.9)
            {
                minBox.GetComponent<TextMeshProUGUI>().text = "0" + minZaehler + ":";
            }
            else
            {
                minBox.GetComponent<TextMeshProUGUI>().text = "" + minZaehler + ":";
            }
        }
        
    }
}
