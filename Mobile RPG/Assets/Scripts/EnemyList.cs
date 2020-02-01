using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();
    public List<GameObject> Wave1 = new List<GameObject>();
    public List<GameObject> Wave2 = new List<GameObject>();
    public List<GameObject> Wave3 = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddList(Wave1));
        StartCoroutine(AddList(Wave2));
        StartCoroutine(AddList(Wave3));
    }

    IEnumerator AddList(List<GameObject> list)
    {
        foreach (GameObject i in list)
        {
            Enemies.Add(i);
        }
        yield return new WaitForEndOfFrame();
    }

    // Update is called once per frame

}
