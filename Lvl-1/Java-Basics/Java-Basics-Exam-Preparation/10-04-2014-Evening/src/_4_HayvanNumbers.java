import java.util.Scanner;


public class _4_HayvanNumbers {
	
	public static int sumOfDigits(int number){
		int first = number/100;
		int second = number%100/10;
		int third = number%10;
		return first+second+third;
	}
	
	public static boolean isCorrect(int number) {
		int first = number/100;
		int second = number%100/10;
		int third = number%10;
		return first > 4 && first <= 9 && second > 4 && second <= 9 && third > 4 && third <= 9;
	}

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int sum = input.nextInt();
		int diff = input.nextInt();
		boolean foundAny = false;
		for (int n1 = 555; n1 <= 999; n1++) {
			int n2 = n1 + diff;
			int n3 = n1 + 2*diff;
			if (sumOfDigits(n1) + sumOfDigits(n2) + sumOfDigits(n3) == sum && isCorrect(n1) && isCorrect(n2) && isCorrect(n3)) {
				foundAny = true;
				System.out.println(n1+""+n2+""+n3);
			}
		}
		if (!foundAny) {
			System.out.println("No");
		}
	}

}
