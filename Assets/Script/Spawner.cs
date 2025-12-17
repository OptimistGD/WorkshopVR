using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject cylinderPrefab1, cylinderPrefab2, cylinderPrefab3;
    public GameObject button;
    
    [SerializeField] private Transform spawnPoint1;
    [SerializeField] private Transform spawnPoint2;
    [SerializeField] private Transform spawnPoint3;
    
    
    public void Spawn()
    {
        Instantiate(cylinderPrefab1, spawnPoint1.position, Quaternion.identity);
        Instantiate(cylinderPrefab2, spawnPoint2.position, Quaternion.identity);
        Instantiate(cylinderPrefab3, spawnPoint3.position, Quaternion.identity);
    }
}
