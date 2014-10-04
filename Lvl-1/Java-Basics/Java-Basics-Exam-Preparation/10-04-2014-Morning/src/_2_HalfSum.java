import java.util.Scanner;


public class _2_HalfSum {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		int n1 = 0;
		int sum1 = 0;
		int n2 = 0;
		int sum2 = 0;
		for (int i = 0; i < number; i++) {
			n1 = input.nextInt();
			sum1 +=n1;
		}
		for (int i = 0; i < number; i++) {
			n2 = input.nextInt();
			sum2 +=n2;
		}
		if (sum1 == sum2) {
			System.out.println("Yes, sum="+sum1);
		}
		else if (sum1 != sum2) {
			if (sum1 > sum2) {
				System.out.println("No, diff="+(sum1-sum2));
			}
			else if (sum2 > sum1) {
				System.out.println("No, diff="+(sum2-sum1));
			}
		}
	}

}
