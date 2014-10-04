import java.util.ArrayList;
import java.util.Scanner;


public class _10_ExtractUniqueWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputStr = input.nextLine().toLowerCase();
		String[] words = inputStr.split("\\W+");
		ArrayList<String> uniqueWords = new ArrayList<> ();
		for (int i = 0; i < words.length; i++) {
			if (uniqueWords.contains(words[i]) == false) {
				uniqueWords.add(words[i]);
			}
		}
		uniqueWords.sort(null);
		
		for (String string : uniqueWords) {
			System.out.print(string + " ");
		}
	}

}
