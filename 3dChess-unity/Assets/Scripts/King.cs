using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8,8];
        
        //Up
        KingMove(CurrentX, CurrentY+1, ref r);

        //Down
        KingMove(CurrentX, CurrentY-1, ref r);

        //Left
        KingMove(CurrentX-1, CurrentY, ref r);

        //Right
        KingMove(CurrentX+1, CurrentY, ref r);

        //Left up
        KingMove(CurrentX-1, CurrentY+1, ref r);

        //Left down
        KingMove(CurrentX-1, CurrentY-1, ref r);

        //Right up
        KingMove(CurrentX+1, CurrentY+1, ref r);

        //Right down
        KingMove(CurrentX+1, CurrentY-1, ref r);

        return r;
    }

    public void KingMove(int x, int y, ref bool[,] r)
    {
        Chessman c;
        if (x >= 0 && x < 8 && y >= 0 && y < 8)
        {
            c = BoardManager.Instance.Chessmans[x,y];
            if(c== null) r[x,y] = true;
            else if (isWhite != c.isWhite) r[x,y] = true;
        }
    }
}
