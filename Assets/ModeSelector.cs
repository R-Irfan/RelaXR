using System.Collections;
using UnityEngine;

public class ModeSelector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    GameObject MrObjects, mrButton, VRButton, blendedButton;


    [SerializeField]
    GameObject VRObjects;

    [SerializeField]
    GameObject BlendObjects, bowlObject;

    [SerializeField]
    AudioSource sound;

    [SerializeField]
    AudioClip clip, bowlCLip;

    [SerializeField]
    GameObject MenuObject;

    bool isBowlPlaying = false;

    void Start()
    {
        VRObjects.SetActive(false);
        MrObjects.SetActive(false);
        BlendObjects.SetActive(false);
        bowlObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EnableMRMode() 
    {
        Debug.Log("ENabled MR Objects");
        VRObjects.SetActive(false);
        MrObjects.SetActive(true);
        BlendObjects.SetActive(false);
        sound.PlayOneShot(clip);
        //MenuObject.SetActive(false);
        bowlObject.SetActive(true);
        blendedButton.SetActive(false);
        VRButton.SetActive(false);
        mrButton.SetActive(false);

    }

    public void EnableVRMode()
    {
        Debug.Log("ENabled VR Objects");
        VRObjects.SetActive(true );
        MrObjects.SetActive(false);
        BlendObjects.SetActive(false);
        sound.PlayOneShot(clip);
       // MenuObject.SetActive(false);
        bowlObject.SetActive(true);
        blendedButton.SetActive(false);
        VRButton.SetActive(false);
        mrButton.SetActive(false);
    }

    public void EnableMixedMode()
    {
        Debug.Log("ENabled Mixed Objects");
        VRObjects.SetActive(false);
        MrObjects.SetActive(false);
        BlendObjects.SetActive(true);
        sound.PlayOneShot(clip);
        //MenuObject.SetActive(false);
        bowlObject.SetActive(true);
        blendedButton.SetActive(false);
        VRButton.SetActive(false);
        mrButton.SetActive(false);
    }

    public void bowl() 
    {
        
            sound.PlayOneShot(bowlCLip);
           
        
    }

   
}

