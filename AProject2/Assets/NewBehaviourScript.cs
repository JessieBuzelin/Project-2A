using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {

    // Update is called once per frame
   
    
        // determine value amount 

       // start of game and randomizing fish stats when caught
      Debug.Log("What a day for fishing! Press A to cast your reel!");
     // fishLength = Random.Range(1f, 150f);
     // fishValue = Random.Range(10, 85);













        // catching a random fish from string list
        // Debug.Log("Players first Fish: " + ocean[Random.Range(0,ocean.Length)]); // Use to randomize fish catch
        //  Debug.Log(" wow! What a Fish! " + " Fish Weighs " + fishWeight + "Kg" + " Fish Measures at " + fishLength + "Cm"); // after casting reel out


    }





    // Update is called once per frame
    void Update()
    {

       //f (Input.GetKeyDown(KeyCode.A))
        {


            // random fish when you cast your reel
        //  Debug.Log("You caught a fish!: " + ocean[Random.Range(0, ocean.Length)]); // Use to randomize fish catch
        //  Debug.Log(" wow! What a Fish! " + " Fish Measures at " + (float)fishLength + "Cm " + " Fish valued at " + "$" + fishValue);


            Debug.Log(" Would you like to sell it or keep it? Press F to throw away or E to keep it ");








        }
        // if collected gets added to a collection
        if (Input.GetKeyDown(KeyCode.E))
        {

       //   myValue += fishValue;

       //   Debug.Log("You added it to your collection! your value of fish is now: " + "$" + myValue + "Press A to cast reel again!");
      //    rounds += 1;



      //    fishLength = Random.Range(1f, 150f);
       //   fishValue = Random.Range(10, 85);


        }
        // throws fish away and doesnt add value to myValue
        else if (Input.GetKeyDown(KeyCode.F))
        {

     //     Debug.Log("You throw it back into the ocean! your value of fish is now: " + "$" + myValue + "Press A to cast reel again!");
     //     rounds += 1;
      //    fishLength = Random.Range(1f, 150f);
      //    fishValue = Random.Range(10, 85);

        }


    }
}
