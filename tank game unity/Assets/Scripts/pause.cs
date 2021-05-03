using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class pause : MonoBehaviour
{
 

   public void pauseScene()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Pause");
    }

}
