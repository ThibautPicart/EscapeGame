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


    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 1.5f, 0);
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
       
        

        if (Input.GetMouseButton(1))
        {
            deltaX = prevPos.x - Input.mousePosition.x;
            deltaY = prevPos.y - Input.mousePosition.y;
            transform.Rotate(deltaY * rotationSensi, -deltaX * rotationSensi, 0, Space.World);
            rotation = transform.eulerAngles;
            rotation.z = 0;
            transform.eulerAngles = rotation;

        }


        prevPos = Input.mousePosition;

    }
}
