using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class AudioController : MonoBehaviour
{
    public Dropdown audioDropdown;
    public AudioSource audioSource;

    public List<AudioClip> audioClips = new List<AudioClip>();
    public string myPath;

    // Start is called before the first frame update
    void Start()
    {

        Object[] audioClipFiles = Resources.LoadAll("Audio/Dog", typeof(AudioClip));


        foreach (var a in audioClipFiles)
        {
            Debug.Log(a.name);
        }

        for (int i = 0; i < audioClipFiles.Length; i++)
        {
            audioClips.Add(audioClipFiles[i] as AudioClip);

        }

        PopulateDropdown(audioDropdown, audioClipFiles);

        audioDropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(audioDropdown);
        });
    }

    void PopulateDropdown(Dropdown dropdown, Object[] optionsArray)
    {
        List<string> options = new List<string>();
        foreach (var option in optionsArray)
        {
            options.Add(option.name); 
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(options);


    }

    void DropdownValueChanged(Dropdown aDropdown)
    {
        string changedValue = aDropdown.value.ToString();

        Debug.Log("changed " + changedValue);

        Debug.Log("option " + aDropdown.options[aDropdown.value].text);

        string clipName = aDropdown.options[aDropdown.value].text;

        for (int i = 0; i < audioClips.Count; i++)
        {
            if (clipName == audioClips[i].name)
                audioSource.PlayOneShot(audioClips[i]);
        }
    }
}
