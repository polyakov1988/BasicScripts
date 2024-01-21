using UnityEngine;

public class CubeRotationMovement : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    
    private void Update()
    {
        transform.Rotate(Vector3.up * (_rotationSpeed * Time.deltaTime));
    }
}
