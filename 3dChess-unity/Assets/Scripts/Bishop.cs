﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool [,] r = new bool [8,8];
        int i,j;
        Chessman c;

        //Diagonal up left
        i = CurrentX;
        j = CurrentY;
        while(true)
        {
            i--;
            j++;
            if(i < 0 || j >= 8) break;
            c = BoardManager.Instance.Chessmans[i,j];
            if(c == null) r[i,j] = true;
            else
            {
                if(isWhite != c.isWhite) r[i,j] = true;
                break;       
            }
        }
        //Diagonal up right
        i = CurrentX;
        j = CurrentY;
        while(true)
        {
            i++;
            j++;
            if(i >= 8 || j >= 8) break;
            c = BoardManager.Instance.Chessmans[i,j];
            if(c == null) r[i,j] = true;
            else
            {
                if(isWhite != c.isWhite) r[i,j] = true;
                break;       
            }
        }

         //Diagonal down left
        i = CurrentX;
        j = CurrentY;
        while(true)
        {
            i--;
            j--;
            if(i < 0 || j < 0) break;
            c = BoardManager.Instance.Chessmans[i,j];
            if(c == null) r[i,j] = true;
            else
            {
                if(isWhite != c.isWhite) r[i,j] = true;
                break;       
            }
        }
         //Diagonal down right
        i = CurrentX;
        j = CurrentY;
        while(true)
        {
            i++;
            j--;
            if(i >=8 || j < 0) break;
            c = BoardManager.Instance.Chessmans[i,j];
            if(c == null) r[i,j] = true;
            else
            {
                if(isWhite != c.isWhite) r[i,j] = true;
                break;       
            }
        }
        return r;
    }
}
