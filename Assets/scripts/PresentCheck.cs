using System;
using UnityEngine;

public class PresentCheck : MonoBehaviour
{
    [SerializeField] private GameObject lidPresent; 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        
        if (other.CompareTag("Toys"))
            ClosePresent();
    }

    private void ClosePresent()
    {
        lidPresent.SetActive(true);
    }
}
