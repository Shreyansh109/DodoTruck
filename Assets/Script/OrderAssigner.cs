using UnityEngine;

public class OrderAssigner : MonoBehaviour
{

    static string[][] Customers = new string[][] {new string[] {"CustomerCharecter2"}, new string[] {"CustomerCharacter_0"}, new string[] {"customerCharacter3_0"}};
    public string[] selCus;
    public bool orderAssigned = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("IcecreamOrder")){
            SelectCustomer();
        }
    }

    public void SelectCustomer(){
        int selInd;
        selInd =  UnityEngine.Random.Range(0, 3); //select random valid index
        selCus = Customers[selInd]; //insert element of the index
        orderAssigned = true;
        
    }
}
