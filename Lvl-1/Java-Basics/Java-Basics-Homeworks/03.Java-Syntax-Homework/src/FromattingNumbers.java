import java.util.Scanner;


public class FromattingNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter integer variable: ");
		int a = input.nextInt();
		System.out.println("Enter double variable: ");
		double b = input.nextDouble();
		System.out.println("Enter double variable: ");
		double c = input.nextDouble();
		String aHex = Integer.toHexString(a).toUpperCase();;
		String aBin = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
		System.out.printf("|%-10s|%s|%10.2f|%-10.3f|",aHex,aBin,b,c);
	}

}
