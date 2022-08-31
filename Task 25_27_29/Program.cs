// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Degree (long numA, long numB){
    long result=1;
    //For non-natural numbers, I decided to stay it here. If we use non-natural numbers 
    //we need to use double everywere.
    //double resultNegativeDegree=1;
    //double numBPositive=0;
    /*
    if (numB<0){
        numBPositive=numB*(-1);
        for(double i=1; i<=numBPositive;i++){
        result=result*numA;}
        resultNegativeDegree=1/result;
        Console.WriteLine($"Number {numA} to the power of {numB} equals {resultNegativeDegree}");

    }
    else{*/
    
    for(long i=1; i<=numB;i++){
        result=result*numA;
        }
    Console.WriteLine($"Number {numA} to the power of {numB} equals {result}");
        }
        
        //}
        
Console.WriteLine("Input any integer: ");
long numA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree: ");
long numB=Convert.ToInt32(Console.ReadLine());
if (numA==0||numB==0){
    Console.WriteLine($"Number {numA} to the power of {numB} equals 0");
}
else {
    Degree(numA,numB);}


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
void SumOfNumbers (int num){
    int numResult=num;
    //For negative numbers
    if (num<0){
        num=num*(-1);
        }    
    int result=0;
    int resultRemainder=0;
    result=num/10;
    resultRemainder=num%10;
   
    if(result==0){
        Console.WriteLine($"Your sum of numbers of number {numResult} is  {num}");
        }
    else {
      
        for (int i =0; result>0;i++){
            resultRemainder=resultRemainder+result%10;
            result=result/10;
            }
        Console.WriteLine($"Your sum of numbers of number {numResult} is {resultRemainder}");
        }
    }

Console.WriteLine("Input any integer: ");
int num=Convert.ToInt32(Console.ReadLine());
SumOfNumbers(num);
*/

//Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
/*
void Array(int[] arr){
    Console.Write("[ ");
    for (int i=0;i<arr.Length;i++){
        if (i==arr.Length-1){
           Console.Write(arr[i]+ ""); 
        }
        else{
            Console.Write(arr[i]+ ", ");}
    }
        Console.Write(" ]");

}

Console.WriteLine("Input how many numbers/data you are going to input: ");
int input=Convert.ToInt32(Console.ReadLine());
if (input <0){
    Console.WriteLine("The numbers of data can't be negative");
}
else{
    int[] array=new int[input];
    int i=0;
    for (i=0;i<array.Length;i++){
        Console.WriteLine("Input any integer: ");
        int num=Convert.ToInt32(Console.ReadLine());
        array[i]=num;
    }
    Array(array);}
*/

