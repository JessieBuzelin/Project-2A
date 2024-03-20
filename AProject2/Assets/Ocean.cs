using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean : MonoBehaviour
{
    // possiable species of fish you can catch and there stats 
    public FishScript[] allFish = new FishScript[] { }; // my list of available fish to catch

    // fish stats                                                                                                                                                     

    public FishScript fishLength;
    public FishScript fishValue;














    void Start()
    {

        // start of game and randomizing fish stats when caught
        Debug.Log("What a day for fishing! Press A to cast your reel!");
        Debug.Log(allFish[1].fishSpecies + 
        // Debug.Log(allFish[0].fishSpecies);









    }
    private void Update()
    {

    }










}