using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float totalTime = 100f;
    private float currentTime;
    public TMP_Text timerText;
    public GameObject timesOutUI;
    public string canvasTag = "Canvas";

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
            GameObject canvas = GameObject.FindGameObjectWithTag(canvasTag);
            if (canvas != null)
            {
                GameObject menuInstance = Instantiate(timesOutUI, canvas.transform);
            }
            else
            {
                Debug.LogError("Canvas object not found in the scene!");
            }
        }

        timerText.text = Mathf.FloorToInt(currentTime).ToString();
    }
}