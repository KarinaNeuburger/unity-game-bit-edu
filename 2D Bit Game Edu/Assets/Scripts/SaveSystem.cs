using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public static class SaveSystem
{
    public static void SaveProgress()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.bit";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerProgress progress = new PlayerProgress();
        formatter.Serialize(stream, progress);
        stream.Close();
    }

    public static PlayerProgress LoadProgress()
    {
        string path = Application.persistentDataPath + "/player.bit";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerProgress progress = formatter.Deserialize(stream) as PlayerProgress;
            stream.Close();

            return progress;
        }
        else
        {
            SceneManager.LoadScene("Dialog");
            return null;
        }
    }
}
