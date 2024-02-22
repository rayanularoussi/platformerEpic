using UnityEngine;

public class OnPointDestroy : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject || hit.collider.gameObject.transform.IsChildOf(transform))
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
