using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public static HealthManager instance;


    public int health;
    [SerializeField] private GameObject LosePanel;

    private void Awake()
    {
        instance = this;
    }



    private void Update()
    {
        if(health <= 0)
        {
            LosePanel.SetActive(true);


        }

        



    }











}
