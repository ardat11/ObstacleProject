using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{   
    public static CameraMovement instance;

    private void Awake()
    {
        instance = this;
    }



    [SerializeField] private Transform target;
    public Vector3 Difference;
    private void LateUpdate()
    {

        if (target != null)
        {
            transform.position = target.position + Difference;


        }
    }







}
