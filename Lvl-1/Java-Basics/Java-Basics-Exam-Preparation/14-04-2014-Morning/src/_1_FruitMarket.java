import java.util.Scanner;


public class _1_FruitMarket {
	
	public enum Days {

	    Monday,
	    Tuesday,
	    Wednesday,
	    Thursday,
	    Friday,
	    Saturday,
	    Sunday
	  }
	
	public enum Fruits {

	    banana,
	    cucumber,
	    tomato,
	    orange,
	    apple,
	  }
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
        double bananaPrice = 1.8;
        double cucumberPrice = 2.75;
        double tomatoPrice = 3.2;
        double orangePrice = 1.6;
        double applePrice = 0.86;
        double fruitMoney = 0;
        double totalPrice = 0;
		String day = input.nextLine();
		
		for (int i = 0; i < 3; i++) {
			String quantityStr = input.nextLine();
            double quantity = Double.parseDouble(quantityStr);
			String fruit = input.nextLine();
		    Days currentDay = Days.valueOf(day);
		    Fruits fruits = Fruits.valueOf(fruit);
            switch (fruits)
	            {
                   case banana:
                    switch (currentDay)
	                    {
                           case Monday: 
                               fruitMoney = quantity * bananaPrice;
                               totalPrice += fruitMoney;break;
                           case Tuesday:
                               fruitMoney = quantity * bananaPrice*0.8;
                               totalPrice += fruitMoney;break;
                           case Wednesday: 
                               fruitMoney = quantity * bananaPrice;
                               totalPrice += fruitMoney;break;
                           case Thursday: 
                               fruitMoney = quantity * bananaPrice * 0.7;
                               totalPrice += fruitMoney;
                               break;
                           case Friday:
                               fruitMoney = quantity * bananaPrice * 0.9;
                               totalPrice += fruitMoney; break;
                           case Saturday:
                               fruitMoney = quantity * bananaPrice;
                               totalPrice += fruitMoney;
                               break;
                           case Sunday:
                               fruitMoney = quantity * bananaPrice* 0.95;
                               totalPrice += fruitMoney;break; 
	                    }
                       break;
                   case cucumber:
                    switch (currentDay)
	                    {
                           case Monday:
                               fruitMoney = quantity * cucumberPrice;
                               totalPrice += fruitMoney;
                               break;
                           case Tuesday:
                               fruitMoney = quantity * cucumberPrice;
                               totalPrice += fruitMoney; break;
                           case Wednesday:
                               fruitMoney = quantity * cucumberPrice * 0.9;
                               totalPrice += fruitMoney; break;
                           case Thursday:
                               fruitMoney = quantity * cucumberPrice;
                               totalPrice += fruitMoney;
                               break;
                           case Friday:
                               fruitMoney = quantity * cucumberPrice * 0.9;
                               totalPrice += fruitMoney; break;
                           case Saturday:
                               fruitMoney = quantity * cucumberPrice;
                               totalPrice += fruitMoney;
                               break;
                           case Sunday:
                               fruitMoney = quantity * cucumberPrice * 0.95;
                               totalPrice += fruitMoney; break; 
	                    }
                       break;
                   case tomato:
                       switch (currentDay)
                       {
                           case Monday:
                               fruitMoney = quantity * tomatoPrice;
                               totalPrice += fruitMoney;
                               break;
                           case Tuesday:
                               fruitMoney = quantity * tomatoPrice;
                               totalPrice += fruitMoney; break;
                           case Wednesday:
                               fruitMoney = quantity * tomatoPrice * 0.9;
                               totalPrice += fruitMoney; break;
                           case Thursday:
                               fruitMoney = quantity * tomatoPrice;
                               totalPrice += fruitMoney;
                               break;
                           case Friday:
                               fruitMoney = quantity * tomatoPrice * 0.9;
                               totalPrice += fruitMoney; break;
                           case Saturday:
                               fruitMoney = quantity * tomatoPrice;
                               totalPrice += fruitMoney;
                               break;
                           case Sunday:
                               fruitMoney = quantity * tomatoPrice * 0.95;
                               totalPrice += fruitMoney; break;
                       }
                       break;
                   case orange:
                       switch (currentDay)
                       {
                           case Monday:
                               fruitMoney = quantity * orangePrice;
                               totalPrice += fruitMoney;
                               break;
                           case Tuesday:
                               fruitMoney = quantity * orangePrice * 0.8;
                               totalPrice += fruitMoney; break;
                           case Wednesday:
                               fruitMoney = quantity * orangePrice;
                               totalPrice += fruitMoney; break;
                           case Thursday:
                               fruitMoney = quantity * orangePrice;
                               totalPrice += fruitMoney;
                               break;
                           case Friday:
                               fruitMoney = quantity * orangePrice * 0.9;
                               totalPrice += fruitMoney; break;
                           case Saturday:
                               fruitMoney = quantity * orangePrice;
                               totalPrice += fruitMoney;
                               break;
                           case Sunday:
                               fruitMoney = quantity * orangePrice * 0.95;
                               totalPrice += fruitMoney; break;
                       }
                       break;
                   case apple:
                       switch (currentDay)
                       {
                           case Monday:
                               fruitMoney = quantity * applePrice;
                               totalPrice += fruitMoney;
                               break;
                           case Tuesday:
                               fruitMoney = quantity * applePrice * 0.8;
                               totalPrice += fruitMoney; break;
                           case Wednesday:
                               fruitMoney = quantity * applePrice;
                               totalPrice += fruitMoney; break;
                           case Thursday:
                               fruitMoney = quantity * applePrice;
                               totalPrice += fruitMoney;
                               break;
                           case Friday:
                               fruitMoney = quantity * applePrice * 0.9;
                               totalPrice += fruitMoney; break;
                           case Saturday:
                               fruitMoney = quantity * applePrice;
                               totalPrice += fruitMoney;
                               break;
                           case Sunday:
                               fruitMoney = quantity * applePrice * 0.95;
                               totalPrice += fruitMoney; break;
                       }
                       break;
	            }
			}
		System.out.printf("%.2f",totalPrice);
	}
}

