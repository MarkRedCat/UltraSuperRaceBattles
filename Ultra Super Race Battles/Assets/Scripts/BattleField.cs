using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleField : MonoBehaviour
{
    [SerializeField]
    public GameObject team1Ranged;
    public GameObject team1Melee;
    public GameObject team2Ranged;
    public GameObject team2Melee;

    private Vector3[] team1Spawns = new Vector3[5];
    //private Vector3[] team2Spawns = new Vector3[5];
    private Vector3[] team2Spawns = {new Vector3(7, 1, 0), new Vector3(8, -1, 0), new Vector3(7, -4, 0), new Vector3(2, 0, 0), new Vector3(3, -3, 0)};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting...");
        team1Spawns[0] = new Vector3(-7, 1, 0);
        team1Spawns[1] = new Vector3(-8, -1, 0);
        team1Spawns[2] = new Vector3(-7, -4, 0);
        team1Spawns[3] = new Vector3(-2, 0, 0);
        team1Spawns[4] = new Vector3(-3, -3, 0);
        Debug.Log("Spawn points ready, instantiating...");
        Instantiate(team1Ranged, team1Spawns[0], Quaternion.identity);
        Instantiate(team2Melee, team2Spawns[4], Quaternion.Euler(0, 180, 0));
        Instantiate(team2Ranged, team2Spawns[3], Quaternion.Euler(0, 180, 0));
        Instantiate(team1Melee, team1Spawns[1], Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
