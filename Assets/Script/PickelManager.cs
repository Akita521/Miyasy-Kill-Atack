using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickelManager : MonoBehaviour
{
    public GameObject pickelObject;

    Animator animator;�@//animator��錾

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();�@//�錾����animator�ɁAAnimator�R���|�[�l���g���擾����
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = 84;
        var pos = Camera.main.ScreenToWorldPoint(mousePosition);
        pickelObject.transform.position = pos;

        if (Input.GetMouseButtonDown(0))�@//�}�E�X�N���b�N�����擾����
        {
            //Debug.Log("���͂���Ă�");�@//�}�E�X�N���b�N�������Ă��邩�ǂ����́A�m�F���O
            animator.SetTrigger("Attack");�@//SetTrigger��Attack�𔭓�������
        }

    }

}
