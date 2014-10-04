import java.util.Arrays;
import java.util.Scanner;


public class SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("How many capitals do you want to enter?");
		int n = Integer.parseInt(input.nextLine());
		//String empty = input.nextLine();
		String[] capitals = new String[n];
		for (int i = 0; i < n; i++) {
			capitals[i] = input.nextLine();
		}
		Arrays.sort(capitals);
		for (String capital : capitals) {
			System.out.println(capital);
		}
	}

}
