namespace Arrays{
 class Program{
    static void Main(string[] args){
        //single dimensional array
        Console.WriteLine("This is a single dimensional array");
        int[] arr = [10, 20, 30, 40, 50];
            for (int i = 0; i < arr.Length; i++){
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
        //multi-dimensional array
        Console.WriteLine("This is a multi-dimensional array");
        int[,] arr2 = new int[2, 2];
        arr2[0, 0] = 10;
        arr2[0, 1] = 20;
        arr2[1, 0] = 30;
        arr2[1, 1] = 40;
        for (int i = 0; i < 2; i++){
            for (int j = 0; j < 2; j++){
                Console.Write(arr2[i, j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //jagged array
        Console.WriteLine("This is a jagged array");
        int[][] arr3 = new int[2][];
        arr3[0] = new int[2];
        arr3[1] = new int[3];
        arr3[0][0] = 10;
        arr3[0][1] = 20;
        arr3[1][0] = 30;
        arr3[1][1] = 40;
        arr3[1][2] = 50;
        for (int i = 0; i < 2; i++){
            for (int j = 0; j < arr3[i].Length; j++){
                Console.Write(arr3[i][j]+" ");
            }
                Console.WriteLine();
        }

    }
 }
}