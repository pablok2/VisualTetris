using UnityEngine;
using System.Collections;

public class TetrisMusicBlocks : MonoBehaviour {

    static class WaveNoteFreq
    {
        // 4th octave (mostly)
        public static float A = 220f;
        public static float Asharp = 466.16f;
        public static float B = 246.94f;
        public static float C = 261.63f;
        public static float Csharp = 277.18f;
        public static float D = 293.66f;
        public static float Dsharp = 311.13f;
        public static float E = 329.63f;
        public static float F = 349.23f;
        public static float Fsharp = 369.99f;
        public static float G = 392f;
        public static float Gsharp = 415.30f;
    }

    static class WaveNoteLength
    {
        public static float Whole = 1.00f;
        public static float ThreeQuarters = 0.75f;
        public static float Half = 0.50f;
        public static float Quarter = 0.25f;
        public static float Eighth = 0.125f;
    }

    float[] tetrisNoteSequence =
        {
            WaveNoteFreq.E, WaveNoteFreq.B, WaveNoteFreq.C, WaveNoteFreq.D,
            WaveNoteFreq.C, WaveNoteFreq.B, WaveNoteFreq.A, WaveNoteFreq.A,
            WaveNoteFreq.C, WaveNoteFreq.E, WaveNoteFreq.D, WaveNoteFreq.C, WaveNoteFreq.B,
            WaveNoteFreq.C, WaveNoteFreq.D, WaveNoteFreq.E, WaveNoteFreq.C, WaveNoteFreq.A
        };

    float[] tetrisNoteLength =
        {
            WaveNoteLength.Quarter, WaveNoteLength.Eighth, WaveNoteLength.Eighth, WaveNoteLength.Quarter,
            WaveNoteLength.Eighth, WaveNoteLength.Eighth, WaveNoteLength.Quarter, WaveNoteLength.Eighth,
            WaveNoteLength.Eighth, WaveNoteLength.Quarter, WaveNoteLength.Eighth, WaveNoteLength.Eighth, WaveNoteLength.ThreeQuarters,
            WaveNoteLength.Eighth, WaveNoteLength.Quarter, WaveNoteLength.Quarter, WaveNoteLength.Quarter, WaveNoteLength.Half
        };

    public GameObject noteBlock;

    // Use this for initialization
    void Start () {

        // Create the blocks in accordance to their height and length

        // Place them on the map, one after the other
        GameObject create = noteBlock;
        float spacing = 0;
        foreach (var note in tetrisNoteSequence)
        {
            create.transform.localScale = new Vector3(1, (note / 10), 1);
            Instantiate(create, new Vector3(-6 + spacing, -10, 13), Quaternion.identity);
            spacing += 1.5f;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
