using System;
using UnityEngine;
using TMPro;
public class ColliderAccept : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    
    public int score = 0;

    private void Start()
    {
        UpdateScoreUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gift"))
        {
            score++;
            UpdateScoreUI();
            Destroy(other.gameObject);
        }
    }

    void UpdateScoreUI()
    {
        text.text = " : " + score;
    }
}
