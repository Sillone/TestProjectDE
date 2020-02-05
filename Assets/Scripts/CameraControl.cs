using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject CameraHolder;
    public float sens = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            float x_axis = Input.GetTouch(0).deltaPosition.x * sens;
            float y_axis = Input.GetTouch(0).deltaPosition.y * sens;
            Vector3 delta = new Vector3(x_axis * Time.deltaTime, 0f, y_axis * Time.deltaTime);
            CameraHolder.transform.localPosition += delta;
        }
       
    }
}
