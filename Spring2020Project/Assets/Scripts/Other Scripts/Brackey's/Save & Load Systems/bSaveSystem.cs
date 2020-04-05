using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Debug = System.Diagnostics.Debug;

public static class bSaveSystem
{
    public static void SavePlayer(bPlayer player)
    {
        //The Formatter for Binary Conversion
        BinaryFormatter formatter = new BinaryFormatter();

        //The Save Method and Path
        string savePath = Application.persistentDataPath + "/playerSave.sav";
        FileStream stream = new FileStream(savePath, FileMode.Create);
        
        //The Data We're Saving
        bPlayerData data = new bPlayerData(player);
        
        //Writes the Data to the Path
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static bPlayerData LoadPlayer()
    {
        string savePath = Application.persistentDataPath + "/playerSave.sav";

        if (File.Exists(savePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(savePath, FileMode.Open);

            bPlayerData data = formatter.Deserialize(stream) as bPlayerData;
            stream.Close();
            
            return data;
        }
        else
        {
            UnityEngine.Debug.LogError("Player save file not found in " + savePath);
            return null;
        }
    }
    
}
