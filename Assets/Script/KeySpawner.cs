using UnityEngine;
using UnityEngine.UI;

public class KeySpawner : MonoBehaviour
{
    public float[][] Positions = new float[][] {new float[] {19.703f,20.116f}, new float[] {-27.62f,-20.47f}, new float[] {-27.45f,18.002f}, new float[] {-48.43f,36.289f}, new float[] {1.358f,35.54f}, new float[] {-56.1f,-0.692f}};
    public GameObject keyPrefab;
    public Image inGameDetailsCanvasPanel;
    bool keyCollected = false;

    public void PositionPicker()
    {
        if(keyCollected) return;
        int selInd =  UnityEngine.Random.Range(0, Positions.Length); //select random valid index
        float[] selPos = Positions[selInd]; //insert element of the index
        Vector2 spawnPosition = new Vector2(selPos[0], selPos[1]); // your desired position
        Instantiate(keyPrefab, spawnPosition, Quaternion.identity);
    }

    public void KeyCollected()
    {
        keyCollected = true;
        inGameDetailsCanvasPanel.color = new Color32(255, 215, 0, 148);
        print("Key Collected!");
    }
}
