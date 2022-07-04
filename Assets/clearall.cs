using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Destroy(gameObject);
        }
    }
}
