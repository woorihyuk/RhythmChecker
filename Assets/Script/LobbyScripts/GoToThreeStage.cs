using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToThreeStage : MonoBehaviour
{
    public void GoThreeStage()
    {
        SceneManager.LoadScene("");//괄호 안에 세번째 스테이지 이름 추가
    }
}
