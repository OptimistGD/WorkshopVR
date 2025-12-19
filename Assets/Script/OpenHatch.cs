using System;
using System.Collections;
using UnityEngine;

public class OpenHatch : MonoBehaviour
{
    private Vector3 closedPositionLeft;
    private Vector3 closedPositionRight;
    
    [SerializeField] private GameObject hatchLeft;
    [SerializeField] private GameObject hatchRight;
    
    [SerializeField] private Component leftOpen;
    [SerializeField] private Component rightOpen;

    public bool hatchIsOpen = false;

    
    
    private void Awake()
    {
        closedPositionLeft = hatchLeft.transform.localPosition;
        closedPositionRight = hatchRight.transform.localPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gift"))
        {
            StartCoroutine(hatchOpen());
        }
    }


    public IEnumerator hatchOpen(Collider other) 
    {
        float currentMovementTime = 0f;
        float totalMovementTime = 1f;

        Vector3 openPositionL = leftOpen.transform.position;
        Vector3 openPositionR = rightOpen.transform.position;
        
        while (Vector3.Distance(hatchLeft.transform.localPosition, openPositionL) > 0) 
        {
            currentMovementTime += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(hatchLeft.transform.localPosition, openPositionL, currentMovementTime / totalMovementTime);
            transform.localPosition = Vector3.Lerp(hatchRight.transform.localPosition, openPositionR, currentMovementTime / totalMovementTime);
            yield return new WaitForSeconds(1f);

            StartCoroutine(hatchClose());
        }
        
        if (other.CompareTag("Gift"))
        {
            Destroy(other);
        }
    }

    public IEnumerator hatchClose() 
    {
        float currentMovementTime = 0f;
        float totalMovementTime = 1f;
        
        while (Vector3.Distance(hatchLeft.transform.localPosition, closedPositionLeft) > 0) 
        {
            currentMovementTime += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(hatchLeft.transform.localPosition, closedPositionLeft, currentMovementTime / totalMovementTime);
            transform.localPosition = Vector3.Lerp(hatchRight.transform.localPosition, closedPositionRight, currentMovementTime / totalMovementTime);
            yield return null;
        }
    }
}