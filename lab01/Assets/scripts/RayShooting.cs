using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayShooting : MonoBehaviour {
    AudioSource gunAudio;
    LineRenderer laserLine;
    int score = 0;
    int hitNum = 0;
    int sendNum = 0;
    private Camera fpsCam;
    public Transform GunEnd;

    //血条
    public Slider v_slider;

    //文字提示,得分
    public Text showValueText;
    //击毙目标数
    public Text showhitText;
    //发射子弹数
    public Text showsendText;

    

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        gunAudio = GetComponent<AudioSource>();
        laserLine = this.GetComponent<LineRenderer>();
        fpsCam = GetComponentInChildren<Camera>();        
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {

            sendNum += 1;
            //发射子弹数提示
            showsendText.text = "发射子弹数："+sendNum;

            gunAudio.Play();
            laserLine.enabled = true;
            //获取摄像机的位置
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f,0.5f, 0.0f));
            //用于存放碰撞信息
            RaycastHit hit;
            //在线条上设置线条的顶点位置。
            laserLine.SetPosition(0,GunEnd.position);
            
            //射线碰撞检测
            if(Physics.Raycast(rayOrigin,fpsCam.transform.forward,out hit))
            {
                laserLine.SetPosition(1,hit.point);
                print(hit.collider.tag);
                if(hit.collider.tag == "Block")
                {
                    
                    score += 5;
                    hitNum += 1;
                    //血条展示
                    v_slider.value = score;
                    //得分提示
                    showValueText.text = "分数："+score;                    
                    //击中目标数提示
                    showhitText.text = "击毙目标数：" + hitNum;

                    Destroy(hit.collider.gameObject);
                    print("score = "+score);
                }
            }
            else
            {
                laserLine.SetPosition(1,rayOrigin+(fpsCam.transform.forward*100f));
            }

            //发射射线0.3秒后消失
            Invoke("RayDisappear", 0.3f);
        }
	}

    void RayDisappear()
    {
        laserLine.enabled = false;
    }
}
