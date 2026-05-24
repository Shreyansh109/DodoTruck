using UnityEngine;
using UnityEngine.UI;

public class KeySpawner : MonoBehaviour
{
    public float[][] Positions = new float[][] {new float[] {20.4272f,52.75922f}, new float[] {-14.27048f,27.52073f}, new float[] {-40.65327f,30.82953f}, new float[] {-16.69543f,-13.18886f}};
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
