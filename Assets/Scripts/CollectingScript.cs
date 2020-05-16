using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingScript : MonoBehaviour
{
    public AudioSource fruitSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
            Destroy(other.gameObject);
            fruitSound.Play();
            ScoringScript.fruitCount += 1;
        }

    }

    //if player collides with gameobject that contains the tag "apple", then it will collect one fruit, destroy the gameobject, and play the fruit sound.


}
