int i = 0;
int totalSum = 0;
while(i == 0){
    Console.WriteLine("Введите число, или завершите ввод поставив 'Y': ");
    var number = Console.ReadLine();
    if(number == "Y"){
        i++;
    }
    else{
        if(Convert.ToInt32(number) > 0){
            totalSum = totalSum + 1;
        }
    }
}

Console.Write("Вы ввели " + Convert.ToString(totalSum)+ " больше 0");