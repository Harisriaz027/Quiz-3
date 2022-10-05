using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public List<GameObject> balls;
    public List<GameObject> clones;
    
    void Start()
    {
        StartCoroutine(BallSpawn());
       
    }

    IEnumerator BallSpawn()
    {
        while (true)
        {
            for (int i = 0; i < 25; i++)
            {
                yield return new WaitForSeconds(.5f);
                clones[i]=Instantiate(balls[Random.Range(0, balls.Count)], new Vector3(-21.38f, 0.5f, -3.3f), Quaternion.identity);
                if (i == 24)
                {
                    StopAllCoroutines();
                }
            }
        }
    }
}
