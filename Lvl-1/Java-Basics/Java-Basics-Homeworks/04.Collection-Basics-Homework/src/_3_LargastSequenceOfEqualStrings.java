import java.util.Scanner;


public class _3_LargastSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputStr = input.nextLine();
		String[] strArray = inputStr.split(" ");
		int counter = 1;
		int tempCount = 1;
		String word = "";
		for (int i = 1; i < strArray.length; i++) {
			if (strArray[i].equals(strArray[i-1])) {
				tempCount++;
			}
			else {
				tempCount = 1;
			}
			if (tempCount > counter) {
				counter = tempCount;
				word = strArray[i];
			}
		}
		for (int i = 0; i < counter; i++) {
			System.out.print(word + " ");
		}
	}
}
