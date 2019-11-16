using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
		 * (Christopher Green)
		 * (CollectibleSpawnManager.cs)
		 * (Assignment 10)
		 * (This script creates two lists, populates them, and changes their contents color, 
         * as well as spawning them.)
*/

public class CollectibleSpawnManager : MonoBehaviour
{

    public List<GameObject> collectibles = new List<GameObject>();
    public List<GameObject> multicolorCollectibles = new List<GameObject>();

    public int rNumber;
    private GameObject itemToPaint;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 1; i <= 3; i++)
            {
                rNumber = Random.Range(0, 3);
                itemToPaint = Instantiate(collectibles[rNumber]);
                itemToPaint.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 0f, 0f, 1f);
                multicolorCollectibles.Insert(Random.Range(0, multicolorCollectibles.Count - 1), itemToPaint);
                Debug.Log(multicolorCollectibles.Count - 1);
            }
            Debug.Log("The last item in the multicolorCollectibles list is: " + multicolorCollectibles[multicolorCollectibles.Count - 1] + " and it's number is: " + multicolorCollectibles.Count);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Vector3 position = new Vector3(Random.Range(player.transform.position.x, player.transform.position.x + 5), 0f, Random.Range(player.transform.position.z, player.transform.position.z + 5));
            Instantiate(multicolorCollectibles[multicolorCollectibles.Count - 1], position, player.transform.rotation);
            multicolorCollectibles.RemoveAt(multicolorCollectibles.Count - 1);
        }
    }
}
