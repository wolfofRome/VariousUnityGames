using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    bool locked= true;// Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    bool opening;// Create a boolean value called "opening" that can be checked in Update() 
    public AudioClip OpenedClip, LockedClip;
    //public bool keyCollected =false;

    public void playMusic()
    {
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = OpenedClip;
        this.GetComponent<AudioSource>().Play();
    }

    void Update() {
        if (opening==true && transform.position.y < 7.8f)
        {
             transform.Translate(0, 1.5f*Time.deltaTime, 0);
            playMusic();
        }
       
        
        // If the door is opening and it is not fully raised
        // Animate the door raising up
    }

    public void OnDoorClicked() {
        if (locked == false)
        {
            opening = true;
            
        }
        else
        {
            this.gameObject.AddComponent<AudioSource>();
            this.GetComponent<AudioSource>().clip = LockedClip;
            this.GetComponent<AudioSource>().Play();
        }
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        //if(keyCollected==true)
        //{
            locked = false;// You'll need to set "locked" to false here
       // }
        
    }
}
