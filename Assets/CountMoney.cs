using UnityEngine;
using TMPro;

public class CountMoney : MonoBehaviour
{
    public static CountMoney Instance;

    public TMP_Text coinText;
    public TMP_Text pointsText;
    private int coinCount = 0;
    private int pointsCount = 0;

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

    public void AddPoints()
    {
        pointsCount += 100;
        UpdatePointText();
    }

    private void UpdateCoinText()
    {
        string coinString = "x" + coinCount.ToString("00");
        coinText.text = coinString;
    }

    private void UpdatePointText()
    {
        string pointString = "MARIO\n" + pointsCount.ToString("000000");
        pointsText.text = pointString;
    }
}