using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   

    public static PlayerMovement instance;

    private float horizontal;

    public float horspeed;
    public float verspeed;
    private float horpos;

    public float leftlimit;
    public float rightlimit;
    public float delaymult;
    private float delay;

    private void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
       
        transform.Translate(horizontal * verspeed * Time.deltaTime, 0,verspeed * Time.deltaTime);

        
        horpos = Mathf.Clamp(transform.position.x, leftlimit, rightlimit);

        transform.position = new Vector3(horpos,transform.position.y,transform.position.z);

    }

}
