using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float currentTime;
    public float startingTime;
    public GameObject timer;

    [SerializeField] TextMeshProUGUI countdownText;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            ResetPuzzle();
        }
    }

    public void ResetPuzzle()
    {
        currentTime = startingTime;
        timer.SetActive(false);
    }
}
