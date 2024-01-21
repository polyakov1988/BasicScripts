using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(new Vector3(Time.deltaTime, 0));
    }
}
