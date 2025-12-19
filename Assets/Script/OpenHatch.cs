using System;
using System.Collections;
using UnityEngine;

public class OpenHatch : MonoBehaviour
{
    private Vector3 closedPositionLeft;
    private Vector3 closedPositionRight;

    [SerializeField] private Collider giftCollider;
    
    [SerializeField] private GameObject hatchLeft;
    [SerializeField] private GameObject hatchRight;
    
    [SerializeField] private Component leftOpen;
    [SerializeField] private Component rightOpen;

    public bool hatchIsOpen = false;
    
    public static OpenHatch instance;

    
    
    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
        
        closedPositionLeft = hatchLeft.transform.localPosition;
        closedPositionRight = hatchRight.transform.localPosition;
    }

    private void OnTriggerEnter(Collider giftCollider)
    {
        if (giftCollider.CompareTag("Gift"))
        {
            StartCoroutine(hatchOpen());
        }
    }


    public IEnumerator hatchOpen() 
    {
        float currentMovementTime = 0f;
        float totalMovementTime = 1f;

        Vector3 openPositionL = leftOpen.transform.localPosition;
        Vector3 openPositionR = rightOpen.transform.localPosition;
        
        while (Vector3.Distance(hatchLeft.transform.localPosition, openPositionL) > 0) 
        {
            currentMovementTime += Time.deltaTime;
            hatchLeft.transform.localPosition = Vector3.Lerp(closedPositionLeft, openPositionL, currentMovementTime / totalMovementTime);
            hatchRight.transform.localPosition = Vector3.Lerp(closedPositionRight, openPositionR, currentMovementTime / totalMovementTime);
            yield return null;
        }
    }

    public IEnumerator hatchClose() 
    {
        float currentMovementTime = 0f;
        float totalMovementTime = 1f;
        Awaitable.WaitForSecondsAsync(1);
        while (Vector3.Distance(hatchLeft.transform.localPosition, closedPositionLeft) > 0) 
        {
            Debug.Log("while");
            currentMovementTime += Time.deltaTime;
            hatchLeft.transform.localPosition = Vector3.Lerp(leftOpen.transform.localPosition, closedPositionLeft, currentMovementTime / totalMovementTime);
            hatchRight.transform.localPosition = Vector3.Lerp(rightOpen.transform.localPosition, closedPositionRight, currentMovementTime / totalMovementTime);
            yield return null;
        }
        Debug.Log("Close Hatch");
    }
}