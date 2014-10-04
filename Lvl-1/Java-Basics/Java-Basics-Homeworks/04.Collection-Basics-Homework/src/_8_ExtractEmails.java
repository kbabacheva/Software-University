import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class _8_ExtractEmails {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		String email = "[0-9a-zA-Z][-0-9a-zA-Z.+_]+[0-9a-zA-Z]+@[0-9a-zA-Z]+\\.[a-zA-Z]{2,7}";
		Pattern emailPattern = Pattern.compile(email);
		Matcher emailMatcher = emailPattern.matcher(text);
		while (emailMatcher.find()) {
			System.out.println(emailMatcher.group());
		}
	}

}
