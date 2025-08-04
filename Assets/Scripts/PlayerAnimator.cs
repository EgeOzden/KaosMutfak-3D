using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    private const string is_walking = "IsWalking"; //buton ismi değişkene sabit atandı.
    [SerializeField] private Player player; // player oyun objesi eklenir. bunun scriptindeki IsWalking methodu çağırılacak.
    private Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    void Update() // her frame için kontrol
    {
        animator.SetBool(is_walking, player.IsWalking()); //animatordeki ilgili parametreyi dönüşe göre true false yapar.
    }
}
