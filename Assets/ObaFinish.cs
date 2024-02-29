using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObaFinish : MonoBehaviour
{
    public GameObject menuPrefab;
    public string canvasTag = "Canvas";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mario"))
        {
            if (menuPrefab != null)
            {
                GameObject canvas = GameObject.FindGameObjectWithTag(canvasTag);
                
                if (canvas != null)
                {
                    GameObject menuInstance = Instantiate(menuPrefab, canvas.transform);
                    Destroy(gameObject, 5f);
                }
                else
                {
                    Debug.LogError("Canvas object not found in the scene!");
                }
            }
            else
            {
                Debug.LogError("Menu prefab is not assigned!");
            }
            Destroy(gameObject);
        }
    }
}
