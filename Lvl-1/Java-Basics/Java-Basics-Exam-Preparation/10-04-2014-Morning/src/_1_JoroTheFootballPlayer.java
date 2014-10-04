import java.util.Scanner;


public class _1_JoroTheFootballPlayer {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		char leap = input.next().charAt(0);
		int holiday = input.nextInt();
		int hometown = input.nextInt();
		int counterHometown = hometown;
		int weekends = 52;
		int normalWeekends = weekends - hometown;
		int counterNormalWeekends = 2*normalWeekends/3;	
		int counterHolidays = holiday/2;
		int sum = counterNormalWeekends + counterHolidays + counterHometown;
		if (leap == 'f') {
			System.out.println(sum);
		}
		else if (leap == 't') {
			System.out.println(sum+3);
		}
	}

}
