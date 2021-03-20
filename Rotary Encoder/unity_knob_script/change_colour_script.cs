using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_colour_script : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        
    }

    // Update is called once per frame
        private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "BOX")
        {
            rend.sharedMaterial = material[1];
            Debug.Log("Collison Detected");
        }
        else
        {

            rend.sharedMaterial = material[0];

        }

    }

}
