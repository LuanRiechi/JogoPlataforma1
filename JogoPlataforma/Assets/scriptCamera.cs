using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public GameObject megamen;
    public float offSetY;
    // Start is called before the first frame update
    void Start()
    {
        offSetY = 1;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(megamen.transform.position.x,
                                       megamen.transform.position.y+offSetY,
                                       -10);
        transform.position = position;
    }
}
