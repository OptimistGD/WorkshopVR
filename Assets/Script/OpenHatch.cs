using UnityEngine;

public class OpenHatch : MonoBehaviour
{
    private GameObject Hatch;
    private GameObject HatchOpen;
    private GameObject HatchClose;

    public bool hatchIsOpen = false;
    public int moveSpeed = 3;

    public GameObject button;

    public void Start()
    {
        HatchClose = Instantiate(Hatch, Hatch.transform.position, Hatch.transform.rotation);
        HatchClose.SetActive(false);
        HatchOpen.SetActive(false);
    }

    public void Update()
    {
        var target = hatchIsOpen ? HatchOpen : HatchClose;
        Hatch.transform.position = Vector3.MoveTowards(Hatch.transform.position, target.transform.position, moveSpeed * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider present)
    {
        hatchIsOpen = true;
    }
    
    void OnTriggerExit(Collider cube)
    {
        hatchIsOpen = false;
        //ici sera le code du destroy des gifts
    }

    public static void Open()
    {
        
    }
    
    
}