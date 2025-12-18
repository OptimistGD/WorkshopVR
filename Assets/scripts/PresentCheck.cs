using System;
using UnityEngine;

public class PresentCheck : MonoBehaviour
{
    [SerializeField] private GameObject lidPresent; 

    public void ClosePresent()
    {
        lidPresent.SetActive(true);
    }
}
