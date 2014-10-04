import java.util.Scanner;


public class _1_ExamSchedule {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int hour = Integer.parseInt(input.nextLine());
		int minute = Integer.parseInt(input.nextLine());
		String partOfDay = input.nextLine();
		int examHours = Integer.parseInt(input.nextLine());
		int examMinutes = Integer.parseInt(input.nextLine());
		int endHour = hour + examHours;
		int endMinute = minute+examMinutes;
		while (endMinute >= 60) {
			endHour++;
			endMinute -=60;
		}
		while (endHour > 12) {
			if (partOfDay.equals("AM")) {
				endHour -=12;
				partOfDay = "PM";
			}
			else if (partOfDay.equals("PM")) {
				endHour -=12;
				partOfDay = "AM";
			}
		}
		String hourStr = String.format("%02d", endHour);
		String minuteStr = String.format("%02d", endMinute);
		System.out.println(hourStr + ":" + minuteStr + ":" + partOfDay);
	}
}
