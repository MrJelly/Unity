using UnityEngine;  
using System.Collections;  

public class LightController : MonoBehaviour {  

	private Light _light;  

	void Awake(){  
		_light = GetComponent<Light> ();  
	}  

	void  Update(){  
		//当前的脚步就是状态机  
		//用户按键时间就是状态切换的条件——事件  
		if(Input.GetKeyDown(KeyCode.O)){  

			//灯的光强从0变为1时，就是状态的过渡  
			//打开灯  
			//灯开着的状态  
			_light.intensity=1f;  

		}  

		if(Input.GetKeyDown(KeyCode.C)){  

			//灯的光强从1变为0时，就是状态的过渡  
			//关闭灯  
			//灯处于关着的状态  
			_light.intensity=0f;  

		}  
	}  
}