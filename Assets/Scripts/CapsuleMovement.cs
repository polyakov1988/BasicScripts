using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        var scale = _scaleSpeed * Time.deltaTime;
        
        transform.localScale += new Vector3(scale, scale, scale);
    }
}
