using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVirusScript : MonoBehaviour
{
    public GameObject Virus;
    public int numberOfVirus;

    private void Start()
    {
        for(int i = 0; i < numberOfVirus; i ++)
        {
            Vector3 randomPos = new Vector3(Random.Range(8, -8), Random.Range(4.5f, -4.5f));
            Instantiate(Virus, randomPos, Quaternion.identity);
        }
    }
}
