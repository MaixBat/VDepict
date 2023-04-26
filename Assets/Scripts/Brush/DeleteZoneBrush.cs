using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteZoneBrush : MonoBehaviour
{
    [HideInInspector]
    public float radius = 0.5f;
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
        //if (Input.GetKey(KeyCode.E)) //�������� �� ������ �����������
        //{
            //Debug.Log("������ � ������");
            if (other.tag == "Paint")
            {
                Destroy(other.gameObject);
            }
        //}
    }
}
