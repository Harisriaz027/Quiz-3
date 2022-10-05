using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ballToShoot;
 
    public GameObject[] frogBalls;

    private void Awake()
    {
        ballToShoot = Instantiate(frogBalls[0], new Vector3(0, 0.5f, -9), frogBalls[0].transform.rotation);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
        GameObject dir = GameObject.Find("FrogPos");
        if (Input.GetMouseButtonDown(0))
        {
           ballToShoot.GetComponent<Rigidbody>().AddForce(dir.transform.forward*30,ForceMode.Impulse);
           
        }
        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(NewBall());
        }
    }
    IEnumerator NewBall()
    {
        yield return new WaitForSeconds(0.5f);
        {
           ballToShoot= NewFrogBall();
        }
    }
    public GameObject NewFrogBall()
    {
        Debug.Log("Function working");
        return Instantiate(frogBalls[Random.Range(0, 3)], new Vector3(0, 0.5f, -9), frogBalls[Random.Range(0, 3)].transform.rotation);
    }
}
