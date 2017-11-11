using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    Rigidbody rbody;
    Transform tform;
    Vector3 MotionVector = new Vector3(0, 0, 0);
    float Speed = -0.5f;
    // Use this for initialization
    void Start () {
        rbody = GameObject.FindObjectOfType<Rigidbody>();
        tform = FindObjectOfType<Transform>();
    }

    // Update is called once per frame
    void Update () {

     //   rbody.velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            MotionVector.z += Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MotionVector.z += -Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            MotionVector.x += Speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MotionVector.x += -Speed;
        }

        tform.position += MotionVector;

        MotionVector = new Vector3(0, 0, 0);
    }
}
