using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    Rigidbody body;
    public float speed = 2;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
       body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {



        body.AddForce(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0)*Time.deltaTime *speed);
    }
}
