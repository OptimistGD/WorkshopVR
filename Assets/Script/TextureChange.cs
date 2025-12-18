using UnityEngine;

public class TextureChange : MonoBehaviour
{
    private Texture[] textures;
    private MeshRenderer meshRenderer;

    //singleton
    public static TextureChange instance;
    
    public void Awake()
    {
        //singleton
        if (instance != null)
            Destroy(this);
        instance = this;
        
        textures = Resources.LoadAll<Texture>("GiftMaterials");
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public Texture ChooseTexture()
    {
        // var = stockage des infos avant création
        var randomNumber = Random.Range(0, textures.Length);
        return textures[randomNumber];
    }
    
}

