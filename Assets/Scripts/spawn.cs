using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] material;
    public GameObject[] clones;
    int x = 0;
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) { x = 0; }
        if (Input.GetKey(KeyCode.Alpha2)) { x = 1; }
        if (Input.GetKey(KeyCode.Alpha3)) { x = 2; }
        
        // to spawn the object
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 mpos = Input.mousePosition;
            mpos.z = 6f;         
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(mpos);

            //snapping
            worldPoint.x = Mathf.Round(worldPoint.x / 4) * 4;
            worldPoint.y = Mathf.Round(worldPoint.y);
            worldPoint.z = Mathf.Round(worldPoint.z / 4) * 4;

            Instantiate(material[x], worldPoint, Quaternion.identity); //Camera.main.transform.rotation);

        }

        // to desroy any of the objects
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Vector3 mpos2 = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100f));
            Vector3 dir = mpos2 - Camera.main.transform.position;

            RaycastHit hit;

            clones = GameObject.FindGameObjectsWithTag("Wood");

            if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100f))
            {
                foreach (GameObject clone in clones)
                {
                    if (hit.collider.gameObject == clone) { Destroy(hit.collider.gameObject); }
                }
            }
        }
    }
}
