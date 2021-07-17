using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class StartMenuManager : MonoBehaviour
{


    void Update()
    {

        if (Input.anyKey)
        {

            SceneManager.LoadScene("menu");


        }
    }
}
