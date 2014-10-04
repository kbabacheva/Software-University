import java.util.Scanner;


public class _6_CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		String word = input.nextLine();
		int counter = 0;
		String[] words = text.split("([().,!?:;'\"-]|\\s)+");
		for (int i = 0; i < words.length; i++) {
			if (words[i].equals(word)) {
				counter++;
			}
		}
		System.out.println(counter);
	}

}
