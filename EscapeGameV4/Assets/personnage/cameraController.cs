using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public Transform player;
    public Transform repereCamera;
    private Vector3 offset;

    void Start()
    {
        offset = player.localPosition - repereCamera.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 reperePosition = player.localPosition - offset;
        repereCamera.localPosition = reperePosition;
    }
}
