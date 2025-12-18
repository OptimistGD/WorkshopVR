using UnityEngine;

public class ClickableButtonGift : MonoBehaviour
{
    [SerializeField]
    private SpawnerGifts spawnerGifts;
    
    public void Interact()
    {
            Debug.Log("Is clicked");
            spawnerGifts.Appear();
    }
}
