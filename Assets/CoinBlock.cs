using UnityEngine;

public class CoinBlock : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                CountMoney.Instance.AddCoin();
                Destroy(gameObject);
            }
        }
    }
}
