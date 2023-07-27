using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
   
    public GameObject finish;
    public GameObject checkpoint;
    public static int checkGesammelt = 0; //Variable gehört zu der Klasse

    void OnTriggerEnter(Collider other)
    {

        checkpoint.SetActive(false);  //deaktiviert den Checkpoint

        checkGesammelt += 1; //wichtig für

        Debug.Log("Check" + checkGesammelt);

        if(checkGesammelt == 11)
        {
            finish.SetActive(true); //aktiviert die Ziellinie
        }
    }
    



}
