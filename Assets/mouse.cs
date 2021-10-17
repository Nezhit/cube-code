using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour
{

    public double dx;
    public double dy;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y"), Space.World);
            transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"), Space.World);
        }
    }

}