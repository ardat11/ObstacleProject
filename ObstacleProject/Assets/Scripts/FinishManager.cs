using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FinishManager : MonoBehaviour
{

    [SerializeField] private GameObject WinPanel;
    [SerializeField] private TMP_Text Skor;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FinishLine"))
        {
            Destroy(gameObject);
            WinPanel.SetActive(true);
            Skor.text = "Skor: " + HealthManager.instance.health;


        }

    }
}
