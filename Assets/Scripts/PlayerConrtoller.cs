using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConrtoller : MonoBehaviour {

    public float speed = 18;
    public float hAxis;
    public float vAxis;
    private Rigidbody rig;

    // Use this for initialization
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Abutton"))
        {
            Debug.Log("A");
        }
        if (Input.GetButtonDown("Bbutton"))
        {
            Debug.Log("B");
        }
        if (Input.GetButtonDown("Ybutton"))
        {
            Debug.Log("Y");
        }
        if (Input.GetButtonDown("Xbutton"))
        {
            Debug.Log("X");
        }
        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        rig.MovePosition(transform.position + movement);
    }
}
