import java.util.Arrays;
import java.util.Scanner;


public class _2_SumOfElements {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String first = input.nextLine();
		String[] firstArray = first.split(" ");
		int[] intArray = new int[firstArray.length];
		for (int i = 0; i < intArray.length; i++) {
			intArray[i] = Integer.parseInt(firstArray[i]);
		}
		Arrays.sort(intArray);
		int lastElement = intArray[intArray.length - 1];
		int sum = 0;
		for (int i = 0; i < intArray.length - 1; i++) {
			sum += intArray[i];
		}
		if (lastElement == sum) {
			System.out.println("Yes, sum=" + sum);
		}
		else {
			if (lastElement > sum) {
				System.out.println("No, diff=" + (lastElement - sum));
			}
			else if (lastElement < sum) {
				System.out.println("No, diff=" + (sum - lastElement));
			}
		}
	}

}
