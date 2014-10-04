import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;


public class _4_MagicDates {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Duration of 1 day in milliseconds
		final long DAY_IN_MILLS = 1000*60*60*24;
		int startYear = input.nextInt();
		int endYear = input.nextInt();
		int magicWeight = input.nextInt();
		boolean hasMagicDate = false;
		
		Calendar startCalendar = Calendar.getInstance();
		startCalendar.set(startYear,0,1,0,0);
		Date startDate = startCalendar.getTime();
		
		Calendar endCalendar = Calendar.getInstance();
		endCalendar.set(endYear + 1,0,1,0,0);
		Date endDate = endCalendar.getTime();
		
		int diffInDays = (int) ((endDate.getTime() - startDate.getTime())/DAY_IN_MILLS);
		for (int i = 0; i < diffInDays; i++) {
			Date currentDate = new Date(startDate.getTime() + i*DAY_IN_MILLS);
			Calendar current = Calendar.getInstance();
			
			current.setTime(currentDate);
			String extracted = extractDate(current,"");
			int currentWeight = getMagicWeight(extracted);
			
			if (currentWeight == magicWeight) {
				System.out.println(extractDate(current,"-"));
				hasMagicDate = true;
			}
		}
		if (!hasMagicDate) {
			System.out.println("No");
		}
	}
	
	public static int getMagicWeight(String string) {
		int result = 0;
		for (int i = 0; i < string.length(); i++) {
			for (int j = i + 1; j < string.length(); j++) {// 1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 7*0 + 7*3 + 7*2 + 7*0 + 7*0 + 7*7 + 0*3 + 0*2 + 0*0 + 0*0 + 0*7 + 3*2 + 3*0 + 3*0 + 3*7 + 2*0 + 2*0 + 2*7 + 0*0 + 0*7 + 0*7 = 144.
				int first = Integer.parseInt(Character.toString(string.charAt(i))); // Parsing char to String
			//	int first = Integer.parseInt("" + string.charAt(i)); Parsing char to String
				int second = Integer.parseInt("" + string.charAt(j));
				
				result += first*second;
			}
		}
		return result;
	}
	
	public static String extractDate(Calendar cal,String separator){
		String date = "";
		date += cal.get(Calendar.DAY_OF_MONTH) < 10 ? "0" : "";
		date += cal.get(Calendar.DAY_OF_MONTH);
		date += separator;
		date += cal.get(Calendar.MONTH) < 9 ? "0" : "";
		date += cal.get(Calendar.MONTH) + 1;
		date += separator;
		date += cal.get(Calendar.YEAR);
		return date;
	}
}
