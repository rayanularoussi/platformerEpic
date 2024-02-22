using UnityEngine;
using TMPro;

public class CountMoney : MonoBehaviour
{
    public static CountMoney Instance;

    public TMP_Text coinText;
    private int coinCount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        string coinString = "x" + coinCount.ToString("00");
        coinText.text = coinString;
    }
}