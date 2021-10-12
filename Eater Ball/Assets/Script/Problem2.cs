using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Problem2 : MonoBehaviour
{
    private Rigidbody2D bola;
    public float xForce;
    public float yForce;

    void Start()
    {
        bola = GetComponent<Rigidbody2D>();
        PushBall();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
    

    void PushBall()
    {
        float randomDirection = Random.Range(0,3);
        
        if(randomDirection == 0f)
        {
            bola.AddForce(new Vector2(-xForce, -yForce));

        }else if(randomDirection == 1f)
        {
            bola.AddForce(new Vector2(-xForce, yForce));
        }else if(randomDirection == 2f)
        {
            bola.AddForce(new Vector2(xForce, -yForce));
        }else if(randomDirection == 3f)
        {
            bola.AddForce(new Vector2(xForce, yForce));
        }
    }
}
