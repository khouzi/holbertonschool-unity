using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI my_text;
    float second = 0.0f;
    float minute = 0;

    // Update is called once per frame
    void Update()
    {
        second += Time.deltaTime;
        my_text.text = string.Format("{0}:{1:00.00}", minute, second);
        if (second >= 60)
        {
            minute++;
            second = 0;
        }
    }
}
