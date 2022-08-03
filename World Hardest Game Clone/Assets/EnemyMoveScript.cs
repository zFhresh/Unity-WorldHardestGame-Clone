using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EnemyMoveScript : MonoBehaviour
{
    [Header("To do Location Settings")]
    [SerializeField] private Transform ToDoPozition;
    private Transform ObjectPosition;

    private void Start()
    {
        ToDoPozition = transform.GetChild(1);
        ObjectPosition = transform.GetChild(0);

        ObjectPosition.DOMove(ToDoPozition.position, 1).SetLoops(-1,LoopType.Yoyo);
    }
}
