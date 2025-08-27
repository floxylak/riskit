using UnityEngine;

public class WheelSpin : MonoBehaviour
{
    public float speed = 300f; // degrees per second

    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
