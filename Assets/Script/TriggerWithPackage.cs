using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerWithPackage : MonoBehaviour
{
    bool order;
    Vector2 pos;
    public spawnOrder spawnOrder;
    [SerializeField] private float destroyDelay = 0.14f;
    static string[][] Customers = new string[][] {new string[] {"CustomerCharecter2"}, new string[] {"CustomerCharacter_0"}, new string[] {"customerCharacter3_0"}};
    public string[] selCus;


    private void OnTriggerEnter2D(Collider2D other) { 
        AudioSource audio = GameObject.Find("PickupAudio").GetComponent<AudioSource>();
        AudioSource audio2 = GameObject.Find("OrderDelivered").GetComponent<AudioSource>();
        if(other.CompareTag("IcecreamOrder") && !order){
            Destroy(other.gameObject, destroyDelay);
            GetComponent<ParticleSystem>().Play();
            audio.Play();
            order = true;
            pos = other.transform.position;
            OrderLeftShifter(spawnOrder.Positions, pos, spawnOrder.noAvailablePos);
            SelectCustomer();
        }
        if(order && other.gameObject.name.Contains(selCus[0])){
            Debug.Log("Package delivered!");
            ++spawnOrder.noAvailablePos;
            Debug.Log("Talking from Trigger: "+ spawnOrder.noAvailablePos);
            GetComponent<ParticleSystem>().Stop();
            audio2.Play();
            order = false;
        }
    }

    void OrderLeftShifter(float[][] array, Vector2 coordinate, int ind)
    {
        int intIndex=-1; //initial index
        for(int i = ind; i < array.Length; i++){ //serach the coordinate in the array and then return the index
            float epsilon = 0.0001f;
            if (Mathf.Abs(array[i][0] - coordinate.x) < epsilon &&
                Mathf.Abs(array[i][1] - coordinate.y) < epsilon)
            {
                intIndex = i;
                break;
            }
        }

        if(intIndex>=0){ //if the coordinate is found and is not the first element, then shift the elements to the left and insert the found element at the end of the array
            float[] temp = array[intIndex];
            for(int i =intIndex; i > ind; i--){
                array[i] = array[i-1];
            }
            array[ind] = temp;
        }

    }

    public void SelectCustomer(){
        int selInd;
        selInd =  UnityEngine.Random.Range(0, 3); //select random valid index
        selCus = Customers[selInd]; //insert element of the index
        Debug.Log("Selected Customer: "+selCus[0]);
    }
}