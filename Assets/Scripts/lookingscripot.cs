using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookingscripot : MonoBehaviour
{
    public float mS = 1000f;
    public Transform playerbody;

    float xR = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Mouse X") * mS * Time.deltaTime;
        float mY = Input.GetAxis("Mouse Y") * mS * Time.deltaTime;

        xR -= mY;
        xR = Mathf.Clamp(xR, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xR, 0f, 0f);

        playerbody.Rotate(Vector3.up * mX);
    }
}
