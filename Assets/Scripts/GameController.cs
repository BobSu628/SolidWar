using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState
{
    
}

public class GameController : MonoBehaviour
{

    public static GameController instance;
    public List<UnitController> units;
    public GameObject boardPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnUnits();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupBoard()
    {
        Vector3 boardPosition = new Vector3(0, 0, 0);
        GameObject board = Instantiate(boardPrefab, boardPosition, Quaternion.identity) as GameObject;
        board.transform.localScale = new Vector3(5, 5, 5);

        SpawnUnits();
    }

    void SpawnUnits()
    {

    }
}
