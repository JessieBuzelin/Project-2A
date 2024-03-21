using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public string fishSpecies;
    public float fishSize;
    public int fishValue;




    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            fishSize = Random.Range(5, 85);
            float fishValue = Random.Range(5f, 50f + (float)fishSize);
            Debug.Log(fishSize + fishValue);
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        
        
    }

}
