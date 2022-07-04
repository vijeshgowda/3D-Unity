using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Vector3 snap(Vector3 pos, int v)
    {
        float x = pos.x;
        float y = pos.y;
        float z = pos.z;
        x = Mathf.FloorToInt(x / v) * v;
        y = Mathf.FloorToInt(y / v) * v;
        z = Mathf.FloorToInt(z / v) * v;
        return new Vector3(x, y, z);
    }

    //public static int snap(int pos, int v)
    //{
    //    float x = pos;
    //    return Mathf.FloorToInt(x / v) * v;
    //}

    //public static float snap(float pos, float v)
    //{
    //    float x = pos;
    //    return Mathf.FloorToInt(x / v) * v;
    //}
}
