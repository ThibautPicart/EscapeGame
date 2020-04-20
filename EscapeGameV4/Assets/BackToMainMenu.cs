using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainMenu : MonoBehaviour
{
  
    void GoBackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
