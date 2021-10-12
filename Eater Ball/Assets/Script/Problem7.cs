using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Problem7 : MonoBehaviour
{
    public float speed;
    int score;
    public Text scoreTxt;
    public SoundController sound;
    void Start()
    {
       
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), speed * Time.deltaTime);
        scoreTxt.text = "" + score;    

        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "virus")
        {
            sound.Eat();
            score++;
        }
    }
}
