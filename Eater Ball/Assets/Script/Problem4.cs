using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Problem4 : MonoBehaviour
{
    private Rigidbody2D bola;
    public float speed;

    void Start()
    {
        bola = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        bola.velocity = new Vector2(horizontal * speed, vertical * speed);

        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
