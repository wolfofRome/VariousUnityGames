using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject KeyPoofPrefab;//Create a reference to the KeyPoofPrefab and Door
    public Door DoorRef;

    private void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }



    public void OnKeyClicked()
	{

        Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0)); // Instatiate the KeyPoof Prefab where this key is located
        //Instantiate(DoorRef,transform.position,Quaternion.identity)
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        Destroy(gameObject);// Destroy the key. Check the Unity documentation on how to use Destroy

        DoorRef.Unlock();
    }

}
