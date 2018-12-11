using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawn : MonoBehaviour {

    public GameObject[] blocks;

    private int blockNumber;

    float timer;

	// Use this for initialization
	void Start () {

        blockNumber = Random.Range(0, blocks.Length);
        
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            GameObject block = blocks[blockNumber];
            Instantiate(block, new Vector3(block.transform.position.x, transform.position.y, 0), block.transform.rotation);

            blockNumber = Random.Range(0, blocks.Length);
            timer = BlockDistanceLookup.getTimer(block.name, blocks[blockNumber].name) / globalVariables.speed ;
        }
        
    }
}
