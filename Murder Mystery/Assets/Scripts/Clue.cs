using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var temp = GameObject.Find("GameManager").GetComponent<ClueManager>();
            temp.AddToClues(1);
            this.gameObject.SetActive(false);
        }
    }
}
