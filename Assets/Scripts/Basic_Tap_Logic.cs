using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Tap_Logic : MonoBehaviour {

	public GameObject NOTE_PREFAB; 
	public Transform[] spawnPositions; 
	[SerializeField]
	public bool[,] song1; 


	void Awake(){
		song1 = new bool[112, 3]; 
		///here are the song notes you must play
		song1[0,0] = false; song1[0,1] = true; song1[0,2] = false; //1
		song1[1,0] = false; song1[1,1] = true; song1[1,2] = false; //2
		song1[2,0] = false; song1[2,1] = false; song1[2,2] = false; //3
		song1[3,0] = false; song1[3,1] = true; song1[3,2] = false; //4
		song1[4,0] = false; song1[4,1] = true; song1[4,2] = false; //5
		song1[5,0] = false; song1[5,1] = true; song1[5,2] = false; //6
		song1[6,0] = false; song1[6,1] = false; song1[6,2] = false; //7
		song1[7,0] = false; song1[7,1] = false; song1[7,2] = false; //8
		song1[8,0] = false; song1[8,1] = false; song1[8,2] = false; //9
		song1[9,0] = false; song1[9,1] = false; song1[9,2] = false; //10
		song1[10,0] = false; song1[10,1] = true; song1[10,2] = false; //1
		song1[11,0] = false; song1[11,1] = true; song1[11,2] = false; //2
		song1[12,0] = false; song1[12,1] = false; song1[12,2] = false; //3
		song1[13,0] = false; song1[13,1] = false; song1[13,2] = false; //4
		song1[14,0] = false; song1[14,1] = false; song1[14,2] = false; //5
		song1[15,0] = false; song1[15,1] = false; song1[15,2] = false; //6
		song1[16,0] = false; song1[16,1] = false; song1[16,2] = false; //7
		song1[17,0] = false; song1[17,1] = false; song1[17,2] = false; //8
		song1[18,0] = false; song1[18,1] = false; song1[18,2] = false; //9
		song1[19,0] = false; song1[19,1] = false; song1[19,2] = false; //10
		song1[20,0] = false; song1[20,1] = true; song1[20,2] = false; //1
		song1[21,0] = false; song1[21,1] = true; song1[21,2] = false; //2
		song1[22,0] = false; song1[22,1] = false; song1[22,2] = false; //3
		song1[23,0] = false; song1[23,1] = false; song1[23,2] = false; //4
		song1[24,0] = false; song1[24,1] = false; song1[24,2] = false; //5
		song1[25,0] = false; song1[25,1] = false; song1[25,2] = false; //6
		song1[26,0] = false; song1[26,1] = false; song1[26,2] = false; //7
		song1[27,0] = false; song1[27,1] = false; song1[27,2] = false; //8
		song1[28,0] = false; song1[28,1] = false; song1[28,2] = false; //9
		song1[29,0] = false; song1[29,1] = false; song1[29,2] = false; //10
		song1[30,0] = false; song1[30,1] = true; song1[30,2] = false; //1
		song1[31,0] = false; song1[31,1] = true; song1[31,2] = false; //2
		song1[32,0] = false; song1[32,1] = false; song1[32,2] = false; //3
		song1[33,0] = false; song1[33,1] = false; song1[33,2] = false; //4
		song1[34,0] = false; song1[34,1] = false; song1[34,2] = false; //5
		song1[35,0] = false; song1[35,1] = false; song1[35,2] = false; //6
		song1[36,0] = false; song1[36,1] = false; song1[36,2] = false; //7
		song1[37,0] = false; song1[37,1] = false; song1[37,2] = false; //8
		song1[38,0] = false; song1[38,1] = false; song1[38,2] = false; //9
		song1[39,0] = false; song1[39,1] = false; song1[39,2] = false; //10
		song1[40,0] = false; song1[40,1] = true; song1[40,2] = false; //1
		song1[41,0] = false; song1[41,1] = true; song1[41,2] = false; //2
		song1[42,0] = false; song1[42,1] = false; song1[42,2] = false; //3
		song1[43,0] = false; song1[43,1] = false; song1[43,2] = false; //4
		song1[44,0] = false; song1[44,1] = false; song1[44,2] = false; //5
		song1[45,0] = false; song1[45,1] = false; song1[45,2] = false; //6
		song1[46,0] = false; song1[46,1] = false; song1[46,2] = false; //7
		song1[47,0] = false; song1[47,1] = false; song1[47,2] = false; //8
		song1[48,0] = false; song1[48,1] = false; song1[48,2] = false; //9
		song1[49,0] = false; song1[49,1] = false; song1[49,2] = false; //10
		song1[50,0] = false; song1[50,1] = true; song1[50,2] = false; //1
		song1[51,0] = false; song1[51,1] = true; song1[51,2] = false; //2
		song1[52,0] = false; song1[52,1] = false; song1[52,2] = false; //3
		song1[53,0] = false; song1[53,1] = false; song1[53,2] = false; //4
		song1[54,0] = false; song1[54,1] = false; song1[54,2] = false; //5
		song1[55,0] = false; song1[55,1] = false; song1[55,2] = false; //6
		song1[56,0] = false; song1[56,1] = false; song1[56,2] = false; //7
		song1[57,0] = false; song1[57,1] = false; song1[57,2] = false; //8
		song1[58,0] = false; song1[58,1] = false; song1[58,2] = false; //9
		song1[59,0] = false; song1[59,1] = false; song1[59,2] = false; //10
		song1[60,0] = false; song1[60,1] = true; song1[60,2] = false; //1
		song1[61,0] = false; song1[61,1] = true; song1[61,2] = false; //2
		song1[62,0] = false; song1[62,1] = false; song1[62,2] = false; //3
		song1[63,0] = false; song1[63,1] = false; song1[63,2] = false; //4
		song1[64,0] = false; song1[64,1] = false; song1[64,2] = false; //5
		song1[65,0] = false; song1[65,1] = false; song1[65,2] = false; //6
		song1[66,0] = false; song1[66,1] = false; song1[66,2] = false; //7
		song1[67,0] = false; song1[67,1] = false; song1[67,2] = false; //8
		song1[68,0] = false; song1[68,1] = false; song1[68,2] = false; //9
		song1[69,0] = false; song1[69,1] = false; song1[69,2] = false; //10
		song1[70,0] = false; song1[70,1] = true; song1[70,2] = false; //1
		song1[71,0] = false; song1[71,1] = true; song1[71,2] = false; //2
		song1[72,0] = false; song1[72,1] = false; song1[72,2] = false; //3
		song1[73,0] = false; song1[73,1] = false; song1[73,2] = false; //4
		song1[74,0] = false; song1[74,1] = false; song1[74,2] = false; //5
		song1[75,0] = false; song1[75,1] = false; song1[75,2] = false; //6
		song1[76,0] = false; song1[76,1] = false; song1[76,2] = false; //7
		song1[77,0] = false; song1[77,1] = false; song1[77,2] = false; //8
		song1[78,0] = false; song1[78,1] = false; song1[78,2] = false; //9
		song1[79,0] = false; song1[79,1] = false; song1[79,2] = false; //10
		song1[80,0] = false; song1[80,1] = true; song1[80,2] = false; //1
		song1[81,0] = false; song1[81,1] = true; song1[81,2] = false; //2
		song1[82,0] = false; song1[82,1] = false; song1[82,2] = false; //3
		song1[83,0] = false; song1[83,1] = false; song1[83,2] = false; //4
		song1[84,0] = false; song1[84,1] = false; song1[84,2] = false; //5
		song1[85,0] = false; song1[85,1] = false; song1[85,2] = false; //6
		song1[86,0] = false; song1[86,1] = false; song1[86,2] = false; //7
		song1[87,0] = false; song1[87,1] = false; song1[87,2] = false; //8
		song1[88,0] = false; song1[88,1] = false; song1[88,2] = false; //9
		song1[89,0] = false; song1[89,1] = false; song1[89,2] = false; //10
		song1[90,0] = false; song1[90,1] = true; song1[90,2] = false; //1
		song1[91,0] = false; song1[91,1] = true; song1[91,2] = false; //2
		song1[92,0] = false; song1[92,1] = false; song1[92,2] = false; //3
		song1[93,0] = false; song1[93,1] = false; song1[93,2] = false; //4
		song1[94,0] = false; song1[94,1] = false; song1[94,2] = false; //5
		song1[95,0] = false; song1[95,1] = false; song1[95,2] = false; //6
		song1[96,0] = false; song1[96,1] = false; song1[96,2] = false; //7
		song1[97,0] = false; song1[97,1] = false; song1[97,2] = false; //8
		song1[98,0] = false; song1[98,1] = false; song1[98,2] = false; //9
		song1[99,0] = false; song1[99,1] = false; song1[99,2] = false; //10
		song1[100,0] = false; song1[100,1] = true; song1[100,2] = false; //1
		song1[101,0] = false; song1[101,1] = true; song1[101,2] = false; //2
		song1[102,0] = false; song1[102,1] = false; song1[102,2] = false; //3
		song1[103,0] = false; song1[103,1] = false; song1[103,2] = false; //4
		song1[104,0] = false; song1[104,1] = false; song1[104,2] = false; //5
		song1[105,0] = false; song1[105,1] = false; song1[105,2] = false; //6
		song1[106,0] = false; song1[106,1] = false; song1[106,2] = false; //7
		song1[107,0] = false; song1[107,1] = false; song1[107,2] = false; //8
		song1[108,0] = false; song1[108,1] = false; song1[108,2] = false; //9
		song1[109,0] = false; song1[109,1] = false; song1[109,2] = false; //10
		song1[110,0] = false; song1[110,1] = false; song1[110,2] = false; //9
		song1[111,0] = false; song1[111,1] = false; song1[111,2] = false; //10




		///here int ends
	}

	void Start(){
		StartCoroutine (launchTaps()); 
	}

	IEnumerator launchTaps(){
		for (int i = 0; i < 112; i++) {
			if (song1 [i, 0] == true) {
				Note_Logic go=Instantiate (NOTE_PREFAB, spawnPositions [0].position, Quaternion.identity).GetComponent<Note_Logic>(); 
				go.move (); 
			}
			if (song1 [i, 1] == true) {
				Note_Logic go=Instantiate (NOTE_PREFAB, spawnPositions [1].position, Quaternion.identity).GetComponent<Note_Logic>(); 
				go.move (); 
			}
			if (song1 [i, 2] == true) {
				Note_Logic go=Instantiate (NOTE_PREFAB, spawnPositions [2].position, Quaternion.identity).GetComponent<Note_Logic>(); 
				go.move (); 
			}
			yield return new WaitForSeconds (0.71425f); 
		}
	}

}
