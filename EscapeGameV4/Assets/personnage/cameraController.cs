using System.Media;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform perso;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public float rotationSensi = 0.125f;
    private Vector3 prevPos;
    private Vector3 rotation;

    private float deltaX;
    private float deltaY;
    private float y;


    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 1.5f, 0);
        PlayerPrefs.SetInt("isDigging", 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = perso.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

    }

    void Update()
    {
       
        

        if (Input.GetMouseButton(1) && PlayerPrefs.GetInt("isDigging") == 0)
        {
            deltaX = prevPos.x - Input.mousePosition.x;
            deltaY = prevPos.y - Input.mousePosition.y;
            transform.Rotate(deltaY * rotationSensi, -deltaX * rotationSensi, 0, Space.Self);
            rotation = transform.eulerAngles;
            rotation.z = 0;
            transform.eulerAngles = rotation;
            y = perso.eulerAngles.y + 0.5f;

        }

        if(PlayerPrefs.GetInt("isDigging") == 1)
        {
            rotation = transform.eulerAngles;
            rotation.x = 20;
            rotation.y = y;
            transform.eulerAngles = rotation;
        }


        prevPos = Input.mousePosition;

    }
}
