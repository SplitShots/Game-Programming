using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    //Fields
    //public int minSpawn;
    //public int maxSpawn;
    public GameObject Bacteria;
    public int bacteriaNumber;
    private List<GameObject> _bacteria;

	// Use this for initialization
	void Start () {
        //bacteriaNumber = Random.Range(minSpawn, maxSpawn);

        this._bacteria = new List<GameObject>();
        //creating pool of bacteria to keep track of amount of bacteria
        for (int i = 0; i < this.bacteriaNumber; i++)
        {
            this._bacteria.Add(Instantiate(Bacteria));
        }
	}
	
	// Update is called once per frame
	void Update () {
        //bacteriaNumber = Random.Range(minSpawn, maxSpawn);

    }
}
//Try to spawn bacteria at a random rate, but will spawn more according to total amount of score 