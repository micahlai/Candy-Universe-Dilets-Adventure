using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dilet : MonoBehaviour {
    public float jumpHeight;
    public float movementSpeed;
    public float fastfallSpeed;
    bool jumpOk = false;
    public Rigidbody Rigid;
	// Use this for initialization
	void Start () {
        Rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") < 0)
        {
            Rigid.AddRelativeForce(Vector3.left * movementSpeed);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            Rigid.AddForce(Vector3.right * movementSpeed);

        }
        if (Input.GetAxis("Vertical") > 0)
        {
            if (jumpOk == true)
            {
                {
                    Rigid.AddForce(Vector3.up * jumpHeight * 100);
                    jumpOk = false;
                }
            }
           
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            Rigid.AddRelativeForce(Vector3.down * fastfallSpeed * 30);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            jumpOk = true;
        }
    }
   

}
