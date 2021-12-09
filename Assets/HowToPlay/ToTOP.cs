using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTOP : MonoBehaviour
{

    public void OnStart()
    {
        SceneManager.LoadScene("Menu");
    }
}
