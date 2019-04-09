using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public Vector3 velocity = new Vector3();
    Vector3 acceleration = new Vector3();
    


    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        


        velocity += acceleration;
        transform.Translate(acceleration);

        

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collision bitch");

        acceleration = collision.gameObject.GetComponent<Particle>().velocity;


    }
}
