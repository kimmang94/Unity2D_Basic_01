using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverTrigger : MonoBehaviour
{
    
    private bool hasPackage = false;
    [SerializeField]
    private Color32 hasPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] private Color32 dropPackageColor = new Color32(1, 1, 1, 1);

    private SpriteRenderer spriteRenderer = null;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// other 와 Trigger 시 Package 이면 물품픽업 hasPackage = true,
    /// Customer 이면 물품 배달완료 hasPackage = false
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Package" && !hasPackage)
        {
            Debug.Log("물품 픽업 완료!");
            other.gameObject.SetActive(false);
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
        }

        if (other.gameObject.tag == "Customer" && hasPackage)
        {
            Debug.Log("배달 완료!");
            hasPackage = false;
            spriteRenderer.color = dropPackageColor;
        }
        
    }

}
