// Напишите программу ,которая принимает на вход число и выдает количество цифр в числе
/*
void AmountOfNumbers (int num){
    int result=0;
    int count=1;
    //for(int i=0; i<count;i++){
        result=num/10;
        if(result==0){
            Console.WriteLine($"Your number {num} has 1 number");
        }
        else {
            for (int i =0; result>0;i++){
            //while (result!=0){
                result=result/10;
                count++;
            }
            Console.WriteLine($"Your number {num} has {count} numbers");
        }
    }




Console.WriteLine("Input any integer: ");
int num=Convert.ToInt32(Console.ReadLine());
AmountOfNumbers(num);
*/

//Напишите программу, которая находит в последовательности от 1 до N все нечетные числа


void OddNumbers (int num){
    int result=0;
    for(int i=1; i<=num;i++){
        result=i%2;
        if (result!=0){
            Console.Write($"{i} ");
        }
            
        }
    }




Console.WriteLine("Input any integer: ");
int num=Convert.ToInt32(Console.ReadLine());
OddNumbers(num);