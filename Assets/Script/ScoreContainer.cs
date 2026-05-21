using UnityEngine;

[CreateAssetMenu(fileName = "ScoreContainer", menuName = "Scriptable Objects/ScoreContainer")]
public class ScoreContainer : ScriptableObject
{
    public int PackageDelivered = 0;
    public Sprite truckImage;
    public string selectedCarName = "Car1";
}
