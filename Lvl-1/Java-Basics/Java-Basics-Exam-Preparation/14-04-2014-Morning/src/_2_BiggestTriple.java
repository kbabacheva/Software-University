import java.util.Scanner;

public class _2_BiggestTriple {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputStr = input.nextLine();
		String[] allLetters = inputStr.split(" ");
		int[] numbers = new int[allLetters.length];
		for (int i = 0; i < allLetters.length; i++) {
			numbers[i] = Integer.parseInt(allLetters[i]);
		}
		int sum;
		int[] sumArray = new int[numbers.length];
		int maxSum = Integer.MIN_VALUE;
		String output = "";
		if (allLetters.length % 3 == 0) {
			for (int i = 0, j = 0; i < numbers.length; i += 3, j++) {
				sum = numbers[i] + numbers[i + 1] + numbers[i + 2];
				if (sum > maxSum) {
					maxSum = sum;
					output = numbers[i] + " " + numbers[i + 1] + " "
							+ numbers[i + 2];
				}
			}
			System.out.println(output);
		} else if (allLetters.length % 3 == 1) {
			for (int i = 0, j = 0; i < numbers.length - 1; i += 3, j++) {
				sum = numbers[i] + numbers[i + 1] + numbers[i + 2];
				if (sum > maxSum) {
					maxSum = sum;
					output = numbers[i] + " " + numbers[i + 1] + " "
							+ numbers[i + 2];
				}
			}
			int lastDigit = numbers[numbers.length - 1];
			if (lastDigit > maxSum) {
				System.out.println(lastDigit);
			} else {
				System.out.println(output);
			}
		} else if (allLetters.length % 3 == 2) {
			for (int i = 0, j = 0; i < numbers.length - 2; i += 3, j++) {
				sum = numbers[i] + numbers[i + 1] + numbers[i + 2];
				if (sum > maxSum) {
					maxSum = sum;
					output = numbers[i] + " " + numbers[i + 1] + " "
							+ numbers[i + 2];
				}
			}
			int last = numbers[numbers.length - 1];
			int beforeLast = numbers[numbers.length - 2];
			int sumLastTwo = last + beforeLast;
			if (sumLastTwo > maxSum) {
				System.out.println(beforeLast + " " + last);
			} else {
				System.out.println(output);
			}
		}
	}
}
