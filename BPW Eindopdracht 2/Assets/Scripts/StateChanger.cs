using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;
    public GameObject platform5;
    public GameObject platform6;

    private int stateLevel;

    private void Start()
    {
        stateLevel = 0;
    }

    private void Update()
    {
        if(stateLevel == 0 && Input.GetKeyDown(KeyCode.Mouse1))
        {
            platform1.SetActive(false);
            platform2.SetActive(true);
            platform3.SetActive(false);
            platform4.SetActive(true);
            platform5.SetActive(false);
            platform6.SetActive(true);

            stateLevel = 1;
        }

        else if (stateLevel == 1 && Input.GetKeyDown(KeyCode.Mouse1))
        {
            platform1.SetActive(true);
            platform2.SetActive(false);
            platform3.SetActive(true);
            platform4.SetActive(false);
            platform5.SetActive(true);
            platform6.SetActive(false);

            stateLevel = 0;
        }
    }
}
