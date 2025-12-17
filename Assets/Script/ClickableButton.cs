using UnityEngine;

public class ClickableButton : MonoBehaviour
{
    [SerializeField] 
    private GameObject cylinderPrefab;

    [SerializeField]
    private Spawner spawner;
    
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Is clicked");
            spawner.Spawn();
        }
    }
}
