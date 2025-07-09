using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] float _maxTime = 1f;
    [SerializeField] GameObject _ground;

    private float _timer;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (!GameManager.instance.hasStarted) return;
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0,0,0);
        GameObject ground = Instantiate(_ground, spawnPos, Quaternion.identity);

        Destroy(ground, 10f);
    }
}
