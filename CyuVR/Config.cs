﻿using UnityEngine;

namespace Bero.CyuVR
{
	public class Config : MonoBehaviour
	{
		public static float kissDistance;
		public static float kissDistanceAibu;
		public static float eyesMovement;
		public static Cyu.FrenchMode tongueMovement;
		public static float mouthOffset;
		public static float kissNeckAngle;
		public static float kissMotionSpeed;

		private void Awake()
		{
			kissDistance = float.Parse(BepInEx.Config.GetEntry("KissDistance", "0.18", "Cyu"));
			kissDistanceAibu = float.Parse(BepInEx.Config.GetEntry("KissDistanceAibu", "0.35", "Cyu"));
			eyesMovement = float.Parse(BepInEx.Config.GetEntry("EyesMovement", "45", "Cyu"));
			tongueMovement = (Cyu.FrenchMode) int.Parse(BepInEx.Config.GetEntry("TongueMovement", "1", "Cyu"));
			mouthOffset = float.Parse(BepInEx.Config.GetEntry("MouthOffset", "0.12", "Cyu"));
			kissNeckAngle = float.Parse(BepInEx.Config.GetEntry("KissNeckAngle", "0.2", "Cyu"));
			kissMotionSpeed = float.Parse(BepInEx.Config.GetEntry("KissMotionSpeed", "0.1", "Cyu"));
			kissMotionSpeed = Mathf.Clamp(kissMotionSpeed, 0.1f, 1.5f);
		}
	}
}
