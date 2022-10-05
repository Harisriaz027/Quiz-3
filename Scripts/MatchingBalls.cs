using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchingBalls : MonoBehaviour
{
    Color selfColor;
    Color targetColor;
    Spawn script;
   
    void Start()
    {
        selfColor = GetComponent<Renderer>().material.color;
        script = GameObject.Find("Game Manager").GetComponent<Spawn>();
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {


            targetColor = other.gameObject.GetComponent<Renderer>().material.color;
            if (selfColor == targetColor)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
            if (selfColor != targetColor)
            {
                Destroy(gameObject);
            }
        }
    }
}
