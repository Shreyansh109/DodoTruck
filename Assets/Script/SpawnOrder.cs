using UnityEngine;

public class SpawnOrder : MonoBehaviour
{

    static float[][] Positions = new float[][] {new float[] {19.703f,20.116f}, new float[] {-27.62f,-20.47f}, new float[] {-27.45f,18.002f}, new float[] {-48.43f,36.289f}, new float[] {1.358f,35.54f}};
    
    public static int noAvailablePos = 5; //number of available positions

    public GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        SpawnOject(3);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(noAvailablePos > 2){
            Debug.Log("Available Pos: "+noAvailablePos);
            SpawnOject(noAvailablePos-2);
        }
        
    }

    public void SpawnOject(int noObjToPlace){
        
        
        // int[][] selectedPositions = new int[5][];
        int selInd;
        float[] selPos;
        if (noObjToPlace <= noAvailablePos){
            for(int i = 0; i < noObjToPlace; i++){
                selInd =  UnityEngine.Random.Range(0, noAvailablePos); //select random valid index
                selPos = Positions[selInd]; //insert element of the index
                
                Vector2 spawnPosition = new Vector2(selPos[0], selPos[1]); // your desired position
                Instantiate(prefab, spawnPosition, Quaternion.identity);
                
                Shifter(selInd, Positions);
                noAvailablePos--;
            }
        }else{
            SpawnOject(--noObjToPlace);
        }
        
    }

    private static void Shifter(int desPos, float[][] array){
        float[] temp1 = array[desPos];
        for(int i = desPos; i < array.Length-1; i++){
            array[i] = array[i+1];
        }
        array[array.Length-1] = temp1;
    }
}
