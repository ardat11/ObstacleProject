using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YenidenOyna : MonoBehaviour
{




    public void OnMouseDown()
    {
        Tekraroyna();
    }

    public void Tekraroyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
