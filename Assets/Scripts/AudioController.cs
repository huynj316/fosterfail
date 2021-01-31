using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public Dropdown audioDropdown;

    //Use these for adding options to the Dropdown List
    Dropdown.OptionData m_NewData, m_NewData2;
    //The list of messages for the Dropdown
    List<Dropdown.OptionData> m_Messages = new List<Dropdown.OptionData>();

    //This is the Dropdown
    Dropdown m_Dropdown;
    string m_MyString;
    int m_Index;

    public List<AudioClip> audioClips = new List<AudioClip>();

    // Start is called before the first frame update
    void Start()
    {

        //audioFiles = getAudioFiles();
        //char[] delimiterChars = { '/', '\\' };
        //pickAudio.options.Clear();
        //foreach (string c in audioFiles)
        //{
        //    pickAudio.options.Add(new Dropdown.OptionData() { text = System.IO.Path.GetFileName(c) });
        //}
        //private string[] getAudioFiles()
        //{
        //    string path = Application.dataPath + "/Resources/Audiofiles";
        //    string[] filePaths = Directory.GetFiles(@path, "*.ogg");
        //    foreach (string file in filePaths)
        //    {
        //        // Debug.Log(file);
        //    }
        //    return filePaths;
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
