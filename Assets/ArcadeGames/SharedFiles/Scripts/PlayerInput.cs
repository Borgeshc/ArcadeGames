using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static float horizontal;
    public static float vertical;
    public static float horizontal2;
    public static float vertical2;
    public static bool isJumping;
    public static bool isFiring;

    Controls controls;
    string saveData;

    void OnEnable()
    {
        controls = Controls.CreateWithDefaultBindings();
    }

    void OnDisable()
    {
        controls.Destroy();
    }

    private void Update()
    {
        horizontal = controls.Move.X;
        vertical = controls.Move.Y;
        horizontal2 = controls.Look.X;
        vertical2 = controls.Look.Y;

        isJumping = controls.Jump;
        isFiring = controls.Fire;
    }

    void SaveBindings()
    {
        saveData = controls.Save();
        PlayerPrefs.SetString("Bindings", saveData);
    }

    void LoadBindings()
    {
        if (PlayerPrefs.HasKey("Bindings"))
        {
            saveData = PlayerPrefs.GetString("Bindings");
            controls.Load(saveData);
        }
    }
}
