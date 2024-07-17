using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldMoveScript : MonoBehaviour
{
    float speed = 5;

    void Start()
    {
        Destroy(this.gameObject, 10);
    }
    void Update()
    {
        this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

}
