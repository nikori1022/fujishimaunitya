using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRangeRandomPosition : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;

    // 経過時間
    private float time;

    // 生成されたGameObjectの数をカウント
    private int count = 0;

    // 生成の最大数
    private int maxCount = 100;

    // Update is called once per frame
    void Update()
    {
        // 前フレームからの時間を加算していく
        time += Time.deltaTime;

        // 約1秒置きにランダムに生成され、かつ最大数に達していない場合に生成
        if (time > 1.0f && count < maxCount)
        {
            // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
            float z = Random.Range(rangeA.position.z, rangeB.position.z);

            // GameObjectを上記で決まったランダムな場所に生成
            Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation);

            // 経過時間リセット
            time = 0f;

            // 生成されたGameObjectの数をカウントアップ
            count++;
        }
    }
}