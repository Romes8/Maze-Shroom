using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speedmod = 0.04f;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal")*speedmod, Input.GetAxis("Vertical")*speedmod, 0));
        if (Input.GetAxis("Horizontal") > 0.5f)
        {
            transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, 90);
        } 
        else if (Input.GetAxis("Horizontal") < -0.5f)
        {
            transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (Input.GetAxis("Vertical") > 0.5f)
        {
            transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetAxis("Vertical") < -0.5f)
        {
            transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
