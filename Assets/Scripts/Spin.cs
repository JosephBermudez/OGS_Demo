//Script Created by Jose Bermudez. 2/15/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    private Vector3 screenPosition;
    private Camera myCamera;
    private float dragOffset;
    private Collider2D col2D;

    private void Start()
    {
        myCamera = Camera.main;
        col2D = GetComponent<Collider2D>();
    }

    private void Update()
    {
        Vector3 touchPosition = myCamera.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (col2D == Physics2D.OverlapPoint(touchPosition))
            {
                screenPosition = myCamera.WorldToScreenPoint(transform.position);
                Vector3 position = Input.mousePosition - touchPosition;
                dragOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(position.y, position.x)) * Mathf.Rad2Deg;
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (col2D == Physics2D.OverlapPoint(touchPosition))
            {
                Vector3 position = Input.mousePosition - touchPosition;
                float angle = Mathf.Atan2(position.y, position.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0, 0, angle + dragOffset);
            }
        }
    }
}
