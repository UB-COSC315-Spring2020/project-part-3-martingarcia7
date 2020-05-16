using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActivator : MonoBehaviour
{
    //The array holds the two enemies, or more if desired in place. The foreach loops enables any gameobject (enemy) to spawned that is inside the array.
    public GameObject[] crabEnemies;

    void Start()
    {
        foreach(GameObject crabs in crabEnemies)
        {
            crabs.SetActive(true);
        }
    }

}
