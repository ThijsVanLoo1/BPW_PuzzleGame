using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable2 : MonoBehaviour
{
    public GameObject timer;

    public void MadeIt()
    {
        if (timer.activeInHierarchy == true)
        {
            timer.SetActive(false);
            GetComponent<Animator>().Play("Tutorial_Door");
            GetComponent<Animator>().Play("Door2_open");
            GetComponent<Animator>().SetBool("OpenDoor", true);
        }
    }
}
