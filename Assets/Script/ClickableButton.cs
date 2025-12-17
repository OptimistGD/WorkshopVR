using UnityEngine;

public class ClickableButton : MonoBehaviour
{
    [SerializeField] 
    private GameObject cylinderPrefab;

    [SerializeField]
    private Spawner spawner;
    
    

    public void Interact()
    {
        Debug.Log("Is clicked");
        spawner.Spawn();
    }
}
