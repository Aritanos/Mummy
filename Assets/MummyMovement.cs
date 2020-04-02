using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MummyMovement : MonoBehaviour
{
    private Vector3 dir;
    public float speed;

    private Rigidbody rig;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dir.z = CrossPlatformInputManager.GetAxis("Vertical");
        dir.x = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector3 movement = new Vector3(dir.x,0,dir.z);
        if (dir!= Vector3.zero)
            transform.rotation = Quaternion.LookRotation(dir);

        rig.velocity = movement * speed;
    }


}
