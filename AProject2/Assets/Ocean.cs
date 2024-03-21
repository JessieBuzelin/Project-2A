using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean : MonoBehaviour
{
    // possiable species of fish you can catch and there stats 
 //   public FishScript[] allFish = new FishScript[] { }; // my list of available fish to catch
 public List<string> fish = new List<string>{"Bass", "Tuna", "Cod", "Shark"};
    // fish stats                                                                                                                                                     
    public List<string> fishBowl = new List<string> { };

    
        
    public FishScript fishLength;
    public FishScript fishValue;
    public string fishCollection;
    public string fishName = "Shark";
    private        string lastGeneratedFish;
    










    void Start()
    {
       


        fish.Add("Bass");
        fish.Add("Tuna");
        fish.Add("Cod");
        fish.Add("Shark");
        // start of game and randomizing fish stats when caught
     //   int randomIndex = Random.Range(0, fish.Count);
      //  string randomFish = fish[randomIndex];
        Debug.Log("What a day for fishing! Press A to cast your reel!");
        //  
        //  Debug.Log(randomFish);




       




    }


   public void gamePlay()
    { 
        int randomIndex = Random.Range(0, fish.Count);
        string randomFish = fish[randomIndex];
        lastGeneratedFish = randomFish;
        if (Input.GetKeyDown(KeyCode.A))
        {

            Debug.Log("Wow! what a fish! You caught a: " + randomFish);
            Debug.Log("Do you wish to sell it or keep it?");
            Debug.Log("Press F to throw it away and E to keep it");

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            fishBowl.Remove(randomFish);
            Debug.Log("You threw the fish away!");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            fishBowl.Add(lastGeneratedFish);
            Debug.Log("You Added: " + lastGeneratedFish);
            if (fishBowl.Contains("Shark"))
            {
                fish.Remove(randomFish);
                Debug.Log("Fish Was eaten!");

            }
        }


    }
    void Update()
    {
        gamePlay();

    }










}