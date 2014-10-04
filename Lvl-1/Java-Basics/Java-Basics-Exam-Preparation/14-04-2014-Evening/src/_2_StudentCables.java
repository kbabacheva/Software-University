import java.util.Scanner;


public class _2_StudentCables {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = Integer.parseInt(input.nextLine());
		int sum = 0;
		for (int i = 0; i < n; i++) {
			int num = Integer.parseInt(input.nextLine());
			String str = input.nextLine();
			if (str.equals("centimeters")) {
				if (num < 20) {
					sum += 0;
				}
				else {
					sum += num - 3;
				}
			}
			else if (str.equals("meters")) {
				sum += num*100 - 3;
			}
		}
		sum += 3;
		int count = 0;
		while (sum >= 504) {
			sum -= 504;
			count++;
		}
		System.out.println(count);
		System.out.println(sum);
	}
}
