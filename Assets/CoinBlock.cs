using UnityEngine;

public class CoinBlock : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mario"))
        {
            CountMoney.Instance.AddCoin();
            CountMoney.Instance.AddPoints();
            Destroy(gameObject);
        }
    }
}