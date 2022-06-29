		using System.Collections;
		using System.Collections.Generic;
		using UnityEngine;
		using System;

		public class CommunicateManager : MonoBehaviour
		{
			//var
			public SerialPortUtility.SerialPortUtilityPro serialPort = null;

			// Use this for initialization
			void Start()
			{
				LogConnectedDeviceList();
			}

			// Update is called once per frame
			void Update()
			{
				if (serialPort != null)
				{
					if (Input.GetKeyDown(KeyCode.A))
					{
						// LED ON
						serialPort.WriteCRLF("1");
						Debug.Log("A");
					}
					if (Input.GetKeyDown(KeyCode.B))
					{
						// LED OFF
						serialPort.WriteCRLF("2");
					Debug.Log("B");
				}
			}
			}

			//for String data
			public void ReadComplateString(object data)
			{
				var text = data as string;
				Debug.Log(text);
			}

			//Deviceinfo
			public void LogConnectedDeviceList()
			{
				SerialPortUtility.SerialPortUtilityPro.DeviceInfo[] devicelist =
					SerialPortUtility.SerialPortUtilityPro.GetConnectedDeviceList(serialPort.OpenMethod);

				foreach (SerialPortUtility.SerialPortUtilityPro.DeviceInfo d in devicelist)
				{
					Debug.Log("VendorID:" + d.Vendor + " DeviceName:" + d.PortName);
				}
			}
		}
