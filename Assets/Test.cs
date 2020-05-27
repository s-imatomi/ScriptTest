using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;    // マジックポイント

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic()
    {
        if(mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // 要素が5のint型配列arrayを宣言して好きな値で初期値
        int[] array = new int[5] { 10, 20, 30, 40, 50};

        // for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < array.Length; i++) { Debug.Log(array[i]); }

        // for文を使い、配列の各要素の値を逆順に表示
        for (int i = array.Length-1; i >= 0; i--) { Debug.Log(array[i]); }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        for (int i = 0; i < 11; i++) {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}