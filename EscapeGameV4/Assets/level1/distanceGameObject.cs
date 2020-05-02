using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceGameObject : MonoBehaviour
{
    public GameObject objet1;
    public GameObject objet2;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(objet1.transform.position, objet2.transform.position);
    }
}
