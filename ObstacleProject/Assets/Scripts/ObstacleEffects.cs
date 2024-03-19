using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEffects : MonoBehaviour
{
    public float gap;
    public GameObject FollowerSnake;
    public GameObject LeaderSnake;
    public int adding;
    public GameObject SnakeParent;
    
    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.CompareTag("Fire"))
        {
            Destroy(other.transform.parent.gameObject);
            deletesnake(2);
        }

        if (other.gameObject.CompareTag("Water"))
        {
            Destroy(other.transform.parent.gameObject);
            deletesnake(1);
        }

        if (other.gameObject.CompareTag("Leaf"))
        {
            Destroy(other.transform.parent.gameObject);
            addtosnake(1);
            print("Deðdi yapraða");
        }
    }


    private void addtosnake(int amount)
    {
        for (int i = 1; i <= amount; i++)
        {
            int lastsnakenum = SnakeParent.transform.childCount - 1;
            Transform lastsnake = SnakeParent.transform.GetChild(lastsnakenum);
            
            GameObject newsnakelayer = Instantiate(FollowerSnake, new Vector3(lastsnake.transform.position.x,lastsnake.transform.position.y, lastsnake.transform.position.z -1), Quaternion.identity);
            
            
            newsnakelayer.transform.SetParent(SnakeParent.transform);
            CameraMovement.instance.Difference.z -= 1;
        }
        HealthManager.instance.health++;
    
    }

   
    private void deletesnake(int amount)

    {
        int lastsnakenum = SnakeParent.transform.childCount - 1;
        int secondlastsnakenum = SnakeParent.transform.childCount - 2;
        
        GameObject lastsnake = SnakeParent.transform.GetChild(lastsnakenum).gameObject;


        

        if (amount == 2 && SnakeParent.transform.childCount > 1)
        {
            GameObject secondlastsnake = SnakeParent.transform.GetChild(secondlastsnakenum).gameObject;
            Destroy(secondlastsnake);
            CameraMovement.instance.Difference.z += 1;
            HealthManager.instance.health--;
        }
        Destroy(lastsnake);
        CameraMovement.instance.Difference.z += 1;
        HealthManager.instance.health -= 1;
    }



}
