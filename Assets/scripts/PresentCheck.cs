using System;
using UnityEngine;

public class PresentCheck : MonoBehaviour
{
    [SerializeField] private GameObject lidPresent;

    private GameObject toy1;
    private GameObject toy2;
    private GameObject toy3;

    public void ClosePresent()
    {
        lidPresent.SetActive(true);
        
    }
}
