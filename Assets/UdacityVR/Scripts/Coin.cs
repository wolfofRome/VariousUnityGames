using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject CoinPoofPrefab;
    //  public GameObject Coin1;//Create a reference to the CoinPoofPrefab

    private void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
    }

    public void OnCoinClicked() {
       //object.Instantiate(CoinPoofPrefab); // Instantiate the CoinPoof Prefab where this coin is located
                                    // Make sure the poof animates vertically
       Instantiate(CoinPoofPrefab);
        Instantiate(CoinPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
        Destroy(gameObject); // Destroy this coin. Check the Unity documentation on how to use Destroy
               

    }

}
