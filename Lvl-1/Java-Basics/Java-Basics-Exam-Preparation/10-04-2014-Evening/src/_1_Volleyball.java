import java.util.Scanner;


public class _1_Volleyball {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String year = input.nextLine();
		double holidays = input.nextInt();
		double hometown = input.nextInt();
		double weekends = 48;
		double normalWeeks = weekends - hometown;
		double normalWeeksPlaying = (3*normalWeeks)/4;
		double holidaysPlaying = (2*holidays)/3;
		double sum = normalWeeksPlaying + holidaysPlaying + hometown;
		double leapYear = sum + (sum*15)/100;
		int sumInt = (int) sum;
		int sumLeapYear = (int) leapYear;
		if (year.equals("normal")) {
			System.out.printf("%d",sumInt);
		}
		else if (year.equals("leap")) {
			System.out.printf("%d",sumLeapYear);
		}
	}

}
