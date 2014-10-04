import java.util.Scanner;


public class _5_CountOfAllWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		String[] words = text.split("([().,!?:;'\"-]|\\s)+");
		System.out.println("\n" + words.length);
	}

}
