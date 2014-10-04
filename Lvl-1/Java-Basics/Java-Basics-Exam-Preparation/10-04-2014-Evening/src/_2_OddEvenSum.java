import java.util.Scanner;


public class _2_OddEvenSum {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		int odd = 0;
		int oddSum = 0;
		int even = 0;
		int evenSum = 0;
		for (int i = 1; i <= num*2; i++) {
			if (i % 2 != 0) {
				odd = input.nextInt();
				oddSum += odd;
			}
			else if (i % 2 == 0) {
				even = input.nextInt();
				evenSum +=even;
			}
		}
		if (oddSum == evenSum) {
			System.out.println("Yes, sum=" + oddSum);
		}
		else {
			if (oddSum > evenSum) {
				System.out.println("No, diff=" + (oddSum - evenSum));
			}
			else if (evenSum > oddSum) {
				System.out.println("No, diff=" + (evenSum - oddSum));
			}
		}
	}

}
