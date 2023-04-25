using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrushCanvasManager : MonoBehaviour
{
    public GameObject mainGroup;
    public GameObject brushPrefab;
    public GameObject eraserPrefab;


    private void Start()
    { 
        // � ���� ������ ������� ��� ������ ����� ��� ����� �� ������ �� �������, ����� ���� ���������� ��� ������ �� ���������, � �����
        brushPrefab.SetActive(false);
        eraserPrefab.SetActive(false);
    }
    public void VisibilityGroup(GameObject _group)
    {
        if (_group.active)
        {
            _group.SetActive(false);
            mainGroup.SetActive(true);
        }
        else
        {
            _group.SetActive(true);
            mainGroup.SetActive(false);
        }
    }
    public void SetBrushImage(GameObject _spriteTemplate) => brushPrefab.GetComponent<BrushPrefabController>().image = _spriteTemplate.GetComponent<Button>().image.sprite;
    public void SetBrushDistance(float _distance) => brushPrefab.GetComponent<BrushPrefabController>().minDistance = _distance;


}
