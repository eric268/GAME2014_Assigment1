using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSpritesWithAspectRatio : MonoBehaviour
{
    public GameObject spriteImage;
    public Camera mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        ScaleImage();
    }

    // Update is called once per frame
    private void ScaleImage()
    {
        float height = Screen.height;
        float width = Screen.width;

        float aspectRatio = width / height;

        Debug.Log("Width: " + width + " Height:" + height);

        mainCamera.aspect = aspectRatio;

        float cameraHeight = 100.0f * mainCamera.orthographicSize * 2.0f;
        float cameraWidth = cameraHeight * aspectRatio;

        SpriteRenderer image = spriteImage.GetComponent<SpriteRenderer>();
        float spriteHeight = image.sprite.rect.height;
        float spriteWidth = image.sprite.rect.width;

        float imageScaleHeight = cameraHeight / spriteHeight;
        float imageScaleWidth = cameraWidth / spriteWidth;

        spriteImage.transform.localScale = new Vector3(imageScaleWidth, imageScaleHeight, 1);
    }
}
