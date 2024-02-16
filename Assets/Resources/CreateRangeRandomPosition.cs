using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRangeRandomPosition : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("��������͈�A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("��������͈�B")]
    private Transform rangeB;

    // �o�ߎ���
    private float time;

    // �������ꂽGameObject�̐����J�E���g
    private int count = 0;

    // �����̍ő吔
    private int maxCount = 100;

    // Update is called once per frame
    void Update()
    {
        // �O�t���[������̎��Ԃ����Z���Ă���
        time += Time.deltaTime;

        // ��1�b�u���Ƀ����_���ɐ�������A���ő吔�ɒB���Ă��Ȃ��ꍇ�ɐ���
        if (time > 1.0f && count < maxCount)
        {
            // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float z = Random.Range(rangeA.position.z, rangeB.position.z);

            // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
            Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation);

            // �o�ߎ��ԃ��Z�b�g
            time = 0f;

            // �������ꂽGameObject�̐����J�E���g�A�b�v
            count++;
        }
    }
}