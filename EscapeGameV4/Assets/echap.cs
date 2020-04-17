using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class echap : MonoBehaviour
{
    public GameObject pausePanel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            pausePanel.SetActive(true);
        }
    }
}
