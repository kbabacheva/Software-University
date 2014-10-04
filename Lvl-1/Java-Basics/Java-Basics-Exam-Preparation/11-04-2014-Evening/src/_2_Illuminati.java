import java.util.Scanner;


public class _2_Illuminati {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		char[] charArray = str.toCharArray();
		int counter = 0;
		int sumVowels = 0;
		for (int i = 0; i < charArray.length; i++) {
			if (charArray[i] == 'a' || charArray[i] == 'A') {
				counter++;
				sumVowels += 65;
			}
			if (charArray[i] == 'e' || charArray[i] == 'E') {
				counter++;
				sumVowels += 69;
			}
			if (charArray[i] == 'i' || charArray[i] == 'I') {
				counter++;
				sumVowels += 73;
			}
			if (charArray[i] == 'o' || charArray[i] == 'O') {
				counter++;
				sumVowels += 79;
			}
			if (charArray[i] == 'u' || charArray[i] == 'U') {
				counter++;
				sumVowels += 85;
			}
		}
		System.out.println(counter);
		System.out.println(sumVowels);
	}

}
