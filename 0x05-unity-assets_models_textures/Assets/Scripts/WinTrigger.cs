using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WinTrigger : MonoBehaviour
{
    public TextMeshProUGUI my_text;
    Timer timer;
    GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.tag == "Player")
                player = GameObject.Find("Player");
            timer = player.GetComponent<Timer>();
            timer.enabled = false;
            my_text.color = Color.green;
            my_text.fontSize = 60;
        }
    }
}
