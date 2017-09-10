using System;
using UnityEngine;

public abstract class EntitySpawnerScript : MonoBehaviour
{
    public float spawnCoolDownSec;

    private DateTime lastSpawnTime = DateTime.MinValue;

    public virtual bool TrySpawn()
    {
        double secsSinceLastSpawn = (DateTime.Now - this.lastSpawnTime).TotalSeconds;

        if (secsSinceLastSpawn >= this.spawnCoolDownSec)
        {
            this.Spawn();
            this.lastSpawnTime = DateTime.Now;

            return true;
        }

        return false;
    }

    protected abstract void Spawn();
}
