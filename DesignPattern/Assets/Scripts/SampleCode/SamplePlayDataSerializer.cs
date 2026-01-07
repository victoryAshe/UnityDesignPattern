using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SamplePlayDataSerializer
{
    public struct PlayerData
    {
        //dummy
    }

    private void SerializePlayerData(PlayerData playerData)
    {
        // PlayerData Instance Serialize (Á÷·ÄÈ­)
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerData.dat");
        bf.Serialize(file, playerData);
        file.Close();
    }
}
