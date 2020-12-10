using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller: MonoBehaviour
{
    public GameObject Cube;
    public GameObject ExampleCube;
    public bool Switch = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Switch = !Switch;
        }

        if (Switch)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                EnableControll();
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                Cube.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Destr();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Instant();
            }
            void Destr()
            {
                Destroy(Cube);
            }
            void Instant()
            {
                Instantiate(ExampleCube);
            }
            void EnableControll()
            {
                Cube.SetActive(false);
            }
        }
        if (!Switch)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Cube.GetComponent<MeshRenderer>().enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Instant();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                EnableControll();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Destr();
            }
            void Destr()
            {
                Destroy(Cube.GetComponent<MeshRenderer>());
            }
            void Instant()
            {
                Instantiate(ExampleCube);
                Cube.AddComponent<MeshRenderer>();
            }
            void EnableControll()
            {
                Cube.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
    
   


}
