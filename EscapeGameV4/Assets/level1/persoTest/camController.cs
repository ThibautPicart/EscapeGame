using UnityEngine;

public class camController : MonoBehaviour
{
    public Transform perso;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public float rotationSensi = 0.125f;
    private Vector3 prevPos;

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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSensi, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotationSensi, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(rotationSensi, 0, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-rotationSensi, 0, 0);
        }

        deltaX = prevPos.x - Input.mousePosition.x;
        deltaY = prevPos.y - Input.mousePosition.y;

        if(Input.GetMouseButton(1))
        {
            transform.Rotate(deltaY*rotationSensi, -deltaX*rotationSensi, 0);
        }


        prevPos = Input.mousePosition;

    }
}
