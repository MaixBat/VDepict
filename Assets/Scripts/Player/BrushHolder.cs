using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushHolder : MonoBehaviour
{
    [Header("������� ������")]
    public GameObject dotBrush; // dotBrush.GetComponent<BrushPrefabController>().isDrawing; <- ��������� � ������� ��� ���������
    public GameObject lineBrush; // lineBrush.GetComponent<LineBrushManager>().isDrawing; <- ��������� � ������� ��� ���������
    public GameObject eraserBrush; // eraserBrush.GetComponent<DeleteZoneBrush>().isDelete; <- ��������� � ������� ��� ��������
    [Header("������ ������")]
    public Canvas brushCanvas;
    public BrushCanvasManager brushCanvasManager;
    [Header("����")]
    public Transform rightHand;
    public Transform leftHand;

    private void Start()
    {
        brushCanvasManager.lineBrushPrefab = lineBrush;
        brushCanvasManager.brushPrefab = dotBrush;
        brushCanvasManager.eraserPrefab = eraserBrush;
    }
    public void ChangeHand()
    {
        if (transform.parent == rightHand)
        {
            transform.SetParent(leftHand);
            transform.localPosition = new Vector3(0, 0, 0);
            brushCanvas.transform.parent.SetParent(rightHand);
            brushCanvas.transform.parent.localPosition = new Vector3(0, 0, 0);
            brushCanvas.transform.localRotation =  Quaternion.Euler(50, 0, -90);
        }
        else if (transform.parent == leftHand)
        {
            transform.SetParent(rightHand);
            transform.localPosition = new Vector3(0, 0, 0);
            brushCanvas.transform.parent.SetParent(leftHand);
            brushCanvas.transform.parent.localPosition = new Vector3(0, 0, 0);
            brushCanvas.transform.localRotation = Quaternion.Euler(50, 0, 90);
        }
    }
}
