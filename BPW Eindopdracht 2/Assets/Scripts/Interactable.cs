using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject timer;
    public void StartTimer()
    {
        timer.SetActive(true);
    }
}
