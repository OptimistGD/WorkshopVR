using UnityEngine;

public class SpawnerGifts : MonoBehaviour
{
    [SerializeField] private GameObject presentPrefab;

    public GameObject button;
    
    [SerializeField] 
    private Transform spawnPoint;

    public void Appear()
    {
        Instantiate(presentPrefab, spawnPoint.position, Quaternion.identity);
    }
}
