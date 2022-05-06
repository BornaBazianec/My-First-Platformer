using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    bool jump;
    bool touchGround;
    private float horizontal;
    public AudioClip coinSound;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& touchGround==true)
        {
            jump = true;
        }
        horizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        if (jump)
        {
            rigidbodyComponent.AddForce(8 * Vector3.up,ForceMode.VelocityChange);
            jump = false;
            touchGround = false;
        }
        rigidbodyComponent.velocity = new Vector3(horizontal, rigidbodyComponent.velocity.y, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        touchGround = true;
    }
}
