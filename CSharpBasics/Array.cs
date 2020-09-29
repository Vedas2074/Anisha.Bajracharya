class Array
{
    void Learn1DArray()
    {
        byte[] array1 = new byte[10];
        array1[0] = 23;
        array1[1] = 28;

        float[] array2 = new float[] {2.1f, 34.5f, 67.23f};
        var x = array2.Length;

        char[] array3 = { 'A', 'B', 'C', 'D'};

        float[] subArray1 = array2[1..3]; //Here, .. is range operator
    }

    void LearnMulDArray()
    {
        //2D Array
        int[,] numbers = new int[3,4];
        numbers[0,0] = 345345;
        numbers[2,3] = -3453;


        decimal[,] numbers2 = {{2.3m, 34.5m}, {56.4m, 12.56m}};
    }

    void LearnJaggedArray()
    {
        short[][] numbers = new short[4][];
        numbers[0] = new short[] {3, 4, 5};
        numbers[1] = new short[] {3, 4};
        numbers[0] = new short[] {3, 4, 5, 12};


    }
}