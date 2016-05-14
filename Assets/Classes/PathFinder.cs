using UnityEngine;
using System.Collections;

public class PathFinder
{
    Coordinates coords;
    int[,] lab;

    int final;
    int ym;
    int xm;

    public PathFinder(int[,] lab, Coordinates st, Coordinates fin, int y, int x)
    {
        this.lab = lab;
        final = y * x + 1;
        this.lab[st.y, st.x] = 1;
        this.lab[fin.y, fin.x] = final;
        ym = y;
        xm = x;
    }

    public void Find()
    {
        int wave = 1;
        int k = 0;
        while (k == 0)
        {
            wave++;
            for (int i = 0; i < ym; i++)
            {
                for (int j = 0; j < xm; j++)
                {
                    if (lab[i, j] == wave - 1)
                    {
                        if ((i < ym - 1 && lab[i + 1, j] == final) || (i > 0 && lab[i - 1, j] == final) || (j < xm - 1 && lab[i, j + 1] == final) || (j > 0 && lab[i, j - 1] == final))
                        {
                            k++;
                            break;
                        }
                        else
                        {
                            if (i < ym - 1 && lab[i + 1, j] == 0)
                            {
                                lab[i + 1, j] = wave;
                            }
                            if (i > 0 && lab[i - 1, j] == 0)
                            {
                                lab[i - 1, j] = wave;
                            }
                            if (j < xm - 1 && lab[i, j + 1] == 0)
                            {
                                lab[i, j + 1] = wave;
                            }
                            if (j > 0 && lab[i, j - 1] == 0)
                            {
                                lab[i, j - 1] = wave;
                            }
                        }

                    }
                }
            }
        }
    }

	
}
