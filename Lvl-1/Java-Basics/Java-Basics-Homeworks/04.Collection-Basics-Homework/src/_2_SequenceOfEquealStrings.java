import java.util.Scanner;


public class _2_SequenceOfEquealStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputStr = input.nextLine();
		String[] strArray = inputStr.split(" ");
		System.out.print(strArray[0]);
		for (int i = 1; i < strArray.length; i++) {
			if (strArray[i].equals(strArray[i-1])) {
				System.out.print(" " + strArray[i]);
			}
			else {
				System.out.print("\n" + strArray[i]);
				
			}
		}
	}

}
