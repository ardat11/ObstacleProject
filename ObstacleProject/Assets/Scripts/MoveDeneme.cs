using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEditor;
using UnityEngine;

public class MoveDeneme : MonoBehaviour
{

    public GameObject LeaderSnake;
    private int childindex;
    public float delay;
    private float horpos;
    
    
    

    
    
    private void Start()
    {
        childindex = transform.GetSiblingIndex() ;
        delay *= childindex;
        StartCoroutine(LeadFollow());

    }


    private void Update()
    {
        transform.Translate(0, 0, PlayerMovement.instance.verspeed * Time.deltaTime);
    }

    IEnumerator LeadFollow()
    {
        while (true)
        {

            yield return new WaitForSeconds(delay);

            horpos = transform.position.x;
            horpos = LeaderSnake.transform.position.x;
            transform.position = new Vector3(horpos, transform.position.y, transform.position.z);

        }

    }






}
