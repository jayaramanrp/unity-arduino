using UnityEngine;
using System.Collections;
using System.IO.Ports;


public class u_serialport : MonoBehaviour {
    SerialPort sp = new SerialPort("COM5", 9600);

    // Use this for initialization
    void Start () {
        sp.Open();
        sp.ReadTimeout = 1;
    }
	
	// Update is called once per frame
	void Update () {
        try
        {
            print(sp.ReadLine());
        }
        catch (System.Exception)
        {
        }
    }
}

