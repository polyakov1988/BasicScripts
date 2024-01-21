using UnityEngine;

public class AllMovementCubeMovement : MonoBehaviour
{
    private readonly float _rotationSpeed = 100f;
    private readonly float _moveForwardSpeed = 2f;
    private readonly float _scaleSpeed = 0.05f;
    
    // Update is called once per frame
    private void Update()
    {
        MoveForward();
        Rotate();
        Scale();
    }

    private void MoveForward()
    {
        transform.Translate(new Vector3(_moveForwardSpeed * Time.deltaTime, 0));
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * (_rotationSpeed * Time.deltaTime));
    }

    private void Scale()
    {
        var scale = _scaleSpeed * Time.deltaTime;
        
        transform.localScale += new Vector3(scale, scale, scale);
    }
}
