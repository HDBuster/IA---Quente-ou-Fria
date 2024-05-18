using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeuralNetwork;
using UnityEngine.UI;

public class QuenteOuFria : MonoBehaviour
{
    //Neural Network Variables
    private const double minimumError = 0.1;
    private static NeuralNet net;
    private static List<DataSet> dataSets;

    public Image background;

    public GameObject pointer1;
    public GameObject pointer2;

    bool trained;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Input - 3 (r,g,b) -- Output - 1 (Hot/Cold)
        net = new NeuralNet(3,4,1);
        dataSets = new List<DataSet>();
        Next();
    }

    void Next()
    {
        Color c = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        background.color = c;
        double[] C = { (double)background.color.r, (double)background.color.g, (double)background.color.b };

        if (trained)
        {
            double d = tryValues(C);
            if (d > 0.5)
            {
                pointer1.SetActive(false);
                pointer2.SetActive(true);
            }
            else
            {
                pointer1.SetActive(true);
                pointer2.SetActive(false);
            }
        }
    }

    public void Train(float val)
    {
        double[] C = { (double)background.color.r, (double)background.color.g, (double)background.color.b };
        double[] v = { (double)val };
        dataSets.Add(new DataSet(C, v));

        i++;
        if (!trained && i % 10 == 9)
            Train();

        Next();
    }

    private void Train()
    {
        net.Train(dataSets, minimumError);
        trained = true;
    }

    double tryValues(double[] vals)
    {
        double[] result = net.Compute(vals);
        return result[0];
    }
}
