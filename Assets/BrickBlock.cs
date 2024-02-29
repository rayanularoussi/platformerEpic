using UnityEngine;

public class BrickBlock : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mario"))
        {
            CountMoney.Instance.AddPoints();
            Destroy(gameObject);
        }
    }
}