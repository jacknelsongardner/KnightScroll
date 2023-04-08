﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    public GameObject gameBrain;
    public GameObject boardParent;

    public int boardX;
    public int boardY;

    public int highestBoardY;

    private int DEAD;
    private int ALIVE;

    public int status;

    public bool canMove;

    public float deathHeight;

    // Start is called before the first frame update
    void Start()
    {
        DEAD = 0;
        ALIVE = 1;

        highestBoardY = 0;
        status = 1;

        canMove = true;

        this.transform.SetParent(boardParent.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (highestBoardY < boardY)
        {
            highestBoardY = boardY;
        }
    }

    public bool testHeightDeath()
    {
        float actualHeight = this.transform.TransformPoint(this.transform.position).y;

        if (actualHeight <= deathHeight)
        {
            Debug.Log(actualHeight);
            this.canMove = false;

            gameBrain.GetComponent<BrainScript>().Lose();
            return true;
        }

        return false;
        
    }

    public bool knightCanMove(int tileY, int tileX)
    {
        if (canMove == true)
        {
            if (tileY == this.boardY + 2)
            {
                if (tileX == this.boardX + 1)
                {
                    return true;
                }
                else if (tileX == this.boardX - 1)
                {
                    return true;
                }
            }
            else if (tileY == this.boardY - 2)
            {
                if (tileX == this.boardX + 1)
                {
                    return true;
                }
                else if (tileX == this.boardX - 1)
                {
                    return true;
                }
            }
            else if (tileY == this.boardY + 1)
            {
                if (tileX == this.boardX + 2)
                {
                    return true;
                }
                else if (tileX == this.boardX - 2)
                {
                    return true;
                }
            }
            else if (tileY == this.boardY - 1)
            {
                if (tileX == this.boardX + 2)
                {
                    return true;
                }
                else if (tileX == this.boardX - 2)
                {
                    return true;
                }
            }
        }
        else if (canMove == false)
        {
            Debug.Log("can't move!");
            return false;
        }



        Debug.Log("can't go there!!!" + tileY);
        
        return false;
    }
}
