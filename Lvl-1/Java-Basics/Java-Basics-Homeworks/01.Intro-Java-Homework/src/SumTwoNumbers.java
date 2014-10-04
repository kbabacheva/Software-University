import java.util.Scanner;


public class SumTwoNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter first number: ");
		int num1 = input.nextInt();
		System.out.println("Enter second number: ");
		int num2 = input.nextInt();
		System.out.printf("%d + %d = %d", num1, num2, num1+num2);
	}

}
