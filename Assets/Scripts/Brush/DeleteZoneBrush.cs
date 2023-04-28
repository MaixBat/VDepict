using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteZoneBrush : MonoBehaviour
{
    [HideInInspector]
    public float radius = 0.5f;
    //[HideInInspector]
    public bool isDelete;
    void Update()
    {
        if (radius != GetComponent<SphereCollider>().radius)
        {
            GetComponent<SphereCollider>().radius = radius; // �����, ��� ����� ����� �������. ���� ����� ������ ������ � ����, �� �������� � � �������
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " �����");
        if (other.tag == "Paint" && isDelete) // ���� � ���� ����� ������� � ����� �����
        {
            Destroy(other.gameObject);
        }
    }
}
