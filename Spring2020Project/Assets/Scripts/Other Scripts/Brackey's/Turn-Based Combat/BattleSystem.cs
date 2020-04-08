using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*I LOVED Learning this, and even could fill in stuff myself without help,
My Progress has doubled in the last 4 months!*/

public enum BattleState{START, PLAYERTURN, ENEMYTURN, WIN, LOSE}

public class BattleSystem : MonoBehaviour
{
    #region Variables
    
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    private Unit playerUnit, enemyUnit;

    public Transform playerBattleStation, enemyBattleStation;

    public Text dialogueText;
    
    public BattleState state;

    public BattleHud playerHud, enemyHud;
    
    #endregion
    
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        GameObject playerGameObject = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGameObject.GetComponent<Unit>();

        GameObject enemyGameObject = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGameObject.GetComponent<Unit>();

        dialogueText.text = "A wild" + enemyUnit.unitName + " approaches . . .";
        
        playerHud.setHud(playerUnit);
        playerHud.setHud(enemyUnit);
        
        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    #region PlayerChoices
    
    private void PlayerTurn()
    {
        dialogueText.text = "What will " + playerUnit.unitName + " do?";
    }

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
        {return;}

        StartCoroutine(PlayerAttack());
    }
    
    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
        enemyHud.SetHP(enemyUnit.currentHp);
        dialogueText.text = "The Attack is Successful!";
        
        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            state = BattleState.WIN;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }
    
    public void OnHealButton()
    {
        if (state != BattleState.PLAYERTURN)
        {return;}

        StartCoroutine(PlayerHeal());
    }
    
    IEnumerator PlayerHeal()
    {
        playerUnit.Heal(5);
        playerHud.SetHP(playerUnit.currentHp);
        dialogueText.text = "You used a Potion!";
        yield return new WaitForSeconds(2f);

        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }
    
    #endregion

    #region EnemyChoices

    IEnumerator EnemyTurn()
    {
        //Enemy AI

        dialogueText.text = enemyUnit.unitName + " Attacks:";
        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
        playerHud.SetHP(playerUnit.currentHp);
        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState.LOSE;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }
    
    #endregion
    
    private void EndBattle()
    {
        if (state == BattleState.WIN)
        {
            dialogueText.text = "You Beat " + enemyUnit.unitName + "!";
        }
        else if(state == BattleState.LOSE)
        {
            dialogueText.text = "You lost to " + enemyUnit.unitName + ":(";
        }
    }
}
