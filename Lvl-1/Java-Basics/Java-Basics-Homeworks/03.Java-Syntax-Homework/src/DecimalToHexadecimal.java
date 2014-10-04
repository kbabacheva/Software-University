import java.util.Scanner;


public class DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter integer:");
		int num = input.nextInt();
		String hex = Integer.toHexString(num);
		System.out.println("Hex value is " + hex);
		
	}

}
