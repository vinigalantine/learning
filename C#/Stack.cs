class Pilha
{
    private double[] arr;
    private int Top { get; set; }

    public Pilha(int tam = 0) // CONSTRUTOR
    {
        if (tam == 0)
        arr = new double[100];
        else
        arr = new double[tam];

        Top = 0;
    }

    public int getTop()
    {
        return Top;
    }

    public bool FullStack()
    {
        return (Top == arr.Length);
    }

    public bool Clear()
    {
        return (Top == 0);
    }

    public void Push(double x)
    {
        arr[Top] = x;
        Top++;
    }

    public double Pop()
    {
        if (Top == 0)
        return 0;

        Top--;
        double temp = arr[Top];
        arr = arr.Where((val, idx) => idx != Top).ToArray();
        return (temp);
    }

}
