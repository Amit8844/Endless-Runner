using EndlessRunner.Tiles;
using UnityEngine;

namespace EndlessRunner.Ground
{
    public class GroundSpawner : MonoBehaviour
    {

        [SerializeField] GameObject groundTile;
        Vector3 nextSpawnPoint;

        public void SpawnTile(bool spawnItems)
        {
            GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
            nextSpawnPoint = temp.transform.GetChild(1).transform.position;

            if (spawnItems)
            {
                temp.GetComponent<GroundTile>().SpawnObstacle();
                temp.GetComponent<GroundTile>().SpawnCoins();
            }
        }

        private void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i < 3)
                {
                    SpawnTile(false);
                }
                else
                {
                    SpawnTile(true);
                }
            }
        }
    }
}