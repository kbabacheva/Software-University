import java.util.Scanner;


public class _1_Cinema {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String projection = input.nextLine();
		int rows = input.nextInt();
		int cols = input.nextInt();
		int places = rows*cols;
		double income = 0;
		if (projection.equals("Premiere")) {
			income = places*12.00;
			System.out.printf("%.2f leva",income);
		}
		else if (projection.equals("Normal")) {
			income = places*7.5;
			System.out.printf("%.2f leva",income);
		}
		else if (projection.equals("Discount")) {
			income = places*5;
			System.out.printf("%.2f leva",income);
		}
	}

}
