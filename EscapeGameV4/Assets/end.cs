using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject escalier;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("LevelFinished") == 1 && Vector3.Distance(player.transform.position, escalier.transform.position) < 2)
        {
            endPanel.SetActive(true);
        }
    }
}
