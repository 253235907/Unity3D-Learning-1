﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate1 : MonoBehaviour {

	public Transform origin;    //各天体公转的圆心
	public float gspeed;        //公转速度
	public float zspeed;        //自转速度
	public float ry, rz;        //通过y轴、z轴调整公转的偏心率，使其不在同一平面公转
	public float radius;
	public Vector3 axis;	    //公转轴

	void Start() {
		transform.position = origin.position + new Vector3 (radius,0,0);
		axis = new Vector3 (0, ry, rz);    //公转轴
	}

	void Update () {
		this.transform.RotateAround (origin.position, axis, gspeed * Time.deltaTime);   //公转
		this.transform.Rotate (Vector3.up * zspeed * Time.deltaTime);       //自转
	}  
}