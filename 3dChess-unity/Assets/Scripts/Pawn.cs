using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8,8];
        Chessman c, c2;

        //White team move
        if(isWhite)
        {
            //Diagonal left
            if(CurrentX != 0 && CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX-1, CurrentY+1];
                if (c != null && !c.isWhite)
                {
                    r[CurrentX-1, CurrentY+1] = true;
                }
            }

            //Diagonal right
            if(CurrentX != 7 && CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX+1, CurrentY+1];
                if (c != null && !c.isWhite)
                {
                    r[CurrentX+1, CurrentY+1] = true;
                }
            }

            //Middle
            if(CurrentY != 7)
            {
                
            }

            //Middle on first move

        }
        else
        {

        }
        

        return r;
    }

}
