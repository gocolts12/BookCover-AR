using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_CharacterScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBTobject;
    public GameObject Car;
    //public Animator CarAni;
    public AudioSource audioCCP;

    //what ever stuff you put  
    // Start is called before the first frame update
    void Start()
    {
        //this is where you would initalize the objects like the 3d model and audio clip
        vbBTobject = GameObject.Find("Button1");
        Car = GameObject.Find("Avatar");
        vbBTobject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //CarAni.GetComponent<Animator>();
        Car.active = false;
        audioCCP.Stop();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {

        //here is where the button would display the character and play the recording
        //CarAni.Play("CarSpin");
        Car.active = true;
        audioCCP.Play();
        //for debuging purposes
        Debug.Log("BIN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //here is where the button would make the character disapear and stop playing the recording
        //CarAni.Play("none");
        Car.active = false;
        audioCCP.Stop();
        //for debuging purposes
        Debug.Log("BIN Realesed");
    }
}
