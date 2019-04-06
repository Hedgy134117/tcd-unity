using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevModeModifiers : MonoBehaviour {

    public ApplyModifiers modifiers;
    public WinManager winManager;
    public AddMovingCamera DynamicCamera;

    public InputField devPointsToWin;
    public InputField devCatSize;
    public InputField devCatSpeed;
    public InputField devCatJumps;
    public Toggle devThinPlatform;
    public Toggle devDynamicCamera;

    // Use this for initialization
    void Start() {
        devPointsToWin.text = winManager.pointsToWin.ToString();
        devCatSize.text = modifiers.catSize.ToString();
        devCatSpeed.text = modifiers.catSpeed.ToString();
        devCatJumps.text = modifiers.catJumps.ToString();
        devThinPlatform.isOn = modifiers.thinPlatform;
        devDynamicCamera.isOn = DynamicCamera.dynamicCamera;
    }
	
	public void Update()
    {
        winManager.pointsToWin = int.Parse(devPointsToWin.text);
        modifiers.catSize = int.Parse(devCatSize.text);
        modifiers.catSpeed = int.Parse(devCatSpeed.text);
        modifiers.catJumps = int.Parse(devCatJumps.text);
        modifiers.thinPlatform = devThinPlatform.isOn;
        DynamicCamera.dynamicCamera = devDynamicCamera.isOn;
    }
}
