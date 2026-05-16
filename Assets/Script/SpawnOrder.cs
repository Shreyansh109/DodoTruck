using UnityEngine;
using UnityEngine.Rendering.Universal;

public class spawnOrder : MonoBehaviour
{

    public float[][] Positions = new float[][] {new float[] {19.703f,20.116f}, new float[] {-27.62f,-20.47f}, new float[] {-27.45f,18.002f}, new float[] {-48.43f,36.289f}, new float[] {1.358f,35.54f}, new float[] {-56.1f,-0.692f}};
    float[] selPos;
    public int noAvailablePos = 6; //number of available positions

    public GameObject prefab;


    void Update()
    {
        if(noAvailablePos > 3){
            SpawnOject(noAvailablePos-3);
        }
        
    }

    public void SpawnOject(int noObjToPlace){
        
        int selInd;
        
        if (noObjToPlace <= noAvailablePos){
            for(int i = 0; i < noObjToPlace; i++){
                selInd =  UnityEngine.Random.Range(0, noAvailablePos); //select random valid index
                selPos = Positions[selInd]; //insert element of the index
                
                Vector2 spawnPosition = new Vector2(selPos[0], selPos[1]); // your desired position
                Instantiate(prefab, spawnPosition, Quaternion.identity);
                
                Shifter(selInd, Positions);
                --noAvailablePos;
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
