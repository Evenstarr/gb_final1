/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 */

//string[] initial = {"hello", "2", "world"};
// string[] initial = {"1234", "1567", "-2", "computer science"};
string[] initial = {"12", "15", "-2", "co"};

string[] newArrTmp = new string[initial.Length];

int iter = 0;
for (int i = 0; i < newArrTmp.Length; i++) {
    if (initial[i].Length <= 3) {
        newArrTmp[iter] = initial[i];
        iter++;
    }
}

string[] TrimToRealSize(string[] arr, int size) {
    if (arr.Length == size) {
        return arr;
    } else {
        string[] tmpArr = new string[size];

        for (int i = 0; i < size; i++) {
            tmpArr[i] = arr[i];
        }
        return tmpArr;
    }
}

void Print1DStringArray(string[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();    
}

string[] resultArr = TrimToRealSize(newArrTmp, iter);
Print1DStringArray(resultArr);
