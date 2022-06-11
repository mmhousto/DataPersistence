using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{

    /// <summary>
    /// Saves the player's data to a file in binary by serialization.
    /// </summary>
    /// <param name="player"></param>
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerData.hax";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    /// <summary>
    /// Loads the player's data after deserializing it and returns it.
    /// </summary>
    /// <returns></returns>
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/playerData.hax";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Save file not found in " + path);
            PlayerData data = new PlayerData();
            return data;
        }
    }
}
