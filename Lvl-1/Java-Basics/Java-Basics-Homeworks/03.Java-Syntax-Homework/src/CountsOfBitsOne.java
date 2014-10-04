import java.util.Scanner;


public class CountsOfBitsOne {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter integer variable: ");
		int num = input.nextInt();
		int counter = Integer.bitCount(num);
		System.out.printf("Ones in %d are %d", num, counter);
	}
}
