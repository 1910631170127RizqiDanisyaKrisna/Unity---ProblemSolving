using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSciptCh8 : MonoBehaviour
{
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            StartCoroutine(HitbyPlayer());
        }
    }

    IEnumerator HitbyPlayer()
    {
        sprite.enabled = false;
        yield return new WaitForSeconds(3);
        transform.position = new Vector3(Random.Range(8, -8), Random.Range(4.5f, -4.5f));
        sprite.enabled = true;

    }
}
