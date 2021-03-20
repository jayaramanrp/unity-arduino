using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collison_colour : MonoBehaviour
{
    public class Colour : MonoBehaviour
    {
        void OncollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "Cube_box")
            {
                col.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                print("collison detected");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
