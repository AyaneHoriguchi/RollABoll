using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject followTarget;
    public Vector3 OffSet;
    private void LateUpdate()
    {
        transform.position = followTarget.transform.position + OffSet;
        transform.LookAt(followTarget.transform);

    }

}
