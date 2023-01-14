using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelSpawn : MonoBehaviour
{
    public List<GameObject> road;
    private float offset = 40f;
    

    private void Start()
    {
        if (road != null && road.Count > 0)
        {
            road = road.OrderBy(r => r.transform.position.y).ToList();
        }
    }

    public void MoveLevel()
    {
        GameObject movedRoad = road[0];
        road.Remove(movedRoad);
        float newY = road[road.Count - 1].transform.position.y + offset;
        movedRoad.transform.position = new Vector3(0, newY);
        road.Add(movedRoad);
    }
}
