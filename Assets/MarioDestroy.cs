using UnityEngine;

public class MarioDestroy : MonoBehaviour
{
    public float raycastLength = 0.5f;
    public LayerMask brickLayer;

    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastLength, brickLayer);

        if (hit.collider != null)
        {
  
            if (hit.collider.CompareTag("Brick"))
            {
                Destroy(hit.collider.gameObject);
                
            }
        }
    }
}