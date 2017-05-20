using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Tap_Logic : MonoBehaviour {

	public GameObject NOTE_PREFAB; 
	public GameObject OBSTACLE_PREFAB; 
	public Transform[] spawnPositions; 
	[SerializeField]
	public bool[,] song1; 


	void Awake() {
		song1 = new bool[197, 3]; 
		///here are the song notes you must play
		song1[0,0] = false; song1[0,1] = false; song1[0,2] = false; //1
		song1[1,0] = false; song1[1,1] = true; song1[1,2] = false; //2
		song1[2,0] = false; song1[2,1] = false; song1[2,2] = false; //3
		song1[3,0] = false; song1[3,1] = true; song1[3,2] = false; //4
		song1[4,0] = false; song1[4,1] = true; song1[4,2] = false; //5
		song1[5,0] = false; song1[5,1] = true; song1[5,2] = false; //6
		song1[6,0] = false; song1[6,1] = false; song1[6,2] = false; //7
		song1[7,0] = false; song1[7,1] = true; song1[7,2] = false; //8
		song1[8,0] = false; song1[8,1] = false; song1[8,2] = false; //9
		song1[9,0] = false; song1[9,1] = true; song1[9,2] = false; //10
		song1[10,0] = false; song1[10,1] = false; song1[10,2] = false; //1
		song1[11,0] = false; song1[11,1] = true; song1[11,2] = false; //2
		song1[12,0] = false; song1[12,1] = false; song1[12,2] = false; //3
		song1[13,0] = false; song1[13,1] = true; song1[13,2] = false; //4
		song1[14,0] = false; song1[14,1] = false; song1[14,2] = false; //5
		song1[15,0] = true; song1[15,1] = true; song1[15,2] = false; //6
		song1[16,0] = false; song1[16,1] = false; song1[16,2] = true; //7
		song1[17,0] = false; song1[17,1] = true; song1[17,2] = false; //8
		song1[18,0] = true; song1[18,1] = false; song1[18,2] = false; //9
		song1[19,0] = false; song1[19,1] = true; song1[19,2] = false; //10
		song1[20,0] = false; song1[20,1] = false; song1[20,2] = true; //1
		song1[21,0] = false; song1[21,1] = true; song1[21,2] = true; //2
		song1[22,0] = false; song1[22,1] = false; song1[22,2] = false; //3
		song1[23,0] = false; song1[23,1] = true; song1[23,2] = false; //4
		song1[24,0] = false; song1[24,1] = false; song1[24,2] = false; //5
		song1[25,0] = false; song1[25,1] = true; song1[25,2] = false; //6
		song1[26,0] = false; song1[26,1] = false; song1[26,2] = false; //7
		song1[27,0] = false; song1[27,1] = true; song1[27,2] = false; //8
		song1[28,0] = true; song1[28,1] = false; song1[28,2] = false; //9
		song1[29,0] = false; song1[29,1] = true; song1[29,2] = true; //10
		song1[30,0] = false; song1[30,1] = false; song1[30,2] = true; //1
		song1[31,0] = false; song1[31,1] = true; song1[31,2] = false; //2
		song1[32,0] = false; song1[32,1] = false; song1[32,2] = false; //3
		song1[33,0] = false; song1[33,1] = true; song1[33,2] = false; //4
		song1[34,0] = false; song1[34,1] = false; song1[34,2] = false; //5
		song1[35,0] = false; song1[35,1] = false; song1[35,2] = true; //6
		song1[36,0] = false; song1[36,1] = true; song1[36,2] = false; //7
		song1[37,0] = false; song1[37,1] = false; song1[37,2] = true; //8
		song1[38,0] = false; song1[38,1] = false; song1[38,2] = true; //9
		song1[39,0] = false; song1[39,1] = true; song1[39,2] = false; //10
		song1[40,0] = false; song1[40,1] = false; song1[40,2] = false; //1
		song1[41,0] = false; song1[41,1] = true; song1[41,2] = false; //2
		song1[42,0] = false; song1[42,1] = false; song1[42,2] = false; //3
		song1[43,0] = false; song1[43,1] = true; song1[43,2] = false; //4
		song1[44,0] = false; song1[44,1] = false; song1[44,2] = true; //5
		song1[45,0] = true; song1[45,1] = true; song1[45,2] = false; //6
		song1[46,0] = false; song1[46,1] = false; song1[46,2] = false; //7
		song1[47,0] = false; song1[47,1] = true; song1[47,2] = false; //8
		song1[48,0] = false; song1[48,1] = false; song1[48,2] = false; //9
		song1[49,0] = false; song1[49,1] = true; song1[49,2] = false; //10
		song1[50,0] = false; song1[50,1] = false; song1[50,2] = false; //1
		song1[51,0] = false; song1[51,1] = true; song1[51,2] = false; //2
		song1[52,0] = false; song1[52,1] = true; song1[52,2] = false; //3
		song1[53,0] = false; song1[53,1] = true; song1[53,2] = false; //4
		song1[54,0] = false; song1[54,1] = false; song1[54,2] = false; //5
		song1[55,0] = false; song1[55,1] = true; song1[55,2] = false; //6
		song1[56,0] = false; song1[56,1] = false; song1[56,2] = false; //7
		song1[57,0] = false; song1[57,1] = true; song1[57,2] = false; //8
		song1[58,0] = false; song1[58,1] = false; song1[58,2] = false; //9
		song1[59,0] = false; song1[59,1] = true; song1[59,2] = false; //10
		song1[60,0] = true; song1[60,1] = false; song1[60,2] = false; //1
		song1[61,0] = true; song1[61,1] = false; song1[61,2] = false; //2
		song1[62,0] = false; song1[62,1] = true; song1[62,2] = false; //3
		song1[63,0] = true; song1[63,1] = false; song1[63,2] = false; //4
		song1[64,0] = false; song1[64,1] = false; song1[64,2] = true; //5
		song1[65,0] = false; song1[65,1] = true; song1[65,2] = false; //6
		song1[66,0] = true; song1[66,1] = false; song1[66,2] = false; //7
		song1[67,0] = false; song1[67,1] = true; song1[67,2] = false; //8
		song1[68,0] = false; song1[68,1] = false; song1[68,2] = true; //9
		song1[69,0] = false; song1[69,1] = true; song1[69,2] = false; //10
		song1[70,0] = true; song1[70,1] = false; song1[70,2] = false; //1
		song1[71,0] = false; song1[71,1] = true; song1[71,2] = false; //2
		song1[72,0] = false; song1[72,1] = false; song1[72,2] = true; //3
		song1[73,0] = false; song1[73,1] = true; song1[73,2] = false; //4
		song1[74,0] = true; song1[74,1] = false; song1[74,2] = false; //5
		song1[75,0] = false; song1[75,1] = true; song1[75,2] = false; //6
		song1[76,0] = false; song1[76,1] = false; song1[76,2] = true; //7
		song1[77,0] = false; song1[77,1] = true; song1[77,2] = false; //8
		song1[78,0] = true; song1[78,1] = false; song1[78,2] = false; //9
		song1[79,0] = false; song1[79,1] = true; song1[79,2] = false; //10
		song1[80,0] = false; song1[80,1] = false; song1[80,2] = true; //1
		song1[81,0] = false; song1[81,1] = true; song1[81,2] = false; //2
		song1[82,0] = true; song1[82,1] = false; song1[82,2] = false; //3
		song1[83,0] = false; song1[83,1] = true; song1[83,2] = false; //4
		song1[84,0] = false; song1[84,1] = false; song1[84,2] = true; //5
		song1[85,0] = false; song1[85,1] = true; song1[85,2] = false; //6
		song1[86,0] = true; song1[86,1] = false; song1[86,2] = false; //7
		song1[87,0] = false; song1[87,1] = true; song1[87,2] = false; //8
		song1[88,0] = false; song1[88,1] = false; song1[88,2] = true; //9
		song1[89,0] = false; song1[89,1] = true; song1[89,2] = false; //10
		song1[90,0] = true; song1[90,1] = false; song1[90,2] = false; //1
		song1[91,0] = false; song1[91,1] = true; song1[91,2] = false; //2

		song1[92,0] = true; song1[92,1] = false; song1[92,2] = false; //3
		song1[93,0] = false; song1[93,1] = true; song1[93,2] = false; //4
		song1[94,0] = false; song1[94,1] = false; song1[94,2] = true; //5
		song1[95,0] = false; song1[95,1] = false; song1[95,2] = true; //6
		song1[96,0] = false; song1[96,1] = true; song1[96,2] = false; //7
		song1[97,0] = true; song1[97,1] = false; song1[97,2] = false; //8
		song1[98,0] = true; song1[98,1] = false; song1[98,2] = false; //9
		song1[99,0] = false; song1[99,1] = true; song1[99,2] = false; //10
		song1[100,0] = false; song1[100,1] = false; song1[100,2] = true; //1
		song1[101,0] = false; song1[101,1] = false; song1[101,2] = true; //2
		song1[102,0] = false; song1[102,1] = true; song1[102,2] = false; //3
		song1[103,0] = true; song1[103,1] = false; song1[103,2] = false; //4
		song1[104,0] = true; song1[104,1] = false; song1[104,2] = false; //5
		song1[105,0] = false; song1[105,1] = true; song1[105,2] = false; //6
		song1[106,0] = false; song1[106,1] = false; song1[106,2] = true; //7
		song1[107,0] = false; song1[107,1] = false; song1[107,2] = true; //8
		song1[108,0] = false; song1[108,1] = true; song1[108,2] = false; //9
		song1[109,0] = true; song1[109,1] = false; song1[109,2] = false; //10
		song1[110,0] = true; song1[110,1] = false; song1[110,2] = false; //9
		song1[111,0] = false; song1[111,1] = true; song1[111,2] = false; //10
		song1[112,0] = false; song1[112,1] = false; song1[112,2] = true; //1
		song1[113,0] = false; song1[113,1] = false; song1[113,2] = true; //2
		song1[114,0] = false; song1[114,1] = true; song1[114,2] = false; //3
		song1[115,0] = true; song1[115,1] = false; song1[115,2] = false; //4
		song1[116,0] = true; song1[116,1] = false; song1[116,2] = false; //5
		song1[117,0] = false; song1[117,1] = true; song1[117,2] = false; //6
		song1[118,0] = false; song1[118,1] = false; song1[118,2] = true; //7
		song1[119,0] = false; song1[119,1] = false; song1[119,2] = true; //8
		song1[120,0] = false; song1[120,1] = true; song1[120,2] = false; //9
		song1[121,0] = true; song1[121,1] = false; song1[121,2] = false; //10
		song1[122,0] = true; song1[122,1] = false; song1[122,2] = false; //1
		song1[123,0] = false; song1[123,1] = true; song1[123,2] = false; //2
		song1[124,0] = false; song1[124,1] = false; song1[124,2] = true; //3

		song1[125,0] = false; song1[125,1] = true; song1[125,2] = false; //4
		song1[126,0] = false; song1[126,1] = false; song1[126,2] = false; //5
		song1[127,0] = false; song1[127,1] = true; song1[127,2] = false; //6
		song1[128,0] = false; song1[128,1] = false; song1[128,2] = false; //7
		song1[129,0] = false; song1[129,1] = true; song1[129,2] = false; //8
		song1[130,0] = false; song1[130,1] = false; song1[130,2] = false; //9
		song1[131,0] = false; song1[131,1] = true; song1[131,2] = false; //10
		song1[132,0] = false; song1[132,1] = false; song1[132,2] = false; //1
		song1[133,0] = false; song1[133,1] = true; song1[133,2] = false; //2
		song1[134,0] = false; song1[134,1] = false; song1[134,2] = false; //3
		song1[135,0] = false; song1[135,1] = true; song1[135,2] = false; //4
		song1[136,0] = false; song1[136,1] = false; song1[136,2] = false; //5
		song1[137,0] = false; song1[137,1] = true; song1[137,2] = false; //6
		song1[138,0] = false; song1[138,1] = false; song1[138,2] = false; //7
		song1[139,0] = false; song1[139,1] = true; song1[139,2] = false; //8
		song1[140,0] = false; song1[140,1] = false; song1[140,2] = false; //9

		song1[141,0] = true; song1[141,1] = true; song1[141,2] = false; //10
		song1[142,0] = false; song1[142,1] = false; song1[142,2] = false; //1
		song1[143,0] = false; song1[143,1] = true; song1[143,2] = true; //2
		song1[144,0] = false; song1[144,1] = false; song1[144,2] = false; //3
		song1[145,0] = true; song1[145,1] = true; song1[145,2] = false; //4
		song1[146,0] = false; song1[146,1] = false; song1[146,2] = false; //5
		song1[147,0] = false; song1[147,1] = true; song1[147,2] = true; //6
		song1[148,0] = false; song1[148,1] = false; song1[148,2] = false; //7
		song1[149,0] = true; song1[149,1] = false; song1[149,2] = true; //8
		song1[150,0] = true; song1[150,1] = false; song1[150,2] = false; //9
		song1[151,0] = false; song1[151,1] = true; song1[151,2] = false; //10
		song1[152,0] = false; song1[152,1] = false; song1[152,2] = false; //1
		song1[153,0] = false; song1[153,1] = true; song1[153,2] = true; //2
		song1[154,0] = false; song1[154,1] = false; song1[154,2] = false; //3
		song1[155,0] = true; song1[155,1] = true; song1[155,2] = false; //4
		song1[156,0] = false; song1[156,1] = false; song1[156,2] = false; //5
		song1[157,0] = true; song1[157,1] = false; song1[157,2] = true; //6
		song1[158,0] = true; song1[158,1] = false; song1[158,2] = false; //7
		song1[159,0] = false; song1[159,1] = true; song1[159,2] = true; //8
		song1[160,0] = false; song1[160,1] = false; song1[160,2] = false; //9
		song1[161,0] = true; song1[161,1] = true; song1[161,2] = true; //10
		song1[162,0] = false; song1[162,1] = false; song1[162,2] = false; //1
		song1[163,0] = true; song1[163,1] = true; song1[163,2] = true; //2
		song1[164,0] = false; song1[164,1] = false; song1[164,2] = false; //3
		song1[165,0] = false; song1[165,1] = true; song1[165,2] = false; //4
		song1[166,0] = false; song1[166,1] = true; song1[166,2] = true; //5
		song1[167,0] = false; song1[167,1] = true; song1[167,2] = false; //6
		song1[168,0] = true; song1[168,1] = true; song1[168,2] = false; //7
		song1[169,0] = false; song1[169,1] = true; song1[169,2] = false; //8
		song1[170,0] = false; song1[170,1] = false; song1[170,2] = true; //9
		song1[171,0] = false; song1[171,1] = true; song1[171,2] = false; //10
		song1[172,0] = true; song1[172,1] = false; song1[172,2] = false; //1
		song1[173,0] = false; song1[173,1] = true; song1[173,2] = false; //2
		song1[174,0] = false; song1[174,1] = false; song1[174,2] = true; //3
		song1[175,0] = false; song1[175,1] = true; song1[175,2] = false; //4
		song1[176,0] = true; song1[176,1] = false; song1[176,2] = false; //5
		song1[177,0] = false; song1[177,1] = true; song1[177,2] = true; //6

		song1[178,0] = true; song1[178,1] = false; song1[178,2] = false; //7
		song1[179,0] = true; song1[179,1] = false; song1[179,2] = false; //8
		song1[180,0] = false; song1[180,1] = true; song1[180,2] = false; //9
		song1[181,0] = false; song1[181,1] = true; song1[181,2] = false; //10
		song1[182,0] = false; song1[182,1] = false; song1[182,2] = true; //1
		song1[183,0] = false; song1[183,1] = false; song1[183,2] = true; //2
		song1[184,0] = false; song1[184,1] = true; song1[184,2] = false; //3
		song1[185,0] = false; song1[185,1] = true; song1[185,2] = false; //4
		song1[186,0] = true; song1[186,1] = false; song1[186,2] = false; //5
		song1[187,0] = true; song1[187,1] = false; song1[187,2] = false; //6
		song1[188,0] = false; song1[188,1] = true; song1[188,2] = false; //7
		song1[189,0] = false; song1[189,1] = true; song1[189,2] = false; //8
		song1[190,0] = false; song1[190,1] = false; song1[190,2] = true; //9
		song1[191,0] = false; song1[191,1] = false; song1[191,2] = true; //10
		song1[192,0] = false; song1[192,1] = true; song1[192,2] = false; //1
		song1[193,0] = false; song1[193,1] = true; song1[193,2] = false; //2
		song1[194,0] = false; song1[194,1] = false; song1[194,2] = false; //3
		song1[195,0] = false; song1[195,1] = true; song1[195,2] = false; //4
		song1[196,0] = false; song1[196,1] = false; song1[196,2] = false; //5



	}

	void Start() {
		StartCoroutine (launchTaps()); 
	}

	IEnumerator launchTaps() {
		for (int i = 0; i < 197; i++) {
			if (song1 [i, 0] == true) {
				Instantiate (NOTE_PREFAB, spawnPositions [0].position, this.transform.rotation);

			} else {
				Instantiate (OBSTACLE_PREFAB, spawnPositions [0].position, Quaternion.identity);
			}
			if (song1 [i, 1] == true) {
				Instantiate (NOTE_PREFAB, spawnPositions [1].position, this.transform.rotation); 

			}
			if (song1 [i, 2] == true) {
				Instantiate (NOTE_PREFAB, spawnPositions [2].position, this.transform.rotation);

			}else {
				Instantiate (OBSTACLE_PREFAB, spawnPositions [2].position, Quaternion.identity);
			}
			yield return new WaitForSeconds (0.3973509934f); 
		}
		//2.516666
	}
}
