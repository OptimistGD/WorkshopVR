using UnityEngine;
using UnityEngine.Serialization;

public class ClickableButtonHatch : MonoBehaviour
{
    [SerializeField] public GameObject hatch;
    
    //public void Interact()
    
    public void Start()
    {
        Debug.Log("la trappe s'ouvre");
        OpenHatch.Open();
    }
    
}
