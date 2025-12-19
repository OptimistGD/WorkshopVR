using System;
using UnityEngine;

public class closegift : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gift")
            other.gameObject.GetComponentInParent<PresentCheck>().ClosePresent();
    }
}
