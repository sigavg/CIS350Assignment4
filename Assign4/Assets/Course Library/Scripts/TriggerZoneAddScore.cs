/* Luke Lesimple
 * prototype 3
 * Adds score when trigger zone is entered
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private UImanager uiM;

    private bool trig = false;


    // Start is called before the first frame update
    void Start()
    {
        uiM = GameObject.FindObjectOfType<UImanager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !trig)
        {
            trig = true;
            uiM.score++;
        }
    }

}
