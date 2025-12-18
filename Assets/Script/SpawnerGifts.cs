using UnityEngine;

public class SpawnerGifts : MonoBehaviour
{
    [SerializeField] private GameObject presentPrefab;

    public GameObject button;
    
    [SerializeField] 
    private Transform spawnPoint;
    
    public void Appear()
    {
        GameObject instance = Instantiate(presentPrefab, spawnPoint.position, Quaternion.identity);
        Texture textures = TextureChange.instance.ChooseTexture();

        instance.GetComponentInChildren<MeshRenderer>().material.mainTexture =  textures;
    }
}
