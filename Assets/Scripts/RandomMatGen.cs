using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMatGen : MonoBehaviour
{
    public GameObject[] other;


    // Start is called before the first frame update
    void Start()
    {
        List<Color> color = new List<Color> { Color.red, Color.blue, Color.cyan, Color.green };

        if (transform.name.Equals("Player"))
        {
            Color randomColor = color[Random.Range(0, color.Count)];
            GetComponent<Renderer>().material.color = randomColor;
        }

        if (!transform.childCount.Equals(0))
        {
            foreach (GameObject item in other)
            {
                Color randomColor = color[Random.Range(0, color.Count)];
                item.GetComponent<Renderer>().material.color = randomColor;
                color.Remove(randomColor);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
