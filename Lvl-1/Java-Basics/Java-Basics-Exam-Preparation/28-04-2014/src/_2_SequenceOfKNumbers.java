
import java.util.Scanner;


public class _2_SequenceOfKNumbers {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		input = input + " " + Integer.MAX_VALUE;
		String[] stringArray = input.split(" ");
		int k = sc.nextInt();;
		int counter = 1;
		int prev = Integer.parseInt(stringArray[0]);
		for (int i = 1; i < stringArray.length; i++) {
			int num = Integer.parseInt(stringArray[i]);
			if (num == prev) {
				counter++;
			}
			else {
				for (int j = 0; j < counter%k; j++) {
					System.out.print(prev + " ");
				}
				counter = 1;
			}
			prev = num;
		}
	}
}
