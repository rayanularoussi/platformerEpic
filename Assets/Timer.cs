using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float totalTime = 360f;
    private float currentTime;
    public TMP_Text timerText;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        timerText.text = Mathf.FloorToInt(currentTime).ToString();
    }
}
