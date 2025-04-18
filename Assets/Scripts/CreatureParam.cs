using System;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CreatureParam", order = 1)]
public class CreatureParam : ScriptableObject
{
    public string Name;
    public int id;
    public float value;
    public float maxVal;
    public float minVal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void updateVal(int change) {
        value = Math.Min(Math.Max(value + change, minVal), maxVal);
    }
}
