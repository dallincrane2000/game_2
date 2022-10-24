using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    [SerializeField] private FieldOfView fieldOfView;
    public Transform point;

    // Update is called once per frame
    void Update()
    {
        fieldOfView.SetOrigin(transform.position);
        //fieldOfView.SetRotation(transform.rotation.z);
        fieldOfView.SetAimDirection(point.position);
    }
}
