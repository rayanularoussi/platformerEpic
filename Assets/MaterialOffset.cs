using UnityEngine;

public class MaterialOffset : MonoBehaviour
{
    public float cooldownTime = 0.1f; 
    private float cooldownTimer = 0f;
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (renderer != null && renderer.material != null && renderer.material.mainTexture != null)
        {
            if (cooldownTimer <= 0)
            {
                Vector2 offset = renderer.material.mainTextureOffset;
                offset.y += 0.2f;
                renderer.material.mainTextureOffset = offset;
                cooldownTimer = cooldownTime;
            }
            else
            {
                cooldownTimer -= Time.deltaTime;
            }
        }
    }
}