using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = playerTransform.position.x + 2f;
        var y = playerTransform.position.y + 3f;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
