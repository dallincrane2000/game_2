using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] private FieldOfView fieldOfView;
    public Transform point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        fieldOfView.SetOrigin(transform.position);
        //fieldOfView.SetRotation(transform.rotation.z);
        fieldOfView.SetAimDirection(point.position);
    }
}
