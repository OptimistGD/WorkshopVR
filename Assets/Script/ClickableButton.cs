using UnityEngine;

public class ClickableButton : MonoBehaviour
{
    [SerializeField]
    private SpawnerToys spawnerToys;
    
    public void Interact()
    {
        Debug.Log("Is clicked");
        spawnerToys.Spawn();
        
    }
}
