using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public GameObject[] tilePrefabs;

    [SerializeField]
    private Transform player;

    private float spawnZ = 0.0f;

    private float tileLength = 7.5f;

    private int amtTiles = 7;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i = 0; i < amtTiles; i++){
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.z > (spawnZ - amtTiles * tileLength)){
            SpawnTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1){
        GameObject go; 
        go = Instantiate(tilePrefabs[0]) as GameObject;
        print("dhuski");
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }

}
