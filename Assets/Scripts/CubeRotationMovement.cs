using UnityEngine;

public class CubeRotationMovement : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    
    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(Vector3.up * (_rotationSpeed * Time.deltaTime));
    }
}
