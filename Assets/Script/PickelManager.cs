using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickelManager : MonoBehaviour
{
    public GameObject pickelObject;

    Animator animator;　//animatorを宣言

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();　//宣言したanimatorに、Animatorコンポーネントを取得する
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = 84;
        var pos = Camera.main.ScreenToWorldPoint(mousePosition);
        pickelObject.transform.position = pos;

        if (Input.GetMouseButtonDown(0))　//マウスクリック情報を取得する
        {
            //Debug.Log("入力されてる");　//マウスクリックが入っているかどうかの、確認ログ
            animator.SetTrigger("Attack");　//SetTriggerでAttackを発動させる
        }

    }

}
