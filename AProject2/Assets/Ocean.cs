using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean : MonoBehaviour
{
    // possiable species of fish you can catch and there stats 
    //   public FishScript[] allFish = new FishScript[] { }; // my list of available fish to catch
    public List<string> fish = new List<string> { "Bass", "Tuna", "Cod", "Shark" };
    // Fish Bowl to keep caught fish                                                                                                                                                    
    public List<string> fishBowl = new List<string> { };


    // fish stats  
    public FishScript fishLength;
    public FishScript fishValue;
    public string fishCollection;
    public string fishName = "Shark";
    private string lastGeneratedFish;











    void Start()
    {
        // start of the game main menu


        fish.Add("Bass");
        fish.Add("Tuna");
        fish.Add("Cod");
        fish.Add("Shark");
        //   int randomIndex = Random.Range(0, fish.Count);
        //  string randomFish = fish[randomIndex];
        Debug.Log("What a day for fishing! Press A to start the game");
        //  
        //  Debug.Log(randomFish);







    }



    void Update()
    {

        
        
            if (Input.GetKeyDown(KeyCode.A))
            {
                gamePlay();
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                gamePlay();
            }
           else if (Input.GetKeyDown(KeyCode.E))
            {
                gamePlay();
            }
        


    }
    public void gamePlay()
    {
        // Randomize fish selection
        int randomIndex = Random.Range(0, fish.Count);
        string randomFish = fish[randomIndex];
        lastGeneratedFish = randomFish;

        // Notify player about the caught fish
        if (Input.GetKey(KeyCode.A))
        {


            Debug.Log("Wow! what a fish! You caught a: " + randomFish);
            Debug.Log("Do you wish to sell it or keep it?");
            Debug.Log("Press F to throw it away and E to keep it");
        }
        // Check for player input to decide the fate of the caught fish
        if (Input.GetKeyDown(KeyCode.F))
        {
            fishBowl.Remove(lastGeneratedFish);
            Debug.Log("You threw the fish away!");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            fishBowl.Add(lastGeneratedFish);
            Debug.Log("You Added: " + lastGeneratedFish);
         // Debug.Log(""

            // Check if the fish bowl contains a shark and handle accordingly
            if (fishBowl.Contains("Shark"))
            {
                fish.Remove("Shark");
                Debug.Log("Shark was eaten!");
            }
        }

    }


}





