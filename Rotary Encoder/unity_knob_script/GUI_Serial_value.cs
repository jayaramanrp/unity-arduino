using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
public class GUI_Serial_value : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM5", 9600);
    public float speed, right, left;
    public float pos;
    void Start()
    {

        sp.Open(); //Open the Serial
        sp.ReadTimeout = 1;
        Debug.Log("bye");
    }

    // Update is called once per frame
    void Update() { 
   try
        {
            //print(sp.ReadLine());
            string value = sp.ReadLine(); //Read the information
            //string[] vec2 = value.Split(','); //My arduino script returns a 3 part value (IE: 12,30,18)
            pos = 0;
           // right = float.Parse(vec2[0]);
           // left = float.Parse(vec2[1]);
            if (value == "r") {
                pos++;
            }
            else if (value == "l")
            {
                pos --;
            }

            Debug.Log(pos);
            Vector3 direction = new Vector3(pos, 0, 0);
            gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
        }
        catch (System.Exception)
        {
        }
    }
}
