using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class PlayerController : MonoBehaviour
{
    public PlayerData playerData;
    [ContextMenu("To Json Data")]
    void SavePlayerDataToJson()
    {
        string jsonData = JsonUtility.ToJson(playerData,true); //true�� ����� �б����Ը���.
        string path = Path.Combine(Application.dataPath + "/playerData.json");
        File.WriteAllText(path, jsonData);
    }
}

[System.Serializable]
public class PlayerData
{
    public int rank;
    public float score;
    public int date;
}
