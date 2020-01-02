using System.Collections;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 3f;
    [SerializeField] float maxSpawnDelay = 10f;
    [SerializeField] Attacker[] attackerPrefabArray;

    bool spawn = true;

    IEnumerator Start()
    {
        while(spawn)
        {
            float timeToWait = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(timeToWait);
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        int attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }
}
