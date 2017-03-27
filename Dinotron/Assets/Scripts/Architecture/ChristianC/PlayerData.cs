﻿using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour {

    public int playerNumber;

    public GameObject dinoObject;
    public DinoCharacter dinoCharacter;
    public PlayerControl playerControl;

    public GameObject cameraObject;
    public Camera playerCamera;
    public PlayerDinoCamera dinoCamera;

    public GameObject hudUIObject;
    public DinoUI dinoUI;

    [System.Serializable]
    public class WorldUIData {
        public GameObject worldUIObject;
        public WorldDinoUI worldDinoUI;

        public WorldUIData(GameObject worldUIObject, WorldDinoUI worldDinoUI) {
            this.worldUIObject = worldUIObject;
            this.worldDinoUI = worldDinoUI;
        }
    }
    
    public WorldUIData[] worldUIs = new WorldUIData[0];

	public void AddWorldUIData(GameObject worldUIObject, WorldDinoUI worldDinoUI) {
        WorldUIData[] newWorldUIs = new WorldUIData[worldUIs.Length + 1];
        for (int i = 0; i < worldUIs.Length; i++) {
            newWorldUIs[i] = worldUIs[i];
        }

        WorldUIData data = new WorldUIData(worldUIObject, worldDinoUI);
        newWorldUIs[newWorldUIs.Length - 1] = data;

        worldUIs = newWorldUIs;
    }
}