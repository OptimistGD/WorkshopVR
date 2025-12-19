using UnityEngine;

public class Clamp : MonoBehaviour
{
    [SerializeField] private GameObject self;

    private Vector3 position; 
    // Update is called once per frame
    void Update()
    {
        position = new Vector3(self.transform.position.x, self.transform.position.y, self.transform.position.z);
        
    }
}
