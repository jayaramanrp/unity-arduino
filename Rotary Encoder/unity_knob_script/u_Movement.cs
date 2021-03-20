using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class u_Movement : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
    }
}

	