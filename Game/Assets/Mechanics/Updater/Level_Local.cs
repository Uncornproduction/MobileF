using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Local : MonoBehaviour
{
    #region init
        [Header("Level Data")]
        public GameObject[] upgrade = new GameObject[4]; 
        public int[] upgrade_cost = new int[4];
        public string upgrade_name;
        [TextArea(3,5)]
        public string upgrade_description = "";
    #endregion
}
