using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour
{
    private int score = 0;
    public Rigidbody rb;
    public float speed;
    public int health = 5;
    public Text scoreText, healthText, winloseText;
    public Image winloseBG;

    void win()
    {
        winloseBG.gameObject.SetActive(true);
        winloseBG.color = Color.green;
        winloseText.text = "You Win!";
        winloseText.color = Color.black;
        StartCoroutine(LoadScene(3));
    }

    void lose()
    {
        winloseBG.gameObject.SetActive(true);
        winloseBG.color = Color.red;
        winloseText.text = "Game Over!";
        winloseText.color = Color.white;
        StartCoroutine(LoadScene(3));
    }

    void SetHealthText()
    {
        healthText.text = health.ToString("Health: " + health);
    }

    void SetScoreText()
    {
        scoreText.text = score.ToString("Score: " + score);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            SetScoreText();
            Destroy(other.gameObject);
        }

        if (other.tag == "Trap")
        {
            health--;
            SetHealthText();
        }

        if (other.tag == "Goal")
        {
            win();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("q") || Input.GetKey("left"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("z") || Input.GetKey("up"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
    }

    void Update()
    {
        if (health == 0)
        {
            lose();
        }

        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene("Menu");
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Maze");
    }
}
