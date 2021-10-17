using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 10;
    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(new  Vector3(h, 0, v));

    }
}
