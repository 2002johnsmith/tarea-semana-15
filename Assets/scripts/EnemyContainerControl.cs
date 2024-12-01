using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    [Header("Prefab Variables")]
    public GameObject EnemyPrefab;
    [Header("Limite de Posicion")]
    public float xMinPosition;
    public float xMaxPosition;
    [Header("Ubicacion en Y")]
    public float Yposition;
    [Header("Respawn Enemy")]
    public float Time;
    [Header("Game Manager Variables")]
    public GameManagerControl GameManager;
    // Start is called before the first frame update
    void Start()
    {
        CreateEnemy();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEnemy()
    {
        float XPosition = Random.Range(xMinPosition,xMaxPosition);
        Vector2 positiontoCreate = new Vector2(XPosition, Yposition);
        GameObject enemy = Instantiate(EnemyPrefab, positiontoCreate, transform.rotation);
        enemy.GetComponent<enemycode>().SetGameManager(GameManager);
        Invoke("CreateEnemy", Time);
    }
}
