using System.Collections.Generic;
using UnityEngine;

public class SimManager : MonoBehaviour
{

    public List<CreatureParam> creatureParams = new List<CreatureParam>();
    public static SimManager Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
