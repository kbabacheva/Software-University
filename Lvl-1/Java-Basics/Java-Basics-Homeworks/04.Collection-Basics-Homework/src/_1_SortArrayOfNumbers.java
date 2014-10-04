import java.util.Arrays;
import java.util.Scanner;


public class _1_SortArrayOfNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = Integer.parseInt(input.nextLine());
		String str = input.nextLine();
		String[] stringArray = str.split(" ");
		int[] intArray = new int[stringArray.length];
		for (int i = 0; i < intArray.length; i++) {
			intArray[i] = Integer.parseInt(stringArray[i]);
		}
		Arrays.sort(intArray);
		for (int i : intArray) {
			System.out.print(i + " ");
		}
	}
}
