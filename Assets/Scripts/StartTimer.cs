using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class StartTimer : MonoBehaviour
{
    public GameObject Light1; //linkes Licht
    public GameObject Light2; //mittleres Licht
    public GameObject Light3; //rechtes Licht
    public GameObject carSelect; //Auto welches gestoppt werden soll
    
    void Start() //wird direkt beim Starten ausgeführt
    {
        carSelect.GetComponent<CarUserControl>().enabled = false; // deaktivert die Autosteuerung

        StartCoroutine(Countstart()); //Methode die erlaubt Code zeitlich zu pausieren
        
        
    }

    // Update is called once per frame
   
        IEnumerator Countstart()
        {

        yield return new WaitForSeconds(1.1f); //wartet für 1,1 Sek.
        Light1.SetActive(false);//deaktiviert Licht Links
        yield return new WaitForSeconds(0.8f);//wartet für 0,8 Sek.
        Light2.SetActive(false);//deaktiviert Licht in der Mitte
        yield return new WaitForSeconds(1.1f);// wartet 1,1 Sek.
        Light3.SetActive(false);// deaktiviert Licht rechts
        carSelect.GetComponent<CarUserControl>().enabled = true;// aktiviert wieder die Autosteuerung
    }
    
}
