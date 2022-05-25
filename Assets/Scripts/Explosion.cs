using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // オブジェクトを消す
        Destroy(gameObject);

        // 爆発のプレハブ
        Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
    }
}
