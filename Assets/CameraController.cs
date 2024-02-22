using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");


        transform.Translate(new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0f, 0f));
    }
}