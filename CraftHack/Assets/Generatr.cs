using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatr : MonoBehaviour
{
    public GameObject objectToCopy;
    public int minCopies = 1;
    public int maxCopies = 5;
    public float yOffset = 1.0f;

    public void StartGeneration()
    {
        int numCopies = Random.Range(minCopies, maxCopies + 1);

        for (int i = 0; i < numCopies; i++)
        {
            Vector3 spawnPosition = transform.position + new Vector3(0f, i * yOffset, 0f);
            GameObject copy = Instantiate(objectToCopy, spawnPosition, Quaternion.identity);
            copy.transform.localScale = Vector3.one; // Reset the local scale of the copy
        }
    }
}
