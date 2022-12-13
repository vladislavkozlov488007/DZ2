Console.Write("Введите день недели от 1 до 7 : ");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1:
      Console.WriteLine("понедельник - рабочий день");
      break;
    case 2:
      Console.WriteLine("вторник - рабочий день");
      break;
    case 3:
       Console.WriteLine("среда - рабочий день");
      break;    
    case 4:
       Console.WriteLine("четверг - рабочий день");
      break;  
    case 5:
       Console.WriteLine("пятница - рабочий день");
      break;   
    case 6:
       Console.WriteLine("суббота - выходной день");
      break; 
    case 7:
       Console.WriteLine("воскресенье - выходной день");
      break;          
    default:
       Console.WriteLine("день недели не найден");
       break;    
}
    
