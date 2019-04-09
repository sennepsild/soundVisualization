using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGenerator : MonoBehaviour
{
    public int gridSize = 30;
    public float offset = 2;

    List<GameObject> particles = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CreateGrid()
    {

        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {

                GameObject particle = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                particle.transform.position = new Vector3(x +offset*x, y + offset * y, 0);
               
                particles.Add(particle);
                particle.AddComponent<Particle>();

                particle.AddComponent<Rigidbody>();

                //particle.GetComponent<Rigidbody>().isKinematic = true;
                particle.GetComponent<Rigidbody>().useGravity = false;







            }
        }
    }


}
