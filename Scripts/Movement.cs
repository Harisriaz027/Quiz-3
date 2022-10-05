using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    private int current;
    Pointslocation script;
    
    void Start()
    {
        script = GameObject.Find("Points").GetComponent<Pointslocation>();
        target = script.target;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % target.Length;
        }
        if (transform.position == target[target.Length - 1].transform.position)
        {
            Time.timeScale = 2;
            Destroy(gameObject);
        }
    }
}
