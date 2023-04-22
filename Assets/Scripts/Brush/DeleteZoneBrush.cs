using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteZoneBrush : MonoBehaviour
{
    public float radius = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
