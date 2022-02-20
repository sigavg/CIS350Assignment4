/* Luke Lesimple
 * Prototype 3
 * Spawns obstacles
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsPrefab;
    private Vector3 spawnPos = new Vector3(40, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController pc;
    
    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if (pc.gameOver == false)
        {
            Instantiate(obsPrefab, spawnPos, obsPrefab.transform.rotation);
        }
        
    }
}
