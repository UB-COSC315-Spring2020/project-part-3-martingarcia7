using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour
{
    public GameObject fruitText;
    public static int fruitCount;

    void Update()
    {
        fruitText.GetComponent<Text>().text = "" + fruitCount;
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (fruitCount >= 10)
        {
           //
        }
    }
}
