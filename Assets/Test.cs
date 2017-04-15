using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔力

    // 攻撃用の関数
    public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
    }
    
    // 防御用の関数
    public void Defence(int damage){
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic(){
        // MPが残っているかの判定
        if (mp >= 5){
            // MP残アリ
            mp = mp - 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else {
            // MP残ナシ
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{

    void Start(){
        // int型の配列arrayを宣言
        int[] array = { 1, 2, 3, 4, 5 };

　　    // 配列arrayの値を表示
        for (int i = 0; i < array.Length; i++){
            Debug.Log(array[i]);
        }
    　　// 配列arrayの値を逆から表示
        for (int i = array.Length -1 ; i >= 0; i--){
            Debug.Log(array[i]);
        }

            // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

            // 攻撃用の関数を呼び出す
            lastboss.Attack();
            // 防御用の関数を呼び出す
            lastboss.Defence(3);

            // 魔法攻撃用の関数を呼び出す
            for (int i = 0; i < 11; i++){
            lastboss.Magic();
            }

    }
    // Update is called once per frame
    void Update () {
		
	}
}